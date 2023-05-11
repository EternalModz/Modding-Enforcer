using Dark.Net;
using PARAM.SFO_Enforcer;
using System;
using System.Windows.Forms;

namespace SFO_Enforcer
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
            Form mainForm = new MainForm();
            DarkNet.Instance.SetWindowThemeForms(mainForm, Theme.Auto);
            Application.Run(mainForm);
        }
    }
}