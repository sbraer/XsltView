namespace XsltViewer
{
    partial class XPathForm
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
            this.TxtXPath = new XsltViewer.ScintillaTextEditorCustom();
            this.BtnXPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtXPath
            // 
            this.TxtXPath.CopyButton = null;
            this.TxtXPath.CutButton = null;
            this.TxtXPath.DefaultExt = null;
            this.TxtXPath.Filters = null;
            this.TxtXPath.FindButton = null;
            this.TxtXPath.LoadButton = null;
            this.TxtXPath.Location = new System.Drawing.Point(13, 13);
            this.TxtXPath.Name = "TxtXPath";
            this.TxtXPath.PasteButton = null;
            this.TxtXPath.ReadOnly = true;
            this.TxtXPath.RedoButton = null;
            this.TxtXPath.SaveButton = null;
            this.TxtXPath.Size = new System.Drawing.Size(777, 171);
            this.TxtXPath.TabIndex = 0;
            this.TxtXPath.UndoButton = null;
            this.TxtXPath.WrapMode = ScintillaNET.WrapMode.Whitespace;
            this.TxtXPath.XmlFormatButton = null;
            this.TxtXPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XPathForm_KeyDown);
            // 
            // BtnXPath
            // 
            this.BtnXPath.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnXPath.Location = new System.Drawing.Point(662, 190);
            this.BtnXPath.Name = "BtnXPath";
            this.BtnXPath.Size = new System.Drawing.Size(128, 23);
            this.BtnXPath.TabIndex = 2;
            this.BtnXPath.Text = "Copy and Close";
            this.BtnXPath.UseVisualStyleBackColor = true;
            this.BtnXPath.Click += new System.EventHandler(this.BtnXPath_Click);
            // 
            // XPathForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 222);
            this.Controls.Add(this.BtnXPath);
            this.Controls.Add(this.TxtXPath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "XPathForm";
            this.Text = "XPath";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.XPathForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaTextEditorCustom TxtXPath;
        private System.Windows.Forms.Button BtnXPath;
    }
}