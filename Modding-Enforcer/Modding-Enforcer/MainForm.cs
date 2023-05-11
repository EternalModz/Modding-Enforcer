using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modding_Enforcer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CheckForUpdateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to the URL
            Process.Start("https://github.com/EternalModz/Modding-Enforcer/Releases");
        }

        private void ViewSourceCodeBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Navigate to the URL
            Process.Start("https://github.com/EternalModz/Modding-Enforcer");
        }

        private void ARCEnforcerBtn_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Application.StartupPath, "Resources", "ARC-Enforcer", "ARC-Enforcer.exe");
            Process.Start(exePath);
        }

        private void FUIEnforcerBtn_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Application.StartupPath, "Resources", "FUI-Enforcer", "FUI-Enforcer.exe");
            Process.Start(exePath);
        }

        private void MSSCMPStudioBtn_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Application.StartupPath, "Resources", "MSSCMP-Studio", "MSSCMP-Studio.exe");
            Process.Start(exePath);
        }

        private void SFOEnforcerBtn_Click(object sender, EventArgs e)
        {
            string exePath = Path.Combine(Application.StartupPath, "Resources", "SFO-Enforcer", "SFO-Enforcer.exe");
            Process.Start(exePath);
        }
    }
}
