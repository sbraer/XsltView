using System.Xml;

namespace XsltUtilities
{
    // 		LineNumber, LinePosition
    internal static class XmlReaderCustom
    {
        public static int LineNumber(this XmlReader xmlreader)
        {
            IXmlLineInfo obj = (IXmlLineInfo)xmlreader;
            return obj.LineNumber;
        }
        public static int LinePosition(this XmlReader xmlreader)
        {
            IXmlLineInfo obj = (IXmlLineInfo)xmlreader;
            return obj.LinePosition;
        }
    }
}
