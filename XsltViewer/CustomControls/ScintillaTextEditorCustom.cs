using ScintillaNET_FindReplaceDialog;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XsltViewer
{
	public class ScintillaTextEditorCustom : ScintillaNET.Scintilla
	{
		private BackgroundWorker bwXmlFormat;
		private ToolStripButton undoButton, redoButton, cutButton, copyButton, pasteButton, loadButton, saveButton, findButton, xmlFormatButton;
		private OpenFileDialog openFileDialog1;
		private SaveFileDialog saveFileDialog1;
		private FindReplace findDialog;
		public delegate void SetStatusEventHandler(string controlName, string positionString);
		public event SetStatusEventHandler SetStatus;
		public delegate DialogResult ShowMessageEventHandler(string text, string title = "Error", MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK, MessageBoxIcon messageBoxIcon = MessageBoxIcon.Information);
		public event ShowMessageEventHandler ShowMessage;
		public delegate void EnableControlEventHandler(bool enabled);
		public event EnableControlEventHandler EnableControls;

		public ScintillaTextEditorCustom()
		{
			findDialog = new FindReplace();
			bwXmlFormat = new BackgroundWorker();
			findDialog.Scintilla = this;

			bwXmlFormat.DoWork += BwXmlFormat_DoWork;
			bwXmlFormat.RunWorkerCompleted += BwXmlFormat_RunWorkerCompleted;
			Styles[0].Font = "Consolas";
			Styles[0].Size = 10;
			Styles[0].ForeColor = Color.FromArgb(0, 0, 0);
		}

		[Browsable(true)]
		[Description("Filters used in dialog")]
		[Category("Custom")]
		public string Filters { get; set; }

		[Browsable(true)]
		[Description("Default extension in dialog")]
		[Category("Custom")]
		public string DefaultExt { get; set; }

		[Browsable(true)]
		[Description("Reference to 'load' button")]
		[Category("Custom")]
		public ToolStripButton LoadButton
		{
			get
			{
				return loadButton;
			}
			set
			{
				loadButton = value;
				if (loadButton != null)
				{
					openFileDialog1 = new OpenFileDialog();
					openFileDialog1.Filter = Filters;
					openFileDialog1.DefaultExt = DefaultExt;
					loadButton.Click += LoadButtonEvent;
				}
			}
		}

		[Browsable(true)]
		[Description("Reference to 'save' button")]
		[Category("Custom")]
		public ToolStripButton SaveButton
		{
			get
			{
				return saveButton;
			}
			set
			{
				saveButton = value;
				if (saveButton != null)
				{
					saveFileDialog1 = new SaveFileDialog();
					saveFileDialog1.Filter = Filters;
					saveFileDialog1.DefaultExt = DefaultExt;
					saveButton.Click += SaveButtonEvent;
				}
			}
		}

		[Browsable(true)]
		[Description("Reference to 'cut' button")]
		[Category("Custom")]
		public ToolStripButton CutButton
		{
			get
			{
				return cutButton;
			}
			set
			{
				cutButton = value;
				if (cutButton != null)
				{
					cutButton.Click += CutButtonEvent;
				}
			}
		}

		[Browsable(true)]
		[Description("Reference to 'copy' button")]
		[Category("Custom")]
		public ToolStripButton CopyButton
		{
			get
			{
				return copyButton;
			}
			set
			{
				copyButton = value;
				if (copyButton != null)
				{
					copyButton.Click += CopyButtonEvent;
				}
			}
		}

		[Browsable(true)]
		[Description("Reference to 'paste' button")]
		[Category("Custom")]
		public ToolStripButton PasteButton
		{
			get
			{
				return pasteButton;
			}
			set
			{
				pasteButton = value;
				if (pasteButton != null)
				{
					pasteButton.Click += PasteButtonEvent;
				}
			}
		}

		[Browsable(true)]
		[Description("Reference to 'undo' button")]
		[Category("Custom")]
		public ToolStripButton UndoButton
		{
			get
			{
				return undoButton;
			}
			set
			{
				undoButton = value;
				if (undoButton != null)
				{
					undoButton.Click += UndoEvent;
				}
			}
		}

		[Browsable(true)]
		[Description("Reference to 'redo' button")]
		[Category("Custom")]
		public ToolStripButton RedoButton
		{
			get
			{
				return redoButton;
			}
			set
			{
				redoButton = value;
				if (redoButton != null)
				{
					redoButton.Click += RedoEvent;
				}
			}
		}

		[Browsable(true)]
		[Description("Reference to 'find' button")]
		[Category("Custom")]
		public ToolStripButton FindButton
		{
			get
			{
				return findButton;
			}
			set
			{
				findButton = value;
				if (findButton != null)
				{
					findButton.Click += FindButton_Event;
				}
			}
		}

		[Browsable(true)]
		[Description("Reference to 'xml format' button")]
		[Category("Custom")]
		public ToolStripButton XmlFormatButton
		{
			get
			{
				return xmlFormatButton;
			}
			set
			{
				xmlFormatButton = value;
				if (xmlFormatButton != null)
				{
					xmlFormatButton.Click += XmlFormatButton_Event;
				}
			}
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			SetStatusInfo();

			if (e.Control && e.KeyCode == Keys.F)
			{
				findDialog.ShowIncrementalSearch();
				e.SuppressKeyPress = true;
			}
		}

		protected override void OnKeyUp(KeyEventArgs e)
		{
			base.OnKeyUp(e);
			SetStatusInfo();
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			SetStatusInfo();
		}

		private void SetStatusInfo()
		{
			int columnNumber = GetColumn(CurrentPosition);
			string nameTextBox = AccessibleDescription;
			string rowNumberString = $"Row: {CurrentLine + 1} Column: {columnNumber + 1}";
			SetStatus?.Invoke(nameTextBox, rowNumberString);
			RefreshUndoRedoButton();
		}

		public void RefreshUndoRedoButton()
		{
			if (RedoButton != null)
			{
				RedoButton.Enabled = CanRedo;
			}

			if (UndoButton != null)
			{
				UndoButton.Enabled = CanUndo;
			}
		}

		protected override void OnDragOver(DragEventArgs e)
		{
			base.OnDragOver(e);
			e.Effect = (e.Data.GetDataPresent(DataFormats.FileDrop)) ? DragDropEffects.Link : DragDropEffects.None;
		}

		protected override async void OnDragDrop(DragEventArgs e)
		{
			base.OnDragDrop(e);
			if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Any())
			{
				EnableControls?.Invoke(false);
				try
				{
					using (var stream = new FileStream(files[0], FileMode.Open, FileAccess.Read, FileShare.Read))
					{
						using (var sr = new StreamReader(stream, Encoding.UTF8, true))
						{
							Text = await sr.ReadToEndAsync();
						}
					}
				}
				catch
				{
					Text = "Error reading file";
				}

				RefreshUndoRedoButton();
				EnableControls?.Invoke(true);
			}
		}

		private async void LoadButtonEvent(object sender, EventArgs e)
		{
			if (openFileDialog1?.ShowDialog() == DialogResult.OK)
			{
				var fileInfo = new FileInfo(openFileDialog1.FileName);
				bool loadFile = true;
				if (fileInfo.Length > 1e7)
				{
					var reply = ShowMessage?.Invoke(
						"File is bigger than 10MB and this tool can have problem to show it. Are you sure?",
						"Request",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Exclamation);

					loadFile = reply == null || reply == DialogResult.OK;
				}

				if (loadFile)
				{
					try
					{
						EnableControls?.Invoke(false);
						using (var stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
						{
							using (var sr = new StreamReader(stream, Encoding.UTF8, true))
							{
								Text = await sr.ReadToEndAsync();
							}
						}

					}
					catch (Exception ex)
					{
						ShowMessage?.Invoke(ex.Message);
					}
					finally
					{
						RefreshUndoRedoButton();
						EnableControls?.Invoke(true);
					}
				}
			}
		}

		private async void SaveButtonEvent(object sender, EventArgs e)
		{
			if (saveFileDialog1?.ShowDialog() == DialogResult.OK)
			{
				try
				{
					EnableControls?.Invoke(false);
					var buffer = Encoding.Default.GetBytes(Text);
					using (var fs = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None, buffer.Length, true))
					{
						await fs.WriteAsync(buffer, 0, buffer.Length);
					}
				}
				catch (Exception ex)
				{
					ShowMessage?.Invoke(ex.Message);
				}
				finally
				{
					EnableControls?.Invoke(true);
				}
			}
		}

		private void CutButtonEvent(object sender, EventArgs e)
		{
			try
			{
				if (Text.Length > 0)
				{
					Clipboard.SetText(Text);
					Text = string.Empty;
				}
			}
			catch (Exception ex)
			{
				ShowMessage?.Invoke(ex.Message);
			}
			finally
			{
				RefreshUndoRedoButton();
			}
		}

		private void CopyButtonEvent(object sender, EventArgs e)
		{
			try
			{
				if (Text.Length > 0)
				{
					Clipboard.SetText(Text);
				}
			}
			catch (Exception ex)
			{
				ShowMessage?.Invoke(ex.Message);
			}
		}

		private void PasteButtonEvent(object sender, EventArgs e)
		{
			try
			{
				Text = Clipboard.GetText();
			}
			catch (Exception ex)
			{
				ShowMessage?.Invoke(ex.Message);
			}
			finally
			{
				RefreshUndoRedoButton();
			}
		}

		private void UndoEvent(object sender, EventArgs e)
		{
			Undo();
			RefreshUndoRedoButton();
		}

		private void RedoEvent(object sender, EventArgs e)
		{
			Redo();
			RefreshUndoRedoButton();
		}

		private void FindButton_Event(object sender, EventArgs e)
		{
			findDialog.ShowIncrementalSearch();
		}

		private void XmlFormatButton_Event(object sender, EventArgs e)
		{
			EnableControls?.Invoke(false);
			bwXmlFormat.RunWorkerAsync(Text);
		}

		private void ClearAllSelections(ToolStrip toolStrip)
		{
			// Call private method using reflection
			MethodInfo method = typeof(ToolStrip).GetMethod("ClearAllSelections", BindingFlags.NonPublic | BindingFlags.Instance);
			method?.Invoke(toolStrip, null);
		}

		private void BwXmlFormat_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				ShowMessage?.Invoke(e.Error.Message);
			}
			else
			{
				Text = e.Result?.ToString();
				RefreshUndoRedoButton();
			}

			ClearAllSelections(XmlFormatButton.GetCurrentParent());
			EnableControls?.Invoke(true);
		}

		private void BwXmlFormat_DoWork(object sender, DoWorkEventArgs e)
		{
			e.Result = XDocument.Parse(e.Argument.ToString()).ToString();
		}
	}
}
