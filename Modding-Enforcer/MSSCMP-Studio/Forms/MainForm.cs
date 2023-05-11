using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MSSCMP_Studio
{
    public partial class MainForm : Form
    {
        public MainForm(int debug)
        {
            InitializeComponent();

            #region if debugging :: developer build label shown

            if (debug == 0)
            {
                DEVELOPERLABEL.Visible = false;
            }
            else
            {
                DEVELOPERLABEL.Visible = true;
                developer = true;
            }

            #endregion
        }

        #region variables

        public string arcfile = "";
        public string appdata = Environment.CurrentDirectory + "\\tmp\\";
        public string LocalFolder = Environment.CurrentDirectory;
        public static string url = "http://localhost";
        string version = "1.1";
        public bool developer = false;

        string saveLocation;//Save location for pck file
        int fileCount = 0;//variable for number of minefiles
        bool needsUpdate = false;
        bool saved = true;
        FolderBrowserDialog fbd = new FolderBrowserDialog();

        [DllImport("msscmp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int extractMsscmp(string path);
        [DllImport("msscmp.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        internal static extern int saveMsscmp(string path);

        #endregion

        #region ARC Saving and opening

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                richTextBox1.Visible = false;
                using (var ofd = new OpenFileDialog())
                {
                    ofd.CheckFileExists = true; //makes sure opened fui exists
                    ofd.Filter = "MSSCMP (Miles Sound System Archive)|*.msscmp| BINKA (Bink Audio) | *.bink;*.binka| WAV (WaveForm Audio) | *.wav";

                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        //openPck(ofd.FileName);
                        EntryList.Nodes.Clear();
                        try
                        {
                            if (ofd.FileName.EndsWith(".bink") || ofd.FileName.EndsWith(".binka"))
                            {
                                if (MessageBox.Show("Bink Audio type detected!\nConvert audio?", "Conversion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {

                                    File.WriteAllText(LocalFolder + "\\BinkMan\\files.txt", ofd.FileName);
                                    System.Diagnostics.Process prc1 = new System.Diagnostics.Process();
                                    prc1.StartInfo.FileName = (LocalFolder + "\\BinkMan\\BinkMan.exe");
                                    prc1.Start();
                                    prc1.WaitForExit();
                                }
                            }
                            else if (ofd.FileName.EndsWith(".wav"))
                            {
                                if (MessageBox.Show("Waveform Audio type detected!\nConvert audio?", "Conversion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    File.WriteAllText(LocalFolder + "\\BinkMan\\files.txt", ofd.FileName);
                                    System.Diagnostics.Process prc1 = new System.Diagnostics.Process();
                                    prc1.StartInfo.FileName = (LocalFolder + "\\BinkMan\\BinkMan.exe");
                                    prc1.Start();
                                    prc1.WaitForExit();
                                }
                            }
                            else if (ofd.FileName.EndsWith(".msscmp"))
                            {
                                Classes.Variables.openFilePath = ofd.FileName;
                                Classes.Variables.selectedFilePath = ofd.FileName;
                                extractMsscmp(Classes.Variables.openFilePath);
                                DateTime present = DateTime.Now;
                                DateTime addFiveSeconds = DateTime.Now.AddSeconds(5);

                                while (DateTime.Now.TimeOfDay.TotalSeconds <= addFiveSeconds.TimeOfDay.TotalSeconds)
                                {

                                }
                                openPck();

                            }
                            else
                            {
                                MessageBox.Show("Check Data", "Data Error");
                            }
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("error\n" + err.ToString());
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The ARC you're trying to use currently isn't supported");//Error handling for PCKs that give errors when trying to be opened
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            try
            {

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "MSSCMP|*.msscmp";
                sfd.FileName = ("Minecraft.msscmp");
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Classes.Variables.selectedFilePath = sfd.FileName;
                    saveMsscmp(Classes.Variables.selectedFilePath);
                }

                MessageBox.Show("Saved", "Success");
            }
            catch (Exception err)
            {
                MessageBox.Show("error\n" + err.ToString());
            }
        }


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Classes.Variables.selectedFilePath))
                    saveMsscmp(Classes.Variables.selectedFilePath);
                else
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "MSSCMP|*.msscmp";
                    sfd.FileName = ("Minecraft.msscmp");
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        Classes.Variables.selectedFilePath = sfd.FileName;
                        saveMsscmp(Classes.Variables.selectedFilePath);
                    }
                }
                MessageBox.Show("Saved", "Success");
            }
            catch (Exception err)
            {
                MessageBox.Show("error\n" + err.ToString());
            }
        }

        #endregion

        #region 'Help' Menu

        private void programInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MSSCMP_Studio.Forms.AboutForm pi = new Forms.AboutForm();
            pi.ShowDialog();
        }

        // send bug report

        private void reportABugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.StackTrace t = new System.Diagnostics.StackTrace();
            //MessageBox.Show("Please be aware that this will contain the stack trace at the bottom, simply type your bug description above that");
            System.Diagnostics.Process.Start("mailto:felix.millerarc@gmail.com?subject=ARC%20Studio%20Bug%20report&body=description:%0A%0A%0A%0A%0A%0A%0A%0A%0A%0ASTACK%20TRACE:" + t.ToString().Replace(" ", "%20").Replace("\n", "%0A").Replace("\r\n", "%0A"));
        }

        #endregion

        #region Loading form

        private void Form1_Load(object sender, EventArgs e)
        {
            this.GetType().Assembly.GetManifestResourceNames();
            foreach (string name in this.GetType().Assembly.GetManifestResourceNames())
                Console.WriteLine(name);
            if (developer)
            {
                Console.Clear();
            }

            VersionLabel.Text = "Version: " + version;

            try
            {
                new System.Net.WebClient().DownloadString(url);
                System.IO.File.WriteAllText(LocalFolder + "\\url.txt", url);
                System.IO.File.WriteAllText(LocalFolder + "\\MSSCMP_Changelog.txt", url + "/studio/BINK/api/MSSCMP_Changelog.txt");
                richTextBox1.Text = new System.Net.WebClient().DownloadString(url + "/studio/BINK/api/MSSCMP_Changelog.txt");
            }
            catch
            {
                System.IO.File.WriteAllText(LocalFolder + "\\URL.txt", "http://phoenixarc.github.io/pckstudio.tk");
                url = "http://phoenixarc.github.io/pckstudio.tk";
            }
            try
            {
                if (new System.Net.WebClient().DownloadString(url + "/studio/BINK/api/MSSCMP_Center_update.txt") != version)
                {

                    if (MessageBox.Show("Update Avaliable\nDownload?", "Alert!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        System.Diagnostics.Process.Start(LocalFolder + "\\MSSCMPUpdater.exe");
                    }
                }
                else
                {

                }
            }
            catch
            {
                MessageBox.Show("Servers Offline!\nOnline services have been disabled!");
            }
        }

        #endregion

        #region delete files when program closes

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(appdata);

                foreach (FileInfo file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                File.Delete(LocalFolder + "\\mss.log");
                Directory.Delete(LocalFolder + "\\tmp");
                if (developer)
                    File.WriteAllText(LocalFolder + "\\Consolelog.txt", Console.Out.ToString());
            }
            catch { }
        }
        #endregion

        #region Load MSSCMP / BINK


        private void openPck()
        {

            ImageList icons = new ImageList();
            icons.ColorDepth = ColorDepth.Depth32Bit;
            icons.ImageSize = new Size(20, 20);

            icons.Images.Add(MSSCMP_Studio.Properties.Resources.ZZFolder);
            icons.Images.Add(MSSCMP_Studio.Properties.Resources.BINKA_ICON);
            icons.Images.Add(MSSCMP_Studio.Properties.Resources.ZUnknown);

            EntryList.ImageList = icons; //sets file icon image list

            //Creates folder for each directory
            foreach (string mf in Directory.GetDirectories(appdata))
            {
                TreeNode file = new TreeNode();
                file.Tag = mf;
                //search dir in those folders
                foreach (string mf1 in Directory.GetDirectories(mf))
                {
                    TreeNode file1 = new TreeNode();
                    file.Tag = mf1;
                    string directoryFile1 = mf1;
                    var currentNode1 = file.Nodes;

                    file1.ImageIndex = 0;
                    file1.SelectedImageIndex = 0;
                    Console.WriteLine(mf1);

                    foreach (string mf2 in Directory.GetDirectories(mf1))
                    {
                        TreeNode file2 = new TreeNode();
                        file2.Tag = mf2;
                        string directoryFile2 = mf2;
                        var currentNode2 = file1.Nodes;

                        file2.ImageIndex = 0;
                        file2.SelectedImageIndex = 0;
                        Console.WriteLine("2 - " + mf2);
                        //search files in dir1
                        foreach (string mf3 in Directory.GetFiles(mf2))
                        {
                            Console.WriteLine("3 - " + mf3);
                            TreeNode file3 = new TreeNode();
                            file3.Tag = mf3;
                            string directoryFile3 = mf3;
                            var currentNode3 = file2.Nodes;


                            //Gives files correct icon
                            if (Path.GetExtension(directoryFile3) == ".binka")
                            {
                                file3.ImageIndex = 1;
                                file3.SelectedImageIndex = 1;
                            }
                            else
                            {
                                file3.ImageIndex = 9;
                                file3.SelectedImageIndex = 9;
                            }


                            file3.Text = directoryFile3.Replace(Path.GetDirectoryName(directoryFile3) + "\\", ""); //Sets file name
                            currentNode3.Add(file3); //adds final file after need subnodes are created
                            saved = false;

                            //Makes UI visible once a PCK is open
                            foreach (ToolStripMenuItem item in fileToolStripMenuItem.DropDownItems)
                            {
                                item.Enabled = true;
                            }

                            //Detects if LOC exists then presets for all functions that use the LOC
                            foreach (TreeNode item in EntryList.Nodes)
                            {
                            }
                            fileCount = 0;//Resets file count
                                          //Gets file count based of all existing minefiles
                            saved = false;
                        }

                        foreach (string mf3 in Directory.GetDirectories(mf2))
                        {
                            TreeNode file3 = new TreeNode();
                            file3.Tag = mf3;
                            string directoryFile3 = mf3;
                            var currentNode3 = file2.Nodes;

                            file3.ImageIndex = 0;
                            file3.SelectedImageIndex = 0;
                            Console.WriteLine("2 - " + mf2);


                            foreach (string mf4 in Directory.GetFiles(mf3))
                            {
                                Console.WriteLine("4 - " + mf4);
                                TreeNode file4 = new TreeNode();
                                file4.Tag = mf4;
                                string directoryFile4 = mf4;
                                var currentNode4 = file3.Nodes;


                                //Gives files correct icon
                                if (Path.GetExtension(directoryFile4) == ".binka")
                                {
                                    file4.ImageIndex = 1;
                                    file4.SelectedImageIndex = 1;
                                }
                                else
                                {
                                    file4.ImageIndex = 9;
                                    file4.SelectedImageIndex = 9;
                                }


                                file4.Text = directoryFile4.Replace(Path.GetDirectoryName(directoryFile4) + "\\", ""); //Sets file name
                                currentNode4.Add(file4); //adds final file after need subnodes are created
                                saved = false;

                                //Makes UI visible once a PCK is open
                                foreach (ToolStripMenuItem item in fileToolStripMenuItem.DropDownItems)
                                {
                                    item.Enabled = true;
                                }

                                //Detects if LOC exists then presets for all functions that use the LOC
                                foreach (TreeNode item in EntryList.Nodes)
                                {
                                }
                                fileCount = 0;//Resets file count
                                              //Gets file count based of all existing minefiles
                                saved = false;
                            }



                            file3.Text = directoryFile3.Replace(Path.GetDirectoryName(directoryFile3) + "\\", ""); //Sets file name
                            currentNode3.Add(file3); //adds final file after need subnodes are created
                        }


                        file2.Text = directoryFile2.Replace(Path.GetDirectoryName(directoryFile2) + "\\", ""); //Sets file name
                        currentNode2.Add(file2); //adds final file after need subnodes are created
                    }


                    //search files in dir1
                    foreach (string mf2 in Directory.GetFiles(mf1))
                    {
                        TreeNode file2 = new TreeNode();
                        file2.Tag = mf2;
                        string directoryFile2 = mf2;
                        var currentNode2 = file1.Nodes;


                        //Gives files correct icon
                        if (Path.GetExtension(directoryFile2) == ".binka")
                        {
                            file2.ImageIndex = 1;
                            file2.SelectedImageIndex = 1;
                        }
                        else
                        {
                            file2.ImageIndex = 9;
                            file2.SelectedImageIndex = 9;
                        }
                        file2.Text = Path.GetFileName(directoryFile2); //Sets file name
                        currentNode2.Add(file2); //adds final file after need subnodes are created
                        saved = false;

                        //Makes UI visible once a PCK is open
                        foreach (ToolStripMenuItem item in fileToolStripMenuItem.DropDownItems)
                        {
                            item.Enabled = true;
                        }

                        //Detects if LOC exists then presets for all functions that use the LOC
                        foreach (TreeNode item in EntryList.Nodes)
                        {
                        }
                        fileCount = 0;//Resets file count
                                      //Gets file count based of all existing minefiles
                        saved = false;
                    }





                    //MessageBox.Show(directoryFile1.Replace(Path.GetDirectoryName(directoryFile1) + "\\", ""));
                    file1.Text = directoryFile1.Replace(Path.GetDirectoryName(directoryFile1) + "\\", ""); //Sets file name
                    currentNode1.Add(file1); //adds final file after need subnodes are created
                    saved = false;
                }
                //search files in dir1
                foreach (string mf2 in Directory.GetFiles(mf))
                {
                    TreeNode file2 = new TreeNode();
                    file2.Tag = mf2;
                    string directoryFile2 = mf2;
                    var currentNode2 = file.Nodes;


                    //Gives files correct icon
                    if (Path.GetExtension(directoryFile2) == ".binka")
                    {
                        file2.ImageIndex = 1;
                        file2.SelectedImageIndex = 1;
                    }
                    else if (Path.GetExtension(directoryFile2) == ".png")
                    {
                        file2.ImageIndex = 2;
                        file2.SelectedImageIndex = 2;
                    }
                    else if (Path.GetExtension(directoryFile2) == ".loc")
                    {
                        file2.ImageIndex = 3;
                        file2.SelectedImageIndex = 3;
                    }
                    else if (Path.GetExtension(directoryFile2) == ".pck")
                    {
                        file2.ImageIndex = 4;
                        file2.SelectedImageIndex = 4;
                    }
                    else if (Path.GetExtension(directoryFile2) == ".fui")
                    {
                        file2.ImageIndex = 5;
                        file2.SelectedImageIndex = 5;
                    }
                    else if (Path.GetExtension(directoryFile2) == ".col")
                    {
                        file2.ImageIndex = 6;
                        file2.SelectedImageIndex = 6;
                    }
                    else if (Path.GetExtension(directoryFile2) == "")
                    {
                        file2.ImageIndex = 7;
                        file2.SelectedImageIndex = 7;
                    }
                    else if (Path.GetExtension(directoryFile2) == ".txt")
                    {
                        file2.ImageIndex = 8;
                        file2.SelectedImageIndex = 8;
                    }
                    else
                    {
                        file2.ImageIndex = 9;
                        file2.SelectedImageIndex = 9;
                    }
                    file2.Text = Path.GetFileName(directoryFile2); //Sets file name
                    currentNode2.Add(file2); //adds final file after need subnodes are created
                    saved = false;

                    //Makes UI visible once a PCK is open
                    foreach (ToolStripMenuItem item in fileToolStripMenuItem.DropDownItems)
                    {
                        item.Enabled = true;
                    }

                    //Detects if LOC exists then presets for all functions that use the LOC
                    foreach (TreeNode item in EntryList.Nodes)
                    {
                    }
                    fileCount = 0;//Resets file count
                                  //Gets file count based of all existing minefiles
                    saved = false;
                }


                string directoryFile = mf;
                var currentNode = EntryList.Nodes;

                file.ImageIndex = 0;
                file.SelectedImageIndex = 0;

                file.Text = directoryFile.Replace(Path.GetDirectoryName(directoryFile) + "\\", ""); //Sets file name
                currentNode.Add(file); //adds final file after need subnodes are created
                saved = false;
            }
            //Creates nodes for each minefile in the PCK
            foreach (string mf in Directory.GetFiles(appdata))
            {
                TreeNode file = new TreeNode();
                file.Tag = mf;
                string directoryFile = mf;
                var currentNode = EntryList.Nodes;


                //Gives files correct icon
                if (Path.GetExtension(directoryFile) == ".binka")
                {
                    file.ImageIndex = 1;
                    file.SelectedImageIndex = 1;
                }
                else if (Path.GetExtension(directoryFile) == ".png")
                {
                    file.ImageIndex = 2;
                    file.SelectedImageIndex = 2;
                }
                else if (Path.GetExtension(directoryFile) == ".loc")
                {
                    file.ImageIndex = 3;
                    file.SelectedImageIndex = 3;
                }
                else if (Path.GetExtension(directoryFile) == ".pck")
                {
                    file.ImageIndex = 4;
                    file.SelectedImageIndex = 4;
                }
                else if (Path.GetExtension(directoryFile) == ".fui")
                {
                    file.ImageIndex = 5;
                    file.SelectedImageIndex = 5;
                }
                else if (Path.GetExtension(directoryFile) == ".col")
                {
                    file.ImageIndex = 6;
                    file.SelectedImageIndex = 6;
                }
                else if (Path.GetExtension(directoryFile) == "")
                {
                    file.ImageIndex = 7;
                    file.SelectedImageIndex = 7;
                }
                else if (Path.GetExtension(directoryFile) == ".txt")
                {
                    file.ImageIndex = 8;
                    file.SelectedImageIndex = 8;
                }
                else
                {
                    file.ImageIndex = 9;
                    file.SelectedImageIndex = 9;
                }
                file.Text = Path.GetFileName(directoryFile); //Sets file name
                currentNode.Add(file); //adds final file after need subnodes are created
                saved = false;

                //Makes UI visible once a PCK is open
                foreach (ToolStripMenuItem item in fileToolStripMenuItem.DropDownItems)
                {
                    item.Enabled = true;
                }

                //Detects if LOC exists then presets for all functions that use the LOC
                foreach (TreeNode item in EntryList.Nodes)
                {
                }
                fileCount = 0;//Resets file count
                              //Gets file count based of all existing minefiles
                saved = false;
            }

            saveAsToolStripMenuItem.Enabled = true;
            saveToolStripMenuItem.Enabled = true;

        }

        public void ConvertAudio(string file, bool shown)
        {
            string[] filenames = (new[] { file });
            try
            {
                this.bink(filenames);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
            if (shown)
                if (MessageBox.Show("Converted!\ndo you want to open the folder?", "Conversion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    System.Diagnostics.Process.Start(Path.GetDirectoryName(file));
        }



        private void bink(string[] filenames)
        {
            try
            {
                string working = null;
                foreach (string infile in filenames)
                {
                    Classes.Bink.Bink.Binka(infile, fbd.SelectedPath, true, working);
                }
            }
            catch (global::System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.InnerException + ex.StackTrace);
                return;
            }
        }

        #endregion

        #region select file

        private void EntryList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
            }
            catch (Exception exep)
            {
                string errormsg = DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year + "::" + DateTime.Now.Hour + "_" + DateTime.Now.Minute + " -- " + exep.Message.ToString() + "\n\n" + exep.StackTrace.ToString();
                System.IO.Directory.CreateDirectory(LocalFolder + "\\LOGS\\");
                System.IO.File.AppendAllText(LocalFolder + "\\LOGS\\logFile-" + DateTime.Today.Day + "-" + DateTime.Today.Month + "-" + DateTime.Today.Year + ".log", errormsg + "\n\n===============NEWLOG===============n");


                if (MessageBox.Show("Update Avaliable\nDownload?", "Error!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(LocalFolder + "\\ARCUpdater.exe");
                }
            }
        }
        #endregion

        #region When FormMain Changes Sizes

        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        #endregion

        #region Open File when double clicked

        private void EntryList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (EntryList.SelectedNode.Tag != null)
                {
                    byte[] mf = File.ReadAllBytes(EntryList.SelectedNode.Tag.ToString());

                    //Checks to see if selected minefile is a binka file
                    if (Path.GetExtension(EntryList.SelectedNode.Tag.ToString()) == ".binka")
                    {
                        Console.WriteLine("BINKA!");
                        File.WriteAllText(LocalFolder + "\\BinkMan\\files.txt", EntryList.SelectedNode.Tag.ToString());
                        System.Diagnostics.Process prc1 = new System.Diagnostics.Process();
                        prc1.StartInfo.FileName = (LocalFolder + "\\BinkMan\\BinkMan.exe");
                        prc1.Start();
                        prc1.WaitForExit();
                        System.Diagnostics.Process prc = new System.Diagnostics.Process();
                        prc.StartInfo.FileName = (EntryList.SelectedNode.Tag.ToString().Replace(".binka", ".wav"));
                        prc.Start();
                        prc.WaitForExit();
                        File.Delete(EntryList.SelectedNode.Tag.ToString().Replace(".binka", ".wav"));
                        //MessageBox.Show(".binka Editor Coming Soon!");
                    }



                }
            }
            catch
            {

            }
        }


        public void ShowLoaderForm()
        {


        }

        #endregion

        #region extract file

        private void extractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EntryList.SelectedNode.ImageIndex == 0)
            {
                MessageBox.Show("Cannot extract folders(yet)");
            }
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();

                switch (Path.GetExtension(EntryList.SelectedNode.Tag.ToString()))
                {

                    case (".png"):
                        {
                            sfd.Filter = "PNG Image | *.png";
                        }
                        break;
                    case (".loc"):
                        {
                            sfd.Filter = "Localization | *.loc";
                        }
                        break;
                    case (".fui"):
                        {
                            sfd.Filter = "Fuscated Universal Image | *.fui";
                        }
                        break;
                    case (".col"):
                        {
                            sfd.Filter = "Color file | *.col";
                        }
                        break;
                    case (".binka"):
                        {
                            sfd.Filter = "Waveform Audio | *.wav";
                        }
                        break;
                    case (""):
                        {
                            sfd.Filter = "NBT Data | *.nbt";
                        }
                        break;
                }
                sfd.FileName = EntryList.SelectedNode.Text;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.Filter == "Waveform Audio | *.wav")
                    {

                        File.WriteAllText(LocalFolder + "\\BinkMan\\files.txt", EntryList.SelectedNode.Tag.ToString());
                        System.Diagnostics.Process prc1 = new System.Diagnostics.Process();
                        prc1.StartInfo.FileName = (LocalFolder + "\\BinkMan\\BinkMan.exe");
                        prc1.Start();
                        prc1.WaitForExit();
                        File.Copy(EntryList.SelectedNode.Tag.ToString().Replace(".binka", ".wav"), sfd.FileName, true);
                    }
                    else
                        File.Move(EntryList.SelectedNode.Tag.ToString(), sfd.FileName);

                }
            }


        }

        #endregion

        #region replace file

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (EntryList.SelectedNode.ImageIndex == 0)
            {
                MessageBox.Show("Cannot Replace folders");
            }
            else
            {
                OpenFileDialog sfd = new OpenFileDialog();

                switch (Path.GetExtension(EntryList.SelectedNode.Tag.ToString()))
                {

                    case (".png"):
                        {
                            sfd.Filter = "PNG Image | *.png";
                        }
                        break;
                    case (".loc"):
                        {
                            sfd.Filter = "Localization | *.loc";
                        }
                        break;
                    case (".fui"):
                        {
                            sfd.Filter = "Fuscated Universal Image | *.fui";
                        }
                        break;
                    case (".col"):
                        {
                            sfd.Filter = "Color file | *.col";
                        }
                        break;
                    case (".binka"):
                        {
                            sfd.Filter = "Waveform Audio | *.wav";
                        }
                        break;
                    case (""):
                        {
                            sfd.Filter = "NBT Data | *.nbt";
                        }
                        break;
                }
                sfd.FileName = EntryList.SelectedNode.Text;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (sfd.Filter == "Waveform Audio | *.wav")
                    {
                        File.WriteAllText(LocalFolder + "\\BinkMan\\files.txt", EntryList.SelectedNode.Tag.ToString());
                        System.Diagnostics.Process prc1 = new System.Diagnostics.Process();
                        prc1.StartInfo.FileName = (LocalFolder + "\\BinkMan\\BinkMan.exe");
                        prc1.Start();
                        prc1.WaitForExit();
                        File.Copy(sfd.FileName, EntryList.SelectedNode.Tag.ToString().Replace(".wav", ".binka"), true);
                        File.Delete(sfd.FileName);
                    }
                    else
                        File.Copy(sfd.FileName, EntryList.SelectedNode.Tag.ToString(), true);
                }
            }
        }

        #endregion

        #region Donations

        private void toPhoenixARCDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cash.app/$PhoenixARC");
        }

        private void toNobledezJackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.paypal.me/realnobledez");
        }

        #endregion

        #region new MSSCMP File

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            Classes.Variables.selectedFilePath = "";
            try
            {
                Classes.Variables.openFilePath = LocalFolder + "\\Default\\Minecraft.msscmp";
                extractMsscmp(Classes.Variables.openFilePath);
                DateTime present = DateTime.Now;
                DateTime addFiveSeconds = DateTime.Now.AddSeconds(5);

                while (DateTime.Now.TimeOfDay.TotalSeconds <= addFiveSeconds.TimeOfDay.TotalSeconds)
                {

                }
                openPck();
            }
            catch { }
        }

        #endregion
    }
}