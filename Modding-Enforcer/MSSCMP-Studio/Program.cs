using Dark.Net;
using MSSCMP_Studio.Forms;
using System;
using System.Windows.Forms;

namespace MSSCMP_Studio
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize DarkNet library
            DarkNet.Instance.SetCurrentProcessTheme(Theme.Auto);

            // Run the main form of the application
            Form mainForm = new MainForm(0); // pass 0 as the debug parameter
            DarkNet.Instance.SetWindowThemeForms(mainForm, Theme.Auto);
            Application.Run(mainForm);
        }
    }
}