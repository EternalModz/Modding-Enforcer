using Dark.Net;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MSSCMP_Studio
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);
        private const int ATTACH_PARENT_PROCESS = -1;

        [STAThread]
        static void Main(string[] args)
        {
            AttachConsole(ATTACH_PARENT_PROCESS);

            int argCount = args == null ? 0 : args.Length;
            Console.WriteLine("nYou specified {0} arguments:", argCount);
            for (int i = 0; i < argCount; i++)
            {
                Console.WriteLine("  {0}", args[i]);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DarkNet.Instance.SetCurrentProcessTheme(Theme.Auto);

            if (args.Length != 0 && args[0] == "-dev")
            {
                Form mainForm = new Forms.MainForm(1);
                DarkNet.Instance.SetWindowThemeForms(mainForm, Theme.Auto);
                Application.Run(mainForm);
            }
            else
            {
                Form mainForm = new Forms.MainForm(0);
                DarkNet.Instance.SetWindowThemeForms(mainForm, Theme.Auto);
                Application.Run(mainForm);
            }
        }
    }
}