using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using XsltUtilities;

namespace XsltViewer
{
    public partial class Form1 : Form
    {
        private readonly IXsltTransformation _xsltTransformation;
        private readonly XPathForm _xpathDialog;
        private List<Control> _controlsListBlockable;
        private Form1() { }
        public Form1(XPathForm xpathDialog, IXsltTransformation xsltTransformation)
        {
            _xpathDialog = xpathDialog;
            _xsltTransformation = xsltTransformation;
            InitializeComponent();
            Icon = Resource1.Icon1;
        }

        private DialogResult ShowMessageBox(string text, string title = "Error", MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK, MessageBoxIcon messageBoxIcon = MessageBoxIcon.Error)
        {
            return MessageBox.Show(text, title, messageBoxButtons, messageBoxIcon);
        }

        private void EnableControls(bool enabled)
        {
            _controlsListBlockable.ForEach(t => t.Enabled = enabled);
        }

        private void SetStatusInfo(string controlName, string positionString)
        {
            ToolStripStatusLabel1.Text = controlName;
            ToolStripStatusLabel2.Text = positionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripStatusLabel1.Text = string.Empty;
            ToolStripStatusLabel2.Text = string.Empty;
            TxtXml.EmptyUndoBuffer();
            TxtXslt.EmptyUndoBuffer();
            TxtOutput.EmptyUndoBuffer();

            IEnumerable<Control> GetAll(Control control)
            {
                var controls = control.Controls.Cast<Control>();
                return controls.SelectMany(ctrl => GetAll(ctrl)).Concat(controls);
            }

            _controlsListBlockable = GetAll(this).Where(t => t.Tag?.ToString() == "blockable").ToList();
        }

        private void BtnTransform_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            var pars = (xml: TxtXml.Text, xslt: TxtXslt.Text);
            BwTransform.RunWorkerAsync(pars);
        }

        private void BtnXpath_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            var pars = (xml: TxtXml.Text, xpath: TxtXPath.Text);
            BwXPath.RunWorkerAsync(pars);
        }

        private void ToolStripMinificationButton_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            BwMiniXml.RunWorkerAsync(TxtXml.Text);
        }

        private void BtnWrapUnwrap_Click(object sender, EventArgs e)
        {
            if (BtnWrapUnwrap.Text == "Wrap")
            {
                BtnWrapUnwrap.Text = "Unwrap";
                TxtOutput.WrapMode = WrapMode.None;
            }
            else
            {
                BtnWrapUnwrap.Text = "Wrap";
                TxtOutput.WrapMode = WrapMode.Whitespace;
            }
        }

        private void ToolStripSearchXPath_Click(object sender, EventArgs e)
        {
            EnableControls(false);
            string xmlContent = TxtXml.Text;
            int column = TxtXml.GetColumn(TxtXml.CurrentPosition);
            int row = TxtXml.CurrentLine + 1;
            var pars = (xml: xmlContent, column, row);
            BwSearchXPath.RunWorkerAsync(pars);
        }

        private void TxtXPath_DoubleClick(object sender, EventArgs e)
        {
            TxtXPath.SelectAll();
        }
        public void ClearAllSelections(ToolStrip toolStrip)
        {
            // Call private method using reflection
            MethodInfo method = typeof(ToolStrip).GetMethod("ClearAllSelections", BindingFlags.NonPublic | BindingFlags.Instance);
            method?.Invoke(toolStrip, null);
        }

        private void BwMiniXml_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string xmlContent = e.Argument.ToString();
            e.Result = _xsltTransformation?.XmlMinification(xmlContent);
        }

        private void BwMiniXml_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                TxtOutput.Text = e.Error.Message;
                TxtOutput.RefreshUndoRedoButton();
            }
            else
            {
                TxtXml.Text = e.Result?.ToString();
                TxtXml.RefreshUndoRedoButton();
            }

            ClearAllSelections(XmlMiniButton.GetCurrentParent());
            EnableControls(true);
        }

        private void BwXPath_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var pars = ((string xml, string xpath))e.Argument;
            string xml = pars.xml;
            string xpath = pars.xpath;
            string newContent = _xsltTransformation?.EvaluateXPath(xml, xpath);
            e.Result = string.IsNullOrEmpty(newContent) ? "No output" : newContent;
        }

        private void BwXPath_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            TxtOutput.Text = (e.Error != null) ? e.Error.Message.ToString() : e.Result?.ToString();
            TxtOutput.RefreshUndoRedoButton();
            EnableControls(true);
        }

        private void BwTransform_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var pars = ((string xml, string xslt))e.Argument;
            string xml = pars.xml;
            string xslt = pars.xslt;
            string newContent = _xsltTransformation?.TransformXsltFromString(xml, xslt, null);
            e.Result = string.IsNullOrEmpty(newContent) ? "No output" : newContent;
        }

        private void BwTransform_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            TxtOutput.Text = (e.Error != null) ? e.Error.Message : e.Result?.ToString();
            TxtOutput.RefreshUndoRedoButton();
            EnableControls(true);
        }

        private void BwSearchXPath_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var pars = ((string xmlContent, int column, int row))e.Argument;
            string xmlContent = pars.xmlContent;
            int column = pars.column;
            int row = pars.row;
            e.Result = _xsltTransformation?.CheckXPaths(xmlContent, column, row);
        }

        private void BwSearchXPath_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                ShowMessageBox(e.Error.Message);
            }
            else
            {
                var reply = (XPathNamespaceReply)e.Result;
                if (!string.IsNullOrEmpty(reply?.XPath) && _xpathDialog != null)
                {
                    _xpathDialog.XPath = reply.XPath;
                    _xpathDialog.Namespaces = reply.Namespaces;
                    _xpathDialog.NamespaceVirtual = reply.NamespaceVirtual;
                    _xpathDialog.ShowDialog();
                }
            }

            ClearAllSelections(ToolStrip1);
            EnableControls(true);
        }

        private void BtPasteXPath_Click(object sender, EventArgs e)
        {
            TxtXPath.Text = Clipboard.GetText();
        }
    }
}
