using Newtonsoft.Json;
using ScintillaNET;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XsltViewer
{
	public partial class ImportJson : Form
	{
		public string XmlImported { get; private set; }
		public ImportJson()
		{
			InitializeComponent();
			FixScintillaStyles(txtJson);
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

		private void btImport_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void EnableControl(bool enable)
		{
			btConvert.Enabled = enable;
			btExit.Enabled = enable;
			btImport.Enabled = XmlImported != null;
			txtJson.Enabled = enable;
			txtXml.Enabled = enable;
		}

		private void ImportJson_Load(object sender, EventArgs e)
		{
			XmlImported = null;
			txtJson.Text = string.Empty;
			txtXml.Text = string.Empty;
			btImport.Enabled = false;
		}

		private void btConvert_Click(object sender, EventArgs e)
		{
			if (txtJson.Text.Length > 0)
			{
				txtXml.Text = string.Empty;
				EnableControl(false);
				ConvertJsonWorker.RunWorkerAsync(txtJson.Text);
			}
		}

		private void ConvertJsonWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			XNode node;

			try
			{
				node = JsonConvert.DeserializeXNode(e.Argument.ToString());
				e.Result = node.ToString();
			}
			catch
			{}

			node = JsonConvert.DeserializeXNode(e.Argument.ToString(), "root");
			e.Result = node.ToString();
		}

		private void ConvertJsonWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				XmlImported = null;
				MessageBox.Show(e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				XmlImported = e.Result.ToString();
				txtXml.Text = XmlImported;
			}

			EnableControl(true);
		}

		private void FixScintillaStyles(ScintillaTextEditorCustom scintilla)
		{
			// Reset the styles
			scintilla.StyleResetDefault();
			scintilla.Styles[Style.Default].Font = "Consolas";
			scintilla.Styles[Style.Default].Size = 10;
			scintilla.StyleClearAll();

			// Show line numbers
			scintilla.Margins[0].Width = 30;
		}
	}
}
