using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using XsltUtilities;

namespace XsltViewer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var xpathDialog = new XPathForm();
            var importJson = new ImportJson();
            var form1 = new Form1(xpathDialog, importJson, new XsltTransformation());
            Application.Run(form1);
        }
    }
}
