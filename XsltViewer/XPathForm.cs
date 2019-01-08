using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace XsltViewer
{
    public partial class XPathForm : Form
    {
        public string XPath
        {
            set; private get;
        }

        public string NamespaceVirtual
        {
            set; private get;
        }

        public SortedDictionary<string, string> Namespaces
        {
            set; private get;
        }
        public XPathForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            ShowXPath();
        }

        private void ShowXPath()
        {
            TxtXPath.ReadOnly = false;
            string xpathToShow = XPath;

            if (Namespaces != null && Namespaces.Count > 0)
            {
                var namespaceToInclude = new StringBuilder();
                foreach (KeyValuePair<string, string> item in Namespaces)
                {
                    namespaceToInclude.Append($"{Environment.NewLine}  xmlns:{(string.IsNullOrEmpty(item.Key) ? NamespaceVirtual : item.Key)}=\"{item.Value}\"");
                }

                xpathToShow += string.Format(Resource1.XsltNamespaceDeclaration, namespaceToInclude.ToString());
            }

            /* using regex, only for my test
                Match match = Regex.Match(xpathToShow, @"^[\/]+[^\/]+\/(.*)", RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    string key = match.Groups[1].Value;
                    xpathToShow = key;
                }
            }*/

            TxtXPath.Text = xpathToShow;
            TxtXPath.ReadOnly = true;
        }

        private void BtnXPath_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(XPath);
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void XPathForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
