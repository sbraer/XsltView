using System.Collections.Generic;

namespace XsltUtilities
{
    public class XPathNamespaceReply
    {
        public string XPath { get; internal set; }
        public SortedDictionary<string, string> Namespaces { get; internal set; }
        public string NamespaceVirtual { get; internal set; }
    }
}
