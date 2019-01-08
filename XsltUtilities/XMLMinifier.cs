﻿using System.IO;
using System.Text;
using System.Xml;

namespace XsltUtilities
{
    internal class XMLMinifierSettings
    {
        public bool RemoveEmptyLines { get; set; }
        public bool RemoveWhitespaceBetweenElements { get; set; }
        public bool CloseEmptyTags { get; set; }
        public bool RemoveComments { get; set; }

        internal static XMLMinifierSettings Aggressive
        {
            get
            {
                return new XMLMinifierSettings
                {
                    RemoveEmptyLines = true,
                    RemoveWhitespaceBetweenElements = true,
                    CloseEmptyTags = true,
                    RemoveComments = true
                };
            }
        }

        internal static XMLMinifierSettings NoMinification
        {
            get
            {
                return new XMLMinifierSettings
                {
                    RemoveEmptyLines = false,
                    RemoveWhitespaceBetweenElements = false,
                    CloseEmptyTags = false,
                    RemoveComments = false
                };
            }
        }
    }

    /// <summary>
    /// XML minifier. No Regex allowed! ;-)
    /// 
    /// Example)
    ///     var sampleXml = File.ReadAllText("somefile.xml");
    ///     var minifiedXml = new XMLMinifier(XMLMinifierSettings.Aggressive).Minify(sampleXml);
    /// </summary>
    internal class XMLMinifier
    {
        private XMLMinifierSettings _minifierSettings;

        internal XMLMinifier(XMLMinifierSettings minifierSettings)
        {
            _minifierSettings = minifierSettings;
        }

        internal string Minify(string xml)
        {
            var originalXmlDocument = new XmlDocument();
            originalXmlDocument.PreserveWhitespace = !(_minifierSettings.RemoveWhitespaceBetweenElements || _minifierSettings.RemoveEmptyLines);
            originalXmlDocument.Load(new MemoryStream(Encoding.UTF8.GetBytes(xml)));

            //remove comments first so we have less to compress later
            if (_minifierSettings.RemoveComments)
            {
                foreach (XmlNode comment in originalXmlDocument.SelectNodes("//comment()"))
                {
                    comment.ParentNode.RemoveChild(comment);
                }
            }

            if (_minifierSettings.CloseEmptyTags)
            {
                foreach (XmlElement el in originalXmlDocument.SelectNodes("descendant::*[not(*) and not(normalize-space())]"))
                {
                    el.IsEmpty = true;
                }
            }

            if (_minifierSettings.RemoveWhitespaceBetweenElements)
            {
                return originalXmlDocument.InnerXml;
            }
            else
            {
                var minified = new MemoryStream();
                originalXmlDocument.Save(minified);

                return Encoding.UTF8.GetString(minified.ToArray());
            }
        }
    }
}
