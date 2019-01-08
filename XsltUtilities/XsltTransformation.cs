using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Xsl;
using XsltUtilities.Classes;

namespace XsltUtilities
{
    public class XsltTransformation : IXsltTransformation
    {
        public XsltTransformation()
        { }

        public string TransformXsltFromString(string xmlContent, string xsltFileContent, XsltArgumentList args = null)
        {
            XmlDocument stylesheet = new XmlDocument();
            stylesheet.LoadXml(xsltFileContent);
            XmlDocument doc = new XmlDocument();
            doc.XmlResolver = null;
            doc.LoadXml(xmlContent.ToString());

            XslCompiledTransform transform = new XslCompiledTransform();
            XsltSettings xsltSettings = new XsltSettings
            {
                EnableDocumentFunction = true,
                EnableScript = true
            };

            var _xmlresolver = new XmlUrlResolver();
            transform.Load(stylesheet, xsltSettings, _xmlresolver); // compiled stylesheet
            var writer = new StringWriter();
            var xmlReadB = new XmlTextReader(new StringReader(doc.DocumentElement.OuterXml));
            transform.Transform(xmlReadB, args, writer);
            return writer.ToString().Trim();
        }

        public string EvaluateXPath(string xmlContent, string xPath)
        {
            var resultString = new StringBuilder();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlContent);
            var nodes = xmlDoc.SelectNodes(xPath);
            foreach (XmlNode node in nodes)
            {
                resultString.Append(node.InnerXml);
                resultString.Append(Environment.NewLine);
            }

            return resultString.ToString();
        }

        public string XmlMinification(string xmlContent)
        {
            var mini = new XMLMinifier(XMLMinifierSettings.Aggressive);
            return mini.Minify(xmlContent);
        }

        public XPathNamespaceReply CheckXPaths(string xmlContent, int column, int row)
        {
            using (XmlReader reader = XmlReader.Create(new MemoryStream(Encoding.UTF8.GetBytes(xmlContent ?? string.Empty))))
            {
                var root = new NodeStructure(string.Empty, -1, null);
                var globalNamespace = GetItems(root, reader);
                string namespaceVirtual = string.Empty;
                if (globalNamespace.ContainsKey(string.Empty))
                {
                    do
                    {
                        namespaceVirtual += "a";
                    } while (globalNamespace.ContainsKey(namespaceVirtual));
                }
                var item = SearchXPath(root.Items[0], column, row);
                if (item != null)
                {
                    var namespaces = FoundXPath(item, namespaceVirtual);
                    return new XPathNamespaceReply()
                    {
                        XPath = item.XPath,
                        Namespaces = namespaces,
                        NamespaceVirtual = namespaceVirtual
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        private NodeStructure SearchXPath(NodeStructure root, int column, int row)
        {
            NodeStructure CheckItems()
            {
                var coll = root.Items;
                foreach (var item in coll)
                {
                    var reply = SearchXPath(item, column, row);
                    if (reply != null)
                    {
                        return reply;
                    }
                }

                return root;
            }

            if (root.LineNumberStart <= row && root.LineNumberEnd >= row)
            {
                if (root.LineNumberEnd == root.LineNumberStart)
                {
                    if (root.PositionStart <= column && root.PositionEnd >= column)
                    {
                        return CheckItems();
                    }
                }
                else if (root.LineNumberStart == row)
                {
                    if (root.PositionStart <= column)
                    {
                        return CheckItems();
                    }
                }
                else if (root.LineNumberEnd == row)
                {
                    if (root.PositionEnd >= column)
                    {
                        return CheckItems();
                    }
                }
                else
                {
                    return CheckItems();
                }
            }

            return null;
        }

        internal SortedDictionary<string, string> GetItems(NodeStructure root, XmlReader reader)
        {
            var namespaces = new SortedDictionary<string, string>();
            NodeStructure buffer = root;
            bool closePrev = false;

            while (reader.Read())
            {
                int ln = reader.LineNumber();
                int lp = reader.LinePosition();

                if (closePrev)
                {
                    buffer.LineNumberEnd = ln;
                    buffer.PositionEnd = lp - 1;
                    buffer = buffer.Parent;
                    closePrev = false;
                }

                if (reader.NodeType == XmlNodeType.Element)
                {
                    //sb.Append($"{ln} {lp} {reader.Depth} {reader.LocalName}\r\n");
                    buffer = new NodeStructure(reader.LocalName, reader.Depth, buffer)
                    {
                        Namespace = reader.NamespaceURI,
                        LineNumberStart = ln,
                        PositionStart = lp - 2,
                        Prefix = reader.Prefix
                    };

                    buffer.Parent.Items.Add(buffer);
                    if (reader.AttributeCount > 0)
                    {
                        for (int i = 0; i < reader.AttributeCount; i++)
                        {
                            reader.MoveToAttribute(i);
                            string nameAttribute = reader.Name;
                            if (nameAttribute != "xmlns" && !nameAttribute.StartsWith("xmlns:"))
                            {
                                buffer.Attributes.Add(nameAttribute, reader.Value);
                            }
                        }

                        reader.MoveToElement();
                    }

                    if (!string.IsNullOrEmpty(buffer.Namespace) && !namespaces.ContainsKey(buffer.Prefix))
                    {
                        namespaces.Add(buffer.Prefix, buffer.Namespace);
                    }

                    closePrev = reader.IsEmptyElement;
                }
                else if (reader.NodeType == XmlNodeType.EndElement)
                {
                    if (buffer != null)
                    {
                        buffer.LineNumberEnd = ln;
                        buffer.PositionEnd = lp + buffer.NodeName.Length + (!string.IsNullOrEmpty(buffer.Prefix) ? buffer.Prefix.Length + 1 : 0);
                        buffer = buffer.Parent;
                    }
                }
            }

            return namespaces;
        }

        private SortedDictionary<string, string> FoundXPath(NodeStructure root, string namespaceVirtual)
        {
            var actual = root;
            var namespaces = new SortedDictionary<string, string>();
            Func<NodeStructure, string> getNodeNameCustom = (customNode) =>
                        {
                            string namespaceString = string.Empty;
                            if (!string.IsNullOrEmpty(customNode.Namespace))
                            {
                                namespaceString = (string.IsNullOrEmpty(customNode.Prefix) ? namespaceVirtual : customNode.Prefix) + ":";
                            }

                            return namespaceString + customNode.NodeName;
                        };

            string getNodeName() => getNodeNameCustom(actual);

            string xpath = string.Empty;
            while (actual.Parent != null)
            {
                if (!string.IsNullOrEmpty(actual.Namespace))
                {
                    if (!namespaces.ContainsKey(actual.Prefix))
                    {
                        namespaces.Add(actual.Prefix, actual.Namespace);
                    }
                }

                var items = actual.Parent.Items;
                if (items.Count == 1)
                {
                    xpath = $"/{getNodeName()}{xpath}";
                    actual = actual.Parent;
                    continue;
                }

                if (items.Where(t => t.NodeName == actual.NodeName).Count() == 1)
                {
                    xpath = $"/{getNodeName()}{xpath}";
                    actual = actual.Parent;
                    continue;
                }

                var subItems = items.Where(t => getNodeNameCustom(t) == getNodeName() && t.Attributes.Count == 0 && actual.Attributes.Count == 0).ToList();
                if (subItems.Count > 1)
                {
                    for (int i = 0; i < subItems.Count; i++)
                    {
                        if (subItems[i] == actual)
                        {
                            xpath = $"/{getNodeName()}[{i + 1}]{xpath}";
                            break;
                        }
                    }

                    actual = actual.Parent;
                    continue;
                }

                var subItems2 = items.Where(t => getNodeNameCustom(t) == getNodeName() && t.HashFromAttribute == actual.HashFromAttribute).ToList();
                if (subItems2.Count == 1)
                {
                    var attrs = new StringBuilder();
                    if (actual.Attributes.Count > 0)
                    {
                        foreach (KeyValuePair<string, string> item in actual.Attributes)
                        {
                            attrs.Append((attrs.Length == 0) ? "[" : " and ");
                            string quote = item.Value.Contains("\"") ? "'" : "\"";
                            attrs.Append($"@{item.Key}={quote}{item.Value}{quote}");
                        }

                        attrs.Append("]");
                    }

                    xpath = $"/{getNodeName()}{attrs}{xpath}";
                    actual = actual.Parent;
                    continue;
                }

                {
                    var attrs = new StringBuilder();
                    if (actual.Attributes.Count > 0)
                    {
                        foreach (KeyValuePair<string, string> item in actual.Attributes)
                        {
                            attrs.Append((attrs.Length == 0) ? "[" : " and ");
                            string quote = item.Value.Contains("\"") ? "'" : "\"";
                            attrs.Append($"@{item.Key}={quote}{item.Value}{quote}");
                        }

                        attrs.Append("]");
                    }

                    for (int i = 0; i < subItems2.Count; i++)
                    {
                        if (subItems2[i] == actual)
                        {
                            xpath = $"/{getNodeName()}{attrs}[{i + 1}]{xpath}";
                            break;
                        }
                    }

                    actual = actual.Parent;
                    continue;
                }
            }

            root.XPath = xpath;
            return namespaces;
        }
    }
}
