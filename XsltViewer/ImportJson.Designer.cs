
namespace XsltViewer
{
	partial class ImportJson
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
			this.btConvert = new System.Windows.Forms.Button();
			this.txtXml = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btExit = new System.Windows.Forms.Button();
			this.btImport = new System.Windows.Forms.Button();
			this.ConvertJsonWorker = new System.ComponentModel.BackgroundWorker();
			this.txtJson = new XsltViewer.ScintillaTextEditorCustom();
			this.SuspendLayout();
			// 
			// btConvert
			// 
			this.btConvert.Location = new System.Drawing.Point(382, 245);
			this.btConvert.Name = "btConvert";
			this.btConvert.Size = new System.Drawing.Size(75, 23);
			this.btConvert.TabIndex = 1;
			this.btConvert.Text = "Convert ->";
			this.btConvert.UseVisualStyleBackColor = true;
			this.btConvert.Click += new System.EventHandler(this.btConvert_Click);
			// 
			// txtXml
			// 
			this.txtXml.Location = new System.Drawing.Point(463, 29);
			this.txtXml.Multiline = true;
			this.txtXml.Name = "txtXml";
			this.txtXml.Size = new System.Drawing.Size(364, 487);
			this.txtXml.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "JSON";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(463, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "XML";
			// 
			// btExit
			// 
			this.btExit.Location = new System.Drawing.Point(752, 522);
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size(75, 23);
			this.btExit.TabIndex = 4;
			this.btExit.Text = "Exit";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler(this.btExit_Click);
			// 
			// btImport
			// 
			this.btImport.Location = new System.Drawing.Point(671, 521);
			this.btImport.Name = "btImport";
			this.btImport.Size = new System.Drawing.Size(75, 23);
			this.btImport.TabIndex = 3;
			this.btImport.Text = "Import";
			this.btImport.UseVisualStyleBackColor = true;
			this.btImport.Click += new System.EventHandler(this.btImport_Click);
			// 
			// ConvertJsonWorker
			// 
			this.ConvertJsonWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ConvertJsonWorker_DoWork);
			this.ConvertJsonWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ConvertJsonWorker_RunWorkerCompleted);
			// 
			// txtJson
			// 
			this.txtJson.CopyButton = null;
			this.txtJson.CutButton = null;
			this.txtJson.DefaultExt = null;
			this.txtJson.Filters = null;
			this.txtJson.FindButton = null;
			this.txtJson.Lexer = ScintillaNET.Lexer.Json;
			this.txtJson.LoadButton = null;
			this.txtJson.Location = new System.Drawing.Point(13, 30);
			this.txtJson.Name = "txtJson";
			this.txtJson.PasteButton = null;
			this.txtJson.RedoButton = null;
			this.txtJson.SaveButton = null;
			this.txtJson.Size = new System.Drawing.Size(363, 486);
			this.txtJson.TabIndex = 5;
			this.txtJson.Text = "scintillaTextEditorCustom1";
			this.txtJson.UndoButton = null;
			this.txtJson.UseTabs = true;
			this.txtJson.WrapMode = ScintillaNET.WrapMode.Whitespace;
			this.txtJson.XmlFormatButton = null;
			// 
			// ImportJson
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 553);
			this.Controls.Add(this.txtJson);
			this.Controls.Add(this.btImport);
			this.Controls.Add(this.btExit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtXml);
			this.Controls.Add(this.btConvert);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ImportJson";
			this.Text = "Import Json";
			this.Load += new System.EventHandler(this.ImportJson_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btConvert;
		private System.Windows.Forms.TextBox txtXml;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btExit;
		private System.Windows.Forms.Button btImport;
		private System.ComponentModel.BackgroundWorker ConvertJsonWorker;
		private ScintillaTextEditorCustom txtJson;
	}
}