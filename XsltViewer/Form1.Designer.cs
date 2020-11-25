using System.Windows.Forms;

namespace XsltViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.SplitContainer1 = new System.Windows.Forms.SplitContainer();
			this.TableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.TxtXml = new XsltViewer.ScintillaTextEditorCustom();
			this.CopyXmlButton = new System.Windows.Forms.ToolStripButton();
			this.CutXmlButton = new System.Windows.Forms.ToolStripButton();
			this.XmlFindButton = new System.Windows.Forms.ToolStripButton();
			this.OpenXmlButton = new System.Windows.Forms.ToolStripButton();
			this.PasteXmlButton = new System.Windows.Forms.ToolStripButton();
			this.XmlRedoButton = new System.Windows.Forms.ToolStripButton();
			this.SaveXmlButton = new System.Windows.Forms.ToolStripButton();
			this.XmlUndoButton = new System.Windows.Forms.ToolStripButton();
			this.XmlFormatXmlButton = new System.Windows.Forms.ToolStripButton();
			this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
			this.ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.XmlMiniButton = new System.Windows.Forms.ToolStripButton();
			this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSearchXPath = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
			this.xmlImportJson = new System.Windows.Forms.ToolStripButton();
			this.TableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.TxtXslt = new XsltViewer.ScintillaTextEditorCustom();
			this.CopyXsltButton = new System.Windows.Forms.ToolStripButton();
			this.CutXsltButton = new System.Windows.Forms.ToolStripButton();
			this.ToolStripXsltFind = new System.Windows.Forms.ToolStripButton();
			this.OpenToolStripButtonXslt = new System.Windows.Forms.ToolStripButton();
			this.PasteXsltButton = new System.Windows.Forms.ToolStripButton();
			this.ToolStripXsltRedo = new System.Windows.Forms.ToolStripButton();
			this.SaveToolStripButtonXslt = new System.Windows.Forms.ToolStripButton();
			this.ToolStripXsltUndo = new System.Windows.Forms.ToolStripButton();
			this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
			this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.SplitContainer2 = new System.Windows.Forms.SplitContainer();
			this.TableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.TxtOutput = new XsltViewer.ScintillaTextEditorCustom();
			this.CopyOutputButton = new System.Windows.Forms.ToolStripButton();
			this.CutOutputButton = new System.Windows.Forms.ToolStripButton();
			this.ToolStripOutputFind = new System.Windows.Forms.ToolStripButton();
			this.OpenToolStripButtonOutput = new System.Windows.Forms.ToolStripButton();
			this.PasteOutputButton = new System.Windows.Forms.ToolStripButton();
			this.ToolStripOutputRedo = new System.Windows.Forms.ToolStripButton();
			this.SaveToolStripButtonOutput = new System.Windows.Forms.ToolStripButton();
			this.ToolStripOutputUndo = new System.Windows.Forms.ToolStripButton();
			this.ToolStripXmlFormatOutput = new System.Windows.Forms.ToolStripButton();
			this.ToolStrip3 = new System.Windows.Forms.ToolStrip();
			this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.ToolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnWrapUnwrap = new System.Windows.Forms.ToolStripButton();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.BtnTransform = new System.Windows.Forms.Button();
			this.BtnXpath = new System.Windows.Forms.Button();
			this.TxtXPath = new System.Windows.Forms.TextBox();
			this.BtPasteXPath = new System.Windows.Forms.Button();
			this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.BwMiniXml = new System.ComponentModel.BackgroundWorker();
			this.BwXPath = new System.ComponentModel.BackgroundWorker();
			this.BwTransform = new System.ComponentModel.BackgroundWorker();
			this.BwSearchXPath = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).BeginInit();
			this.SplitContainer1.Panel1.SuspendLayout();
			this.SplitContainer1.Panel2.SuspendLayout();
			this.SplitContainer1.SuspendLayout();
			this.TableLayoutPanel2.SuspendLayout();
			this.ToolStrip1.SuspendLayout();
			this.TableLayoutPanel3.SuspendLayout();
			this.ToolStrip2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).BeginInit();
			this.SplitContainer2.Panel1.SuspendLayout();
			this.SplitContainer2.Panel2.SuspendLayout();
			this.SplitContainer2.SuspendLayout();
			this.TableLayoutPanel4.SuspendLayout();
			this.ToolStrip3.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.TableLayoutPanel5.SuspendLayout();
			this.StatusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SplitContainer1
			// 
			this.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer1.Location = new System.Drawing.Point(0, 0);
			this.SplitContainer1.Name = "SplitContainer1";
			// 
			// SplitContainer1.Panel1
			// 
			this.SplitContainer1.Panel1.Controls.Add(this.TableLayoutPanel2);
			this.SplitContainer1.Panel1MinSize = 50;
			// 
			// SplitContainer1.Panel2
			// 
			this.SplitContainer1.Panel2.Controls.Add(this.TableLayoutPanel3);
			this.SplitContainer1.Panel2MinSize = 50;
			this.SplitContainer1.Size = new System.Drawing.Size(962, 312);
			this.SplitContainer1.SplitterDistance = 464;
			this.SplitContainer1.TabIndex = 20;
			this.SplitContainer1.TabStop = false;
			// 
			// TableLayoutPanel2
			// 
			this.TableLayoutPanel2.ColumnCount = 1;
			this.TableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel2.Controls.Add(this.TxtXml, 0, 1);
			this.TableLayoutPanel2.Controls.Add(this.ToolStrip1, 0, 0);
			this.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanel2.Name = "TableLayoutPanel2";
			this.TableLayoutPanel2.RowCount = 2;
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel2.Size = new System.Drawing.Size(464, 312);
			this.TableLayoutPanel2.TabIndex = 5;
			// 
			// TxtXml
			// 
			this.TxtXml.AccessibleDescription = "XML Editor";
			this.TxtXml.AllowDrop = true;
			this.TxtXml.CopyButton = this.CopyXmlButton;
			this.TxtXml.CutButton = this.CutXmlButton;
			this.TxtXml.DefaultExt = "xml";
			this.TxtXml.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtXml.Filters = "XML file|*.xml|All files|*.*";
			this.TxtXml.FindButton = this.XmlFindButton;
			this.TxtXml.Lexer = ScintillaNET.Lexer.Xml;
			this.TxtXml.LoadButton = this.OpenXmlButton;
			this.TxtXml.Location = new System.Drawing.Point(3, 28);
			this.TxtXml.Name = "TxtXml";
			this.TxtXml.PasteButton = this.PasteXmlButton;
			this.TxtXml.RedoButton = this.XmlRedoButton;
			this.TxtXml.SaveButton = this.SaveXmlButton;
			this.TxtXml.Size = new System.Drawing.Size(458, 281);
			this.TxtXml.TabIndex = 4;
			this.TxtXml.TabStop = false;
			this.TxtXml.Tag = "blockable";
			this.TxtXml.Text = resources.GetString("TxtXml.Text");
			this.TxtXml.UndoButton = this.XmlUndoButton;
			this.TxtXml.UseTabs = true;
			this.TxtXml.WrapMode = ScintillaNET.WrapMode.Whitespace;
			this.TxtXml.XmlFormatButton = this.XmlFormatXmlButton;
			this.TxtXml.SetStatus += new XsltViewer.ScintillaTextEditorCustom.SetStatusEventHandler(this.SetStatusInfo);
			this.TxtXml.ShowMessage += new XsltViewer.ScintillaTextEditorCustom.ShowMessageEventHandler(this.ShowMessageBox);
			this.TxtXml.EnableControls += new XsltViewer.ScintillaTextEditorCustom.EnableControlEventHandler(this.EnableControls);
			// 
			// CopyXmlButton
			// 
			this.CopyXmlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CopyXmlButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyXmlButton.Image")));
			this.CopyXmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CopyXmlButton.Name = "CopyXmlButton";
			this.CopyXmlButton.Size = new System.Drawing.Size(23, 22);
			this.CopyXmlButton.Tag = "";
			this.CopyXmlButton.Text = "&Copy";
			this.CopyXmlButton.ToolTipText = "Copy all text";
			// 
			// CutXmlButton
			// 
			this.CutXmlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CutXmlButton.Image = ((System.Drawing.Image)(resources.GetObject("CutXmlButton.Image")));
			this.CutXmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CutXmlButton.Name = "CutXmlButton";
			this.CutXmlButton.Size = new System.Drawing.Size(23, 22);
			this.CutXmlButton.Tag = "";
			this.CutXmlButton.Text = "C&ut";
			this.CutXmlButton.ToolTipText = "Cut all text";
			// 
			// XmlFindButton
			// 
			this.XmlFindButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.XmlFindButton.Image = ((System.Drawing.Image)(resources.GetObject("XmlFindButton.Image")));
			this.XmlFindButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.XmlFindButton.Name = "XmlFindButton";
			this.XmlFindButton.Size = new System.Drawing.Size(23, 22);
			// 
			// OpenXmlButton
			// 
			this.OpenXmlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OpenXmlButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenXmlButton.Image")));
			this.OpenXmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenXmlButton.Name = "OpenXmlButton";
			this.OpenXmlButton.Size = new System.Drawing.Size(23, 22);
			this.OpenXmlButton.Tag = "";
			this.OpenXmlButton.Text = "&Open";
			// 
			// PasteXmlButton
			// 
			this.PasteXmlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PasteXmlButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteXmlButton.Image")));
			this.PasteXmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PasteXmlButton.Name = "PasteXmlButton";
			this.PasteXmlButton.Size = new System.Drawing.Size(23, 22);
			this.PasteXmlButton.Tag = "";
			this.PasteXmlButton.Text = "&Paste";
			// 
			// XmlRedoButton
			// 
			this.XmlRedoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.XmlRedoButton.Enabled = false;
			this.XmlRedoButton.Image = global::XsltViewer.Resource1.forward_arrow;
			this.XmlRedoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.XmlRedoButton.Name = "XmlRedoButton";
			this.XmlRedoButton.Size = new System.Drawing.Size(23, 22);
			this.XmlRedoButton.Tag = "";
			this.XmlRedoButton.Text = "R";
			this.XmlRedoButton.ToolTipText = "Redo";
			// 
			// SaveXmlButton
			// 
			this.SaveXmlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SaveXmlButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveXmlButton.Image")));
			this.SaveXmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveXmlButton.Name = "SaveXmlButton";
			this.SaveXmlButton.Size = new System.Drawing.Size(23, 22);
			this.SaveXmlButton.Tag = "";
			this.SaveXmlButton.Text = "&Save";
			// 
			// XmlUndoButton
			// 
			this.XmlUndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.XmlUndoButton.Enabled = false;
			this.XmlUndoButton.Image = global::XsltViewer.Resource1.undo;
			this.XmlUndoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.XmlUndoButton.Name = "XmlUndoButton";
			this.XmlUndoButton.Size = new System.Drawing.Size(23, 22);
			this.XmlUndoButton.Tag = "";
			this.XmlUndoButton.Text = "U";
			this.XmlUndoButton.ToolTipText = "Undo";
			// 
			// XmlFormatXmlButton
			// 
			this.XmlFormatXmlButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.XmlFormatXmlButton.Image = ((System.Drawing.Image)(resources.GetObject("XmlFormatXmlButton.Image")));
			this.XmlFormatXmlButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.XmlFormatXmlButton.Name = "XmlFormatXmlButton";
			this.XmlFormatXmlButton.Size = new System.Drawing.Size(49, 22);
			this.XmlFormatXmlButton.Tag = "";
			this.XmlFormatXmlButton.Text = "Format";
			// 
			// ToolStrip1
			// 
			this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenXmlButton,
            this.SaveXmlButton,
            this.ToolStripSeparator,
            this.CutXmlButton,
            this.CopyXmlButton,
            this.PasteXmlButton,
            this.ToolStripSeparator3,
            this.XmlUndoButton,
            this.XmlRedoButton,
            this.ToolStripSeparator10,
            this.XmlFindButton,
            this.ToolStripSeparator6,
            this.XmlFormatXmlButton,
            this.ToolStripSeparator7,
            this.XmlMiniButton,
            this.ToolStripSeparator9,
            this.ToolStripSearchXPath,
            this.toolStripSeparator14,
            this.xmlImportJson});
			this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip1.Name = "ToolStrip1";
			this.ToolStrip1.Size = new System.Drawing.Size(464, 25);
			this.ToolStrip1.TabIndex = 5;
			this.ToolStrip1.Tag = "blockable";
			this.ToolStrip1.Text = "toolStrip1";
			// 
			// ToolStripSeparator
			// 
			this.ToolStripSeparator.Name = "ToolStripSeparator";
			this.ToolStripSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSeparator3
			// 
			this.ToolStripSeparator3.Name = "ToolStripSeparator3";
			this.ToolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSeparator10
			// 
			this.ToolStripSeparator10.Name = "ToolStripSeparator10";
			this.ToolStripSeparator10.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSeparator6
			// 
			this.ToolStripSeparator6.Name = "ToolStripSeparator6";
			this.ToolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSeparator7
			// 
			this.ToolStripSeparator7.Name = "ToolStripSeparator7";
			this.ToolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// XmlMiniButton
			// 
			this.XmlMiniButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.XmlMiniButton.Image = ((System.Drawing.Image)(resources.GetObject("XmlMiniButton.Image")));
			this.XmlMiniButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.XmlMiniButton.Name = "XmlMiniButton";
			this.XmlMiniButton.Size = new System.Drawing.Size(35, 22);
			this.XmlMiniButton.Tag = "";
			this.XmlMiniButton.Text = "Mini";
			this.XmlMiniButton.Click += new System.EventHandler(this.ToolStripMinificationButton_Click);
			// 
			// ToolStripSeparator9
			// 
			this.ToolStripSeparator9.Name = "ToolStripSeparator9";
			this.ToolStripSeparator9.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSearchXPath
			// 
			this.ToolStripSearchXPath.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolStripSearchXPath.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripSearchXPath.Image")));
			this.ToolStripSearchXPath.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripSearchXPath.Name = "ToolStripSearchXPath";
			this.ToolStripSearchXPath.Size = new System.Drawing.Size(42, 22);
			this.ToolStripSearchXPath.Text = "XPath";
			this.ToolStripSearchXPath.Click += new System.EventHandler(this.ToolStripSearchXPath_Click);
			// 
			// toolStripSeparator14
			// 
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
			// 
			// xmlImportJson
			// 
			this.xmlImportJson.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.xmlImportJson.Image = ((System.Drawing.Image)(resources.GetObject("xmlImportJson.Image")));
			this.xmlImportJson.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.xmlImportJson.Name = "xmlImportJson";
			this.xmlImportJson.Size = new System.Drawing.Size(78, 22);
			this.xmlImportJson.Text = "Import JSON";
			this.xmlImportJson.Click += new System.EventHandler(this.xmlImportJson_Click);
			// 
			// TableLayoutPanel3
			// 
			this.TableLayoutPanel3.ColumnCount = 1;
			this.TableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel3.Controls.Add(this.TxtXslt, 0, 1);
			this.TableLayoutPanel3.Controls.Add(this.ToolStrip2, 0, 0);
			this.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanel3.Name = "TableLayoutPanel3";
			this.TableLayoutPanel3.RowCount = 2;
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel3.Size = new System.Drawing.Size(494, 312);
			this.TableLayoutPanel3.TabIndex = 6;
			// 
			// TxtXslt
			// 
			this.TxtXslt.AccessibleDescription = "XSLT Editor";
			this.TxtXslt.AllowDrop = true;
			this.TxtXslt.CopyButton = this.CopyXsltButton;
			this.TxtXslt.CutButton = this.CutXsltButton;
			this.TxtXslt.DefaultExt = "xsl";
			this.TxtXslt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtXslt.Filters = "XSLT file|*.xsl*|All files|*.*";
			this.TxtXslt.FindButton = this.ToolStripXsltFind;
			this.TxtXslt.Lexer = ScintillaNET.Lexer.Xml;
			this.TxtXslt.LoadButton = this.OpenToolStripButtonXslt;
			this.TxtXslt.Location = new System.Drawing.Point(3, 28);
			this.TxtXslt.Name = "TxtXslt";
			this.TxtXslt.PasteButton = this.PasteXsltButton;
			this.TxtXslt.RedoButton = this.ToolStripXsltRedo;
			this.TxtXslt.SaveButton = this.SaveToolStripButtonXslt;
			this.TxtXslt.Size = new System.Drawing.Size(488, 281);
			this.TxtXslt.TabIndex = 5;
			this.TxtXslt.TabStop = false;
			this.TxtXslt.Tag = "blockable";
			this.TxtXslt.Text = resources.GetString("TxtXslt.Text");
			this.TxtXslt.UndoButton = this.ToolStripXsltUndo;
			this.TxtXslt.UseTabs = true;
			this.TxtXslt.WrapMode = ScintillaNET.WrapMode.Whitespace;
			this.TxtXslt.XmlFormatButton = null;
			this.TxtXslt.SetStatus += new XsltViewer.ScintillaTextEditorCustom.SetStatusEventHandler(this.SetStatusInfo);
			this.TxtXslt.ShowMessage += new XsltViewer.ScintillaTextEditorCustom.ShowMessageEventHandler(this.ShowMessageBox);
			this.TxtXslt.EnableControls += new XsltViewer.ScintillaTextEditorCustom.EnableControlEventHandler(this.EnableControls);
			// 
			// CopyXsltButton
			// 
			this.CopyXsltButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CopyXsltButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyXsltButton.Image")));
			this.CopyXsltButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CopyXsltButton.Name = "CopyXsltButton";
			this.CopyXsltButton.Size = new System.Drawing.Size(23, 22);
			this.CopyXsltButton.Tag = "";
			this.CopyXsltButton.Text = "&Copy";
			this.CopyXsltButton.ToolTipText = "Copy all text";
			// 
			// CutXsltButton
			// 
			this.CutXsltButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CutXsltButton.Image = ((System.Drawing.Image)(resources.GetObject("CutXsltButton.Image")));
			this.CutXsltButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CutXsltButton.Name = "CutXsltButton";
			this.CutXsltButton.Size = new System.Drawing.Size(23, 22);
			this.CutXsltButton.Tag = "";
			this.CutXsltButton.Text = "C&ut";
			this.CutXsltButton.ToolTipText = "Cut all text";
			// 
			// ToolStripXsltFind
			// 
			this.ToolStripXsltFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripXsltFind.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripXsltFind.Image")));
			this.ToolStripXsltFind.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripXsltFind.Name = "ToolStripXsltFind";
			this.ToolStripXsltFind.Size = new System.Drawing.Size(23, 22);
			// 
			// OpenToolStripButtonXslt
			// 
			this.OpenToolStripButtonXslt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OpenToolStripButtonXslt.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButtonXslt.Image")));
			this.OpenToolStripButtonXslt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenToolStripButtonXslt.Name = "OpenToolStripButtonXslt";
			this.OpenToolStripButtonXslt.Size = new System.Drawing.Size(23, 22);
			this.OpenToolStripButtonXslt.Tag = "";
			this.OpenToolStripButtonXslt.Text = "&Open";
			// 
			// PasteXsltButton
			// 
			this.PasteXsltButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PasteXsltButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteXsltButton.Image")));
			this.PasteXsltButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PasteXsltButton.Name = "PasteXsltButton";
			this.PasteXsltButton.Size = new System.Drawing.Size(23, 22);
			this.PasteXsltButton.Tag = "";
			this.PasteXsltButton.Text = "&Paste";
			// 
			// ToolStripXsltRedo
			// 
			this.ToolStripXsltRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripXsltRedo.Enabled = false;
			this.ToolStripXsltRedo.Image = global::XsltViewer.Resource1.forward_arrow;
			this.ToolStripXsltRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripXsltRedo.Name = "ToolStripXsltRedo";
			this.ToolStripXsltRedo.Size = new System.Drawing.Size(23, 22);
			this.ToolStripXsltRedo.Tag = "";
			this.ToolStripXsltRedo.Text = "R";
			this.ToolStripXsltRedo.ToolTipText = "Redo";
			// 
			// SaveToolStripButtonXslt
			// 
			this.SaveToolStripButtonXslt.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SaveToolStripButtonXslt.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButtonXslt.Image")));
			this.SaveToolStripButtonXslt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveToolStripButtonXslt.Name = "SaveToolStripButtonXslt";
			this.SaveToolStripButtonXslt.Size = new System.Drawing.Size(23, 22);
			this.SaveToolStripButtonXslt.Tag = "";
			this.SaveToolStripButtonXslt.Text = "&Save";
			// 
			// ToolStripXsltUndo
			// 
			this.ToolStripXsltUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripXsltUndo.Enabled = false;
			this.ToolStripXsltUndo.Image = global::XsltViewer.Resource1.undo;
			this.ToolStripXsltUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripXsltUndo.Name = "ToolStripXsltUndo";
			this.ToolStripXsltUndo.Size = new System.Drawing.Size(23, 22);
			this.ToolStripXsltUndo.Tag = "";
			this.ToolStripXsltUndo.Text = "U";
			this.ToolStripXsltUndo.ToolTipText = "Undo";
			// 
			// ToolStrip2
			// 
			this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButtonXslt,
            this.SaveToolStripButtonXslt,
            this.ToolStripSeparator1,
            this.CutXsltButton,
            this.CopyXsltButton,
            this.PasteXsltButton,
            this.ToolStripSeparator4,
            this.ToolStripXsltUndo,
            this.ToolStripXsltRedo,
            this.ToolStripSeparator11,
            this.ToolStripXsltFind});
			this.ToolStrip2.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip2.Name = "ToolStrip2";
			this.ToolStrip2.Size = new System.Drawing.Size(494, 25);
			this.ToolStrip2.TabIndex = 6;
			this.ToolStrip2.Tag = "blockable";
			this.ToolStrip2.Text = "toolStrip2";
			// 
			// ToolStripSeparator1
			// 
			this.ToolStripSeparator1.Name = "ToolStripSeparator1";
			this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSeparator4
			// 
			this.ToolStripSeparator4.Name = "ToolStripSeparator4";
			this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSeparator11
			// 
			this.ToolStripSeparator11.Name = "ToolStripSeparator11";
			this.ToolStripSeparator11.Size = new System.Drawing.Size(6, 25);
			// 
			// SplitContainer2
			// 
			this.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SplitContainer2.Location = new System.Drawing.Point(3, 3);
			this.SplitContainer2.Name = "SplitContainer2";
			this.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// SplitContainer2.Panel1
			// 
			this.SplitContainer2.Panel1.Controls.Add(this.SplitContainer1);
			this.SplitContainer2.Panel1MinSize = 50;
			// 
			// SplitContainer2.Panel2
			// 
			this.SplitContainer2.Panel2.Controls.Add(this.TableLayoutPanel4);
			this.SplitContainer2.Panel2MinSize = 50;
			this.SplitContainer2.Size = new System.Drawing.Size(962, 567);
			this.SplitContainer2.SplitterDistance = 312;
			this.SplitContainer2.TabIndex = 30;
			this.SplitContainer2.TabStop = false;
			// 
			// TableLayoutPanel4
			// 
			this.TableLayoutPanel4.ColumnCount = 1;
			this.TableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel4.Controls.Add(this.TxtOutput, 0, 1);
			this.TableLayoutPanel4.Controls.Add(this.ToolStrip3, 0, 0);
			this.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanel4.Name = "TableLayoutPanel4";
			this.TableLayoutPanel4.RowCount = 2;
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel4.Size = new System.Drawing.Size(962, 251);
			this.TableLayoutPanel4.TabIndex = 8;
			// 
			// TxtOutput
			// 
			this.TxtOutput.AccessibleDescription = "Output Editor";
			this.TxtOutput.AllowDrop = true;
			this.TxtOutput.CopyButton = this.CopyOutputButton;
			this.TxtOutput.CutButton = this.CutOutputButton;
			this.TxtOutput.DefaultExt = "csv";
			this.TxtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtOutput.Filters = "CSV file|*.csv|Text file|*.txt|All files|*.*";
			this.TxtOutput.FindButton = this.ToolStripOutputFind;
			this.TxtOutput.Lexer = ScintillaNET.Lexer.Xml;
			this.TxtOutput.LoadButton = this.OpenToolStripButtonOutput;
			this.TxtOutput.Location = new System.Drawing.Point(3, 28);
			this.TxtOutput.Name = "TxtOutput";
			this.TxtOutput.PasteButton = this.PasteOutputButton;
			this.TxtOutput.RedoButton = this.ToolStripOutputRedo;
			this.TxtOutput.SaveButton = this.SaveToolStripButtonOutput;
			this.TxtOutput.Size = new System.Drawing.Size(956, 220);
			this.TxtOutput.TabIndex = 7;
			this.TxtOutput.TabStop = false;
			this.TxtOutput.Tag = "blockable";
			this.TxtOutput.UndoButton = this.ToolStripOutputUndo;
			this.TxtOutput.UseTabs = true;
			this.TxtOutput.WrapMode = ScintillaNET.WrapMode.Whitespace;
			this.TxtOutput.XmlFormatButton = this.ToolStripXmlFormatOutput;
			this.TxtOutput.SetStatus += new XsltViewer.ScintillaTextEditorCustom.SetStatusEventHandler(this.SetStatusInfo);
			this.TxtOutput.ShowMessage += new XsltViewer.ScintillaTextEditorCustom.ShowMessageEventHandler(this.ShowMessageBox);
			this.TxtOutput.EnableControls += new XsltViewer.ScintillaTextEditorCustom.EnableControlEventHandler(this.EnableControls);
			// 
			// CopyOutputButton
			// 
			this.CopyOutputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CopyOutputButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyOutputButton.Image")));
			this.CopyOutputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CopyOutputButton.Name = "CopyOutputButton";
			this.CopyOutputButton.Size = new System.Drawing.Size(23, 22);
			this.CopyOutputButton.Tag = "";
			this.CopyOutputButton.Text = "&Copy";
			this.CopyOutputButton.ToolTipText = "Copy all text";
			// 
			// CutOutputButton
			// 
			this.CutOutputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.CutOutputButton.Image = ((System.Drawing.Image)(resources.GetObject("CutOutputButton.Image")));
			this.CutOutputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CutOutputButton.Name = "CutOutputButton";
			this.CutOutputButton.Size = new System.Drawing.Size(23, 22);
			this.CutOutputButton.Tag = "";
			this.CutOutputButton.Text = "C&ut";
			this.CutOutputButton.ToolTipText = "Cut all text";
			// 
			// ToolStripOutputFind
			// 
			this.ToolStripOutputFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripOutputFind.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripOutputFind.Image")));
			this.ToolStripOutputFind.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripOutputFind.Name = "ToolStripOutputFind";
			this.ToolStripOutputFind.Size = new System.Drawing.Size(23, 22);
			// 
			// OpenToolStripButtonOutput
			// 
			this.OpenToolStripButtonOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.OpenToolStripButtonOutput.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripButtonOutput.Image")));
			this.OpenToolStripButtonOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.OpenToolStripButtonOutput.Name = "OpenToolStripButtonOutput";
			this.OpenToolStripButtonOutput.Size = new System.Drawing.Size(23, 22);
			this.OpenToolStripButtonOutput.Tag = "";
			this.OpenToolStripButtonOutput.Text = "&Open";
			// 
			// PasteOutputButton
			// 
			this.PasteOutputButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PasteOutputButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteOutputButton.Image")));
			this.PasteOutputButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.PasteOutputButton.Name = "PasteOutputButton";
			this.PasteOutputButton.Size = new System.Drawing.Size(23, 22);
			this.PasteOutputButton.Tag = "";
			this.PasteOutputButton.Text = "&Paste";
			// 
			// ToolStripOutputRedo
			// 
			this.ToolStripOutputRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripOutputRedo.Enabled = false;
			this.ToolStripOutputRedo.Image = global::XsltViewer.Resource1.forward_arrow;
			this.ToolStripOutputRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripOutputRedo.Name = "ToolStripOutputRedo";
			this.ToolStripOutputRedo.Size = new System.Drawing.Size(23, 22);
			this.ToolStripOutputRedo.Tag = "";
			this.ToolStripOutputRedo.Text = "R";
			this.ToolStripOutputRedo.ToolTipText = "Redo";
			// 
			// SaveToolStripButtonOutput
			// 
			this.SaveToolStripButtonOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.SaveToolStripButtonOutput.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripButtonOutput.Image")));
			this.SaveToolStripButtonOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveToolStripButtonOutput.Name = "SaveToolStripButtonOutput";
			this.SaveToolStripButtonOutput.Size = new System.Drawing.Size(23, 22);
			this.SaveToolStripButtonOutput.Tag = "";
			this.SaveToolStripButtonOutput.Text = "&Save";
			// 
			// ToolStripOutputUndo
			// 
			this.ToolStripOutputUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.ToolStripOutputUndo.Enabled = false;
			this.ToolStripOutputUndo.Image = global::XsltViewer.Resource1.undo;
			this.ToolStripOutputUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripOutputUndo.Name = "ToolStripOutputUndo";
			this.ToolStripOutputUndo.Size = new System.Drawing.Size(23, 22);
			this.ToolStripOutputUndo.Tag = "";
			this.ToolStripOutputUndo.Text = "U";
			this.ToolStripOutputUndo.ToolTipText = "Undo";
			// 
			// ToolStripXmlFormatOutput
			// 
			this.ToolStripXmlFormatOutput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ToolStripXmlFormatOutput.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripXmlFormatOutput.Image")));
			this.ToolStripXmlFormatOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ToolStripXmlFormatOutput.Name = "ToolStripXmlFormatOutput";
			this.ToolStripXmlFormatOutput.Size = new System.Drawing.Size(49, 22);
			this.ToolStripXmlFormatOutput.Text = "Format";
			// 
			// ToolStrip3
			// 
			this.ToolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripButtonOutput,
            this.SaveToolStripButtonOutput,
            this.ToolStripSeparator2,
            this.CutOutputButton,
            this.CopyOutputButton,
            this.PasteOutputButton,
            this.ToolStripSeparator5,
            this.ToolStripOutputUndo,
            this.ToolStripOutputRedo,
            this.ToolStripSeparator12,
            this.ToolStripOutputFind,
            this.ToolStripSeparator8,
            this.ToolStripXmlFormatOutput,
            this.ToolStripSeparator13,
            this.BtnWrapUnwrap});
			this.ToolStrip3.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip3.Name = "ToolStrip3";
			this.ToolStrip3.Size = new System.Drawing.Size(962, 25);
			this.ToolStrip3.TabIndex = 8;
			this.ToolStrip3.Tag = "blockable";
			this.ToolStrip3.Text = "toolStrip3";
			// 
			// ToolStripSeparator2
			// 
			this.ToolStripSeparator2.Name = "ToolStripSeparator2";
			this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSeparator5
			// 
			this.ToolStripSeparator5.Name = "ToolStripSeparator5";
			this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSeparator12
			// 
			this.ToolStripSeparator12.Name = "ToolStripSeparator12";
			this.ToolStripSeparator12.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSeparator8
			// 
			this.ToolStripSeparator8.Name = "ToolStripSeparator8";
			this.ToolStripSeparator8.Size = new System.Drawing.Size(6, 25);
			// 
			// ToolStripSeparator13
			// 
			this.ToolStripSeparator13.Name = "ToolStripSeparator13";
			this.ToolStripSeparator13.Size = new System.Drawing.Size(6, 25);
			// 
			// BtnWrapUnwrap
			// 
			this.BtnWrapUnwrap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.BtnWrapUnwrap.Image = ((System.Drawing.Image)(resources.GetObject("BtnWrapUnwrap.Image")));
			this.BtnWrapUnwrap.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnWrapUnwrap.Name = "BtnWrapUnwrap";
			this.BtnWrapUnwrap.Size = new System.Drawing.Size(39, 22);
			this.BtnWrapUnwrap.Tag = "blockable";
			this.BtnWrapUnwrap.Text = "Wrap";
			this.BtnWrapUnwrap.Click += new System.EventHandler(this.BtnWrapUnwrap_Click);
			// 
			// TableLayoutPanel1
			// 
			this.TableLayoutPanel1.ColumnCount = 1;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel1.Controls.Add(this.TableLayoutPanel5, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.SplitContainer2, 0, 0);
			this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 17);
			this.TableLayoutPanel1.RowCount = 2;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(968, 625);
			this.TableLayoutPanel1.TabIndex = 4;
			// 
			// TableLayoutPanel5
			// 
			this.TableLayoutPanel5.ColumnCount = 4;
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.TableLayoutPanel5.Controls.Add(this.BtnTransform, 3, 0);
			this.TableLayoutPanel5.Controls.Add(this.BtnXpath, 2, 0);
			this.TableLayoutPanel5.Controls.Add(this.TxtXPath, 0, 0);
			this.TableLayoutPanel5.Controls.Add(this.BtPasteXPath, 1, 0);
			this.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TableLayoutPanel5.Location = new System.Drawing.Point(3, 576);
			this.TableLayoutPanel5.Name = "TableLayoutPanel5";
			this.TableLayoutPanel5.RowCount = 1;
			this.TableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.TableLayoutPanel5.Size = new System.Drawing.Size(962, 29);
			this.TableLayoutPanel5.TabIndex = 31;
			// 
			// BtnTransform
			// 
			this.BtnTransform.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnTransform.Location = new System.Drawing.Point(823, 3);
			this.BtnTransform.Name = "BtnTransform";
			this.BtnTransform.Size = new System.Drawing.Size(136, 23);
			this.BtnTransform.TabIndex = 6;
			this.BtnTransform.Tag = "blockable";
			this.BtnTransform.Text = "Transform XSLT";
			this.BtnTransform.UseVisualStyleBackColor = true;
			this.BtnTransform.Click += new System.EventHandler(this.BtnTransform_Click);
			// 
			// BtnXpath
			// 
			this.BtnXpath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnXpath.Location = new System.Drawing.Point(682, 3);
			this.BtnXpath.Name = "BtnXpath";
			this.BtnXpath.Size = new System.Drawing.Size(135, 23);
			this.BtnXpath.TabIndex = 5;
			this.BtnXpath.Tag = "blockable";
			this.BtnXpath.Text = "XPath";
			this.BtnXpath.UseVisualStyleBackColor = true;
			this.BtnXpath.Click += new System.EventHandler(this.BtnXpath_Click);
			// 
			// TxtXPath
			// 
			this.TxtXPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TxtXPath.Location = new System.Drawing.Point(3, 3);
			this.TxtXPath.Name = "TxtXPath";
			this.TxtXPath.Size = new System.Drawing.Size(653, 20);
			this.TxtXPath.TabIndex = 3;
			this.TxtXPath.Tag = "blockable";
			this.TxtXPath.Text = "//ELEMENT[substring(./DATA,0,11)=\'2004-12-31\']";
			this.TxtXPath.DoubleClick += new System.EventHandler(this.TxtXPath_DoubleClick);
			// 
			// BtPasteXPath
			// 
			this.BtPasteXPath.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtPasteXPath.FlatAppearance.BorderSize = 0;
			this.BtPasteXPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtPasteXPath.Image = ((System.Drawing.Image)(resources.GetObject("BtPasteXPath.Image")));
			this.BtPasteXPath.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.BtPasteXPath.Location = new System.Drawing.Point(662, 3);
			this.BtPasteXPath.Name = "BtPasteXPath";
			this.BtPasteXPath.Size = new System.Drawing.Size(14, 23);
			this.BtPasteXPath.TabIndex = 4;
			this.BtPasteXPath.Tag = "blockable";
			this.BtPasteXPath.UseVisualStyleBackColor = true;
			this.BtPasteXPath.Click += new System.EventHandler(this.BtPasteXPath_Click);
			// 
			// StatusStrip1
			// 
			this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.ToolStripStatusLabel2});
			this.StatusStrip1.Location = new System.Drawing.Point(0, 603);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new System.Drawing.Size(968, 22);
			this.StatusStrip1.TabIndex = 5;
			this.StatusStrip1.Text = "statusStrip1";
			// 
			// ToolStripStatusLabel1
			// 
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
			this.ToolStripStatusLabel1.Text = "toolStripStatusLabel1";
			// 
			// ToolStripStatusLabel2
			// 
			this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
			this.ToolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
			this.ToolStripStatusLabel2.Text = "toolStripStatusLabel2";
			// 
			// BwMiniXml
			// 
			this.BwMiniXml.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwMiniXml_DoWork);
			this.BwMiniXml.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwMiniXml_RunWorkerCompleted);
			// 
			// BwXPath
			// 
			this.BwXPath.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwXPath_DoWork);
			this.BwXPath.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwXPath_RunWorkerCompleted);
			// 
			// BwTransform
			// 
			this.BwTransform.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwTransform_DoWork);
			this.BwTransform.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwTransform_RunWorkerCompleted);
			// 
			// BwSearchXPath
			// 
			this.BwSearchXPath.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwSearchXPath_DoWork);
			this.BwSearchXPath.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BwSearchXPath_RunWorkerCompleted);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(968, 625);
			this.Controls.Add(this.StatusStrip1);
			this.Controls.Add(this.TableLayoutPanel1);
			this.DoubleBuffered = true;
			this.MinimumSize = new System.Drawing.Size(300, 250);
			this.Name = "Form1";
			this.Text = "Xslt View";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.SplitContainer1.Panel1.ResumeLayout(false);
			this.SplitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer1)).EndInit();
			this.SplitContainer1.ResumeLayout(false);
			this.TableLayoutPanel2.ResumeLayout(false);
			this.TableLayoutPanel2.PerformLayout();
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.TableLayoutPanel3.ResumeLayout(false);
			this.TableLayoutPanel3.PerformLayout();
			this.ToolStrip2.ResumeLayout(false);
			this.ToolStrip2.PerformLayout();
			this.SplitContainer2.Panel1.ResumeLayout(false);
			this.SplitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SplitContainer2)).EndInit();
			this.SplitContainer2.ResumeLayout(false);
			this.TableLayoutPanel4.ResumeLayout(false);
			this.TableLayoutPanel4.PerformLayout();
			this.ToolStrip3.ResumeLayout(false);
			this.ToolStrip3.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel5.ResumeLayout(false);
			this.TableLayoutPanel5.PerformLayout();
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer SplitContainer1;
        private ScintillaTextEditorCustom TxtXml;
        private ScintillaTextEditorCustom TxtXslt;
        private System.Windows.Forms.SplitContainer SplitContainer2;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel2;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel3;
        private System.Windows.Forms.ToolStrip ToolStrip2;
        private ToolStripButton OpenToolStripButtonXslt;
        private ToolStripButton SaveToolStripButtonXslt;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel4;
        private ScintillaTextEditorCustom TxtOutput;
        private System.Windows.Forms.ToolStrip ToolStrip3;
        private ToolStripButton OpenToolStripButtonOutput;
        private ToolStripButton SaveToolStripButtonOutput;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private ToolStripButton CutOutputButton;
        private ToolStripButton CopyOutputButton;
        private ToolStripButton PasteOutputButton;
        private ToolStripButton CutXmlButton;
        private ToolStripButton CopyXmlButton;
        private ToolStripButton PasteXmlButton;
        private ToolStripButton CutXsltButton;
        private ToolStripButton CopyXsltButton;
        private ToolStripButton PasteXsltButton;
        private ToolStripButton ToolStripOutputUndo;
        private ToolStripButton XmlUndoButton;
        private ToolStripButton ToolStripXsltUndo;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        private ToolStripButton XmlRedoButton;
        private ToolStripButton ToolStripXsltRedo;
        private ToolStripButton ToolStripOutputRedo;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator6;
        private ToolStripButton XmlFormatXmlButton;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator7;
        private ToolStripButton XmlMiniButton;
        private ToolStripButton OpenXmlButton;
        private ToolStripButton SaveXmlButton;
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel5;
        private System.Windows.Forms.Button BtnTransform;
        private System.Windows.Forms.Button BtnXpath;
        private TextBox TxtXPath;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator8;
        private System.Windows.Forms.ToolStripButton BtnWrapUnwrap;
        private ToolStripSeparator ToolStripSeparator9;
        private ToolStripButton ToolStripSearchXPath;
        private ToolStripSeparator ToolStripSeparator10;
        private ToolStripButton XmlFindButton;
        private ToolStripSeparator ToolStripSeparator11;
        private ToolStripButton ToolStripXsltFind;
        private ToolStripSeparator ToolStripSeparator12;
        private ToolStripButton ToolStripOutputFind;
        private ToolStripButton ToolStripXmlFormatOutput;
        private ToolStripSeparator ToolStripSeparator13;
        private System.ComponentModel.BackgroundWorker BwMiniXml;
        private System.ComponentModel.BackgroundWorker BwXPath;
        private System.ComponentModel.BackgroundWorker BwTransform;
        private System.ComponentModel.BackgroundWorker BwSearchXPath;
        private Button BtPasteXPath;
		private ToolStripSeparator toolStripSeparator14;
		private ToolStripButton xmlImportJson;
	}
}

