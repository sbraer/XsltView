using System.Xml.Xsl;

namespace XsltUtilities
{
    public interface IXsltTransformation
    {
        string TransformXsltFromString(string xmlContent, string xsltFileContent, XsltArgumentList args = null);
        string EvaluateXPath(string xmlContent, string xPath);
        string XmlMinification(string xmlContent);
        XPathNamespaceReply CheckXPaths(string xmlContent, int column, int row);
    }
}