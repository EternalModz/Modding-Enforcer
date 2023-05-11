using System;
using System.IO;
using System.Windows.Forms;
using Dark.Net;
using FUI_Enforcer.Forms;

namespace FUI_Enforcer
{
    internal static class Program
    {

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DarkNet.Instance.SetCurrentProcessTheme(Theme.Auto);

            Form mainForm = new MainForm();
            DarkNet.Instance.SetWindowThemeForms(mainForm, Theme.Auto);

            Application.Run(mainForm);
        }

    }
}
