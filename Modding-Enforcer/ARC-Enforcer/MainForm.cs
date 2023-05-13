using System;
using System.Windows.Forms;

namespace ARC_Enforcer.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            this.InitializeComponent();
        }

        private void PS3Archive_Load(object sender, EventArgs e)
        {
        }

        private void btnUnPack_Click(object sender, EventArgs e)
        {

        }

        private void btnPack_Click(object sender, EventArgs e)
        {

        }

        private bool method_0()
        {
            return this.textBox_0.Text.Length > 0 && this.textBox_1.Text.Length > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool @checked = this.checkBox1.Checked;
            if (@checked)
            {
                this.textBox_1.Enabled = false;
                this.BrowseARCFolder_Btn.Enabled = false;
                this.label2.Enabled = false;
            }
            else
            {
                this.textBox_1.Enabled = true;
                this.BrowseARCFolder_Btn.Enabled = true;
                this.label2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UnPack_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = this.method_0();
                if (flag)
                {
                    PS3ARCWorker ps3ARCWorker = new PS3ARCWorker();
                    bool @checked = this.checkBox1.Checked;
                    if (@checked)
                    {
                        ps3ARCWorker.ExtractArchive(this.textBox_0.Text, FileUtils.CheckFolderSep(this.textBox_1.Text));
                    }
                    else
                    {
                        ps3ARCWorker.ExtractArchive(this.textBox_0.Text, FileUtils.CheckFolderSep(this.textBox_0.Text.Replace(".arc", "/")));
                    }
                    MessageBox.Show("Process Completed", "Completed!");
                }
                else
                {
                    MessageBox.Show("Check Data", "Data Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "There was an error!");
            }
        }

        private void Pack_Btn_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = this.method_0();
                if (flag)
                {
                    PS3ARCWorker ps3ARCWorker = new PS3ARCWorker();
                    bool @checked = this.checkBox1.Checked;
                    if (@checked)
                    {
                        ps3ARCWorker.BuildArchive(this.textBox_0.Text, FileUtils.CheckFolderSep(this.textBox_1.Text));
                    }
                    else
                    {
                        ps3ARCWorker.BuildArchive(this.textBox_0.Text, FileUtils.CheckFolderSep(this.textBox_0.Text.Replace(".arc", "/")));
                    }
                    MessageBox.Show("Process Completed", "Completed");
                }
                else
                {
                    MessageBox.Show("Check Data", "Data Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error", "There was an error!");
            }
        }

        private void BrowseARCFile_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = " Archive Files | *.arc";
            bool flag = opf.ShowDialog() == DialogResult.OK;
            if (flag)
            {
                this.textBox_0.Text = opf.FileName;
            }
        }

        private void BrowseARCFolder_Btn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog opf = new FolderBrowserDialog();
            bool flag = opf.ShowDialog() == DialogResult.OK;
            if (flag)
            {
                this.textBox_1.Text = opf.SelectedPath;
            }
        }
    }
}