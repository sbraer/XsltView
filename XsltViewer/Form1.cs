using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;
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

            FixScintillaStyles(TxtXml);
            FixScintillaStyles(TxtXslt);
        }

        private void FixScintillaStyles(ScintillaTextEditorCustom scintilla)
        {
            // Reset the styles
            scintilla.StyleResetDefault();
            scintilla.Styles[Style.Default].Font = "Consolas";
            scintilla.Styles[Style.Default].Size = 11;
            scintilla.StyleClearAll();

            // Set the XML Lexer
            scintilla.Lexer = Lexer.Xml;

            // Show line numbers
            scintilla.Margins[0].Width = 20;

            // Enable folding
            scintilla.SetProperty("fold", "1");
            scintilla.SetProperty("fold.compact", "1");
            scintilla.SetProperty("fold.html", "1");

            // Use Margin 2 for fold markers
            scintilla.Margins[2].Type = MarginType.Symbol;
            scintilla.Margins[2].Mask = Marker.MaskFolders;
            scintilla.Margins[2].Sensitive = true;
            scintilla.Margins[2].Width = 20;

            // Reset folder markers
            for (int i = Marker.FolderEnd; i <= Marker.FolderOpen; i++)
            {
                scintilla.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Style the folder markers
            scintilla.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla.Markers[Marker.Folder].SetBackColor(SystemColors.ControlText);
            scintilla.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla.Markers[Marker.FolderEnd].SetBackColor(SystemColors.ControlText);
            scintilla.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;

            // Set the Styles
            scintilla.StyleResetDefault();
            // I like fixed font for XML
            scintilla.Styles[Style.Default].Font = "Courier";
            scintilla.Styles[Style.Default].Size = 10;
            scintilla.StyleClearAll();
            scintilla.Styles[Style.Xml.Attribute].ForeColor = Color.Red;
            scintilla.Styles[Style.Xml.Entity].ForeColor = Color.Red;
            scintilla.Styles[Style.Xml.Comment].ForeColor = Color.Green;
            scintilla.Styles[Style.Xml.Tag].ForeColor = Color.Blue;
            scintilla.Styles[Style.Xml.TagEnd].ForeColor = Color.Blue;
            scintilla.Styles[Style.Xml.DoubleString].ForeColor = Color.DeepPink;
            scintilla.Styles[Style.Xml.SingleString].ForeColor = Color.DeepPink;
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
