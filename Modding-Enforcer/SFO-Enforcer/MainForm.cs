using Param_SFO;
using SFO_Enforcer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PARAM.SFO_Enforcer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string FileLocation)
        {
            InitializeComponent();

            //clear pannels
            cbxAddon.Items.Clear();
            cbVersion.Items.Clear();
            cbSystemVersion.Items.Clear();
            cbxAppVersion.Items.Clear();

            txtSFOpath.Text = FileLocation;
            using (FileStream str = File.OpenRead(FileLocation))
            {

                psfo = new Param_SFO.PARAM_SFO(FileLocation);

                //WriteToXmlFile(Application.StartupPath + @"\testing.xml", psfo.Tables, true);

                MainPath = System.IO.Path.GetDirectoryName(FileLocation);

                //Check MAGIC
                if (psfo != null)
                    ReloadSFO();
            }
        }

        #region << Error Code >>

        //----The Point of this is to simulate ps3 data corrupt for whatever reason
        int errorcount = 0;
        bool errors = false;
        public void errormessage(int errorcount)
        {
            string message = "The Parameters of the System File Object has errors they have been marked\n\n\r\t Total Errors " + errorcount + "\n\n\r\t";
            MessageBox.Show(message, "Errors Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion << Error Code >>

        private System.Windows.Forms.Timer timer1;

        int i = 0;
        string MainPath;
        bool InitialLoad, CheckBoxBusy = false;

        public static Param_SFO.PARAM_SFO psfo;

        public static Param_SFO.PARAM_SFO.Playstation version;

        System.Timers.Timer timer;

        #region << For The Image Loop >>

        public void RunTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = Convert.ToInt32(TimeSpan.FromSeconds(5).TotalMilliseconds); // in milliseconds
            timer1.Start();
            if (backgroundWorker1.IsBusy == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        public void Stoptimer()
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy == false && backgroundWorker1.CancellationPending == false)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        #endregion << For The Image Loop >>

        #region << Methods >>

        #region << Swapping and bytes >>


        public static string ByteArrayToHexString(byte[] ByteArray)
        {
            string HexString = "";
            for (int i = 0; i < ByteArray.Length; ++i)
                HexString += ByteArray[i].ToString("X2"); // +" ";
            return HexString;
        }

        public static string HexStringToAscii(string HexString, bool cleanEndOfString)
        {
            try
            {
                string StrValue = "";
                // While there's still something to convert in the hex string
                while (HexString.Length > 0)
                {
                    // Use ToChar() to convert each ASCII value (two hex digits) to the actual character
                    StrValue += System.Convert.ToChar(System.Convert.ToUInt32(HexString.Substring(0, 2), 16)).ToString();

                    // Remove from the hex object the converted value
                    HexString = HexString.Substring(2, HexString.Length - 2);
                }
                // Clean String
                if (cleanEndOfString)
                    StrValue = StrValue.Replace("\0", "");

                return StrValue;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string ByteArrayToAscii(byte[] ByteArray, int startPos, int length, bool cleanEndOfString)
        {
            byte[] byteArrayPhrase = new byte[length];
            Array.Copy(ByteArray, startPos, byteArrayPhrase, 0, byteArrayPhrase.Length);
            string hexPhrase = ByteArrayToHexString(byteArrayPhrase);
            return HexStringToAscii(hexPhrase, true);
        }

        #endregion << Swapping and bytes >>

        /// <summary>
        /// Gets the common path for PS4Tools
        /// I like to put it inside AppData/Roaming
        /// </summary>
        /// <returns></returns>
        private string AppCommonPath()
        {
            string returnstring = "";

            returnstring = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Ps4Tools\";

            return returnstring;
        }

        /// <summary>
        /// This will extract all resources for the solution
        /// v0.2- This Extracts SCE tools to the appdata folder
        /// V1.1+ - This only creates the working directory as we no longer need sce tools
        /// </summary>
        public void ExtractAllResources()
        {
            if (!Directory.Exists(AppCommonPath()))
            {
                Directory.CreateDirectory(AppCommonPath());
            }


            #region << (NO LONGER REQUIRED)>>
            //if (!Directory.Exists(AppCommonPath() + @"\ext\"))
            //{
            //    Directory.CreateDirectory(AppCommonPath() + @"\ext\");
            //}
            ////We will replace every file each time we call any toolkit to stop issues with different versions ext ext

            //////SCE Files 
            ////copy byte files

            ////ext
            //System.IO.File.WriteAllBytes(AppCommonPath() + @"\ext\" + "di.exe", Properties.Resources.di);
            //System.IO.File.WriteAllBytes(AppCommonPath() + @"\ext\" + "sc.exe", Properties.Resources.sc);
            //System.IO.File.WriteAllBytes(AppCommonPath() + @"\ext\" + "libatrac9.dll", Properties.Resources.libatrac9);
            ////orbis
            //System.IO.File.WriteAllBytes(AppCommonPath() + "orbis-pub-cmd.exe", Properties.Resources.orbis_pub_cmd);
            //System.IO.File.WriteAllBytes(AppCommonPath() + "orbis-pub-rx.dll", Properties.Resources.orbis_pub_prx);

            ////copy text files
            //System.IO.File.WriteAllText(AppCommonPath() + @"\ext\" + "trp_compare_default.css", Properties.Resources.trp_compare_default);

            #endregion << (NO LONGER REQUIRED)>>

            //Delete Working Directory and re-create it
            if (Directory.Exists(AppCommonPath() + @"\Working\"))
            {
                DeleteDirectory(AppCommonPath() + @"\Working\");
            }
            Directory.CreateDirectory(AppCommonPath() + @"\Working\");

        }

        /// <summary>
        /// Recursively delete directory
        /// </summary>
        /// <param name="target_dir">The Main Target Directory</param>
        public static void DeleteDirectory(string target_dir)
        {
            string[] files = Directory.GetFiles(target_dir);
            string[] dirs = Directory.GetDirectories(target_dir);

            foreach (string file in files)
            {
                File.SetAttributes(file, FileAttributes.Normal);
                File.Delete(file);
            }

            foreach (string dir in dirs)
            {
                DeleteDirectory(dir);
            }

            Directory.Delete(target_dir, false);
        }


        #region << SFX/SFO As XML >>

        public void CreateSFX(Param_SFO.PARAM_SFO psfo, SaveFileDialog dlg)
        {
            string FileHeader;
            if (version == PARAM_SFO.Playstation.ps4)
            {
                //list items we don't want to see in the SFX
                List<string> Blockeditems = new List<string>();
                Blockeditems.Add("PUBTOOLINFO");
                Blockeditems.Add("DEV_FLAG");
                Blockeditems.Add("PUBTOOLVER");

                //table items
                FileHeader = CreateSFXHeader();
                string XMLItem = FileHeader + "\n<paramsfo>";//begin the tag
                foreach (var item in psfo.Tables)
                {
                    if (!Blockeditems.Contains(item.Name))
                        XMLItem += "\n\t<param key=\"" + item.Name + "\">" + item.Value + "</param>";
                }
                XMLItem += "\n</paramsfo>";//close the tag
                //we dont aks user where he wants to save the file 



                System.IO.File.WriteAllText(AppCommonPath() + @"\Working\param.sfx", XMLItem);

                System.IO.File.Copy(AppCommonPath() + @"\Working\param.sfx", dlg.FileName, true);//overwrite the file if it already exists

                System.Diagnostics.Process.Start("explorer.exe", System.IO.Path.GetDirectoryName(dlg.FileName));//start explorer
                //System.IO.File.Delete(AppCommonPath() + @"\Working\param.sfx");//remove the SFX

                MessageBox.Show("SFX Created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                psfo.SaveSFO(psfo, dlg.FileName);

                MessageBox.Show("SFX Created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        public string CreateSFXHeader()
        {
            return "<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>";
        }

        #endregion << SFX/SFO As XML >>


        #endregion << Methods >>

        #region << Events >>

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process.Start(Path.GetDirectoryName(Application.StartupPath));
        }

        private void txtTitleId_TextChanged(object sender, EventArgs e)
        {
            if (InitialLoad == false)
            {
                for (int i = 0; i < psfo.Tables.Count; i++)
                {
                    if (psfo.Tables[i].Name == "TITLE_ID")
                    {
                        var tempitem = psfo.Tables[i];
                        tempitem.Value = txtTitleId.Text.Trim();
                        psfo.Tables[i] = tempitem;
                    }
                }
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

            if (InitialLoad == false)
            {
                for (int i = 0; i < psfo.Tables.Count; i++)
                {
                    if (psfo.Tables[i].Name == "TITLE")
                    {
                        var tempitem = psfo.Tables[i];
                        tempitem.Value = txtTitle.Text.Trim();
                        psfo.Tables[i] = tempitem;
                    }
                }
            }
        }

        private void cbSystemVersion_TextChanged(object sender, EventArgs e)
        {
            if (InitialLoad == false)
            {
                for (int i = 0; i < psfo.Tables.Count; i++)
                {
                    if (psfo.Tables[i].Name == "SYSTEM_VER" || psfo.Tables[i].Name == "PS3_SYSTEM_VER")
                    {
                        var tempitem = psfo.Tables[i];
                        tempitem.Value = cbSystemVersion.Text.Trim();
                        psfo.Tables[i] = tempitem;
                    }
                }
            }
        }

        private void cbxParent_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < psfo.Tables.Count; i++)
            {
                if (psfo.Tables[i].Name == cbxParent.Tag.ToString())
                {
                    var tempitem = psfo.Tables[i];
                    tempitem.Value = cbxParent.Text.Trim();
                    psfo.Tables[i] = tempitem;
                }
            }
        }

        private void cbxParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InitialLoad == false)
            {
                for (int i = 0; i < psfo.Tables.Count; i++)
                {
                    if (psfo.Tables[i].Name == cbxParent.Tag.ToString())
                    {
                        var tempitem = psfo.Tables[i];
                        tempitem.Value = cbxParent.Text.Trim();
                        psfo.Tables[i] = tempitem;
                    }
                }
            }
        }

        private void cbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InitialLoad == false)
            {
                for (int i = 0; i < psfo.Tables.Count; i++)
                {
                    if (psfo.Tables[i].Name == cbVersion.Tag.ToString())
                    {
                        var tempitem = psfo.Tables[i];
                        tempitem.Value = cbVersion.Text.Trim();
                        psfo.Tables[i] = tempitem;
                    }
                }
            }
        }

        private void cbxAppVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InitialLoad == false)
            {
                for (int i = 0; i < psfo.Tables.Count; i++)
                {
                    if (psfo.Tables[i].Name == cbxAppVersion.Tag.ToString())
                    {
                        var tempitem = psfo.Tables[i];
                        tempitem.Value = cbxAppVersion.Text.Trim();
                        psfo.Tables[i] = tempitem;
                    }
                }
            }
        }
        /// <summary>
        /// Load Button Event ( Loads a psfo from a location )
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //check for updates on start up 
            //no longer required as we no use click once

            ExtractAllResources();

            timer = new System.Timers.Timer(TimeSpan.FromSeconds(3).TotalMilliseconds);
            timer.Elapsed += timer_Elapsed;
            timer.Enabled = true;
            LoadRanomImage();


            Version v = Assembly.GetExecutingAssembly().GetName().Version;
            //Check to see if we are ClickOnce Deployed.
            //i.e. the executing code was installed via ClickOnce
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                //Collect the ClickOnce Current Version
                v = ApplicationDeployment.CurrentDeployment.CurrentVersion;
            }

            //Show the version in a simple manner
            this.Text = string.Format("PARAM.SFO EDITOR : {0}", v);
        }

        public void LoadRanomImage()
        {
            Random r = new Random();
            int switcher = r.Next(0, 3);
        }
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            LoadRanomImage();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                while (i == 0)
                {
                    #region << PS3 >>
                    if (version == Param_SFO.PARAM_SFO.Playstation.ps3)
                    {

                        if (Directory.Exists(MainPath + @"\C00\") && i == 0)
                        {
                            if (File.Exists(MainPath + @"\C00\ICON0.PNG"))
                            {

                            }
                            i = 1;
                            Thread.Sleep(1500);
                        }
                        else
                        {
                            if (File.Exists(MainPath + @"\ICON0.PNG"))
                            {

                            }
                            i = 1;
                            Thread.Sleep(1500);
                        }
                    }
                    #endregion << PS3 >>
                    else
                    {
                        if (File.Exists(MainPath + @"\ICON0.PNG"))
                        {

                        }
                        i = 1;
                        Thread.Sleep(1500);
                    }
                }
                while (i == 1)
                {
                    try
                    {
                        #region << PS3 >>
                        if (version == PARAM_SFO.Playstation.ps3)
                        {
                            if (Directory.Exists(MainPath + @"\C00\") && i == 1)
                            {
                                if (File.Exists(MainPath + @"\C00\PIC1.PNG"))
                                {

                                }
                                i = 0;
                                Thread.Sleep(1500);
                            }
                            else
                            {
                                if (File.Exists(MainPath + @"\PIC1.PNG"))
                                {

                                }
                                i = 0;
                                Thread.Sleep(1500);
                            }
                        }
                        #endregion << PS3 >>

                        else
                        {
                            Random rnd = new Random();
                            int ran = rnd.Next(1, 3);
                            if (ran == 1)
                            {
                                if (File.Exists(MainPath + @"\PIC1.PNG"))
                                {

                                }
                            }
                            else
                            {
                                if (File.Exists(MainPath + @"\PIC0.PNG"))
                                {

                                }
                            }
                            i = 0;
                            Thread.Sleep(1500);
                        }
                    }
                    catch (Exception ee)
                    {
                        string test = ee.Message;
                    }
                }
            }
        }

        private void cbxAddon_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Param_SFO.PARAM_SFO.Table item in psfo.Tables)
            {
                if (item.Name == cbxAddon.SelectedItem.ToString().Trim() && item.Name != string.Empty)
                {
                    CheckBoxBusy = true;
                    txtAddonData.Text = item.Value.ToString();
                    CheckBoxBusy = false;
                    txtAddonData.MaxLength = Convert.ToInt32(item.Indextable.param_data_max_len);
                }
            }
        }

        private void txtAddonData_Leave(object sender, EventArgs e)
        {
            //on leave save the info to the table
            for (int i = 0; i < psfo.Tables.Count; i++)
            {
                if (psfo.Tables[i].Name == cbxAddon.SelectedItem.ToString().Trim())
                {
                    var tempitem = psfo.Tables[i];
                    tempitem.Value = txtAddonData.Text.Trim();
                    psfo.Tables[i] = tempitem;
                }
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //item has been cancled
                MessageBox.Show("Prog Cancled");
            }
        }

        #region << Resolutions >>

        private void chb720_CheckedChanged(object sender, EventArgs e)
        {
            if (InitialLoad == true || CheckBoxBusy == true)
            {
                return;
            }

            CheckBoxBusy = true;

            //first get the value from param table
            int iValue = 0, psfoValue = 0;

            for (int i = 0; i < psfo.Tables.Count; i++)
            {
                if (psfo.Tables[i].Name == "RESOLUTION")
                {
                    int.TryParse(psfo.Tables[i].Value, out psfoValue);
                    iValue = i;
                    break;
                }
            }
        }

        private void chbx576Wide_CheckedChanged(object sender, EventArgs e)
        {
            if (InitialLoad == true || CheckBoxBusy == true)
            {
                return;
            }

            CheckBoxBusy = true;

            //first get the value from param table
            int iValue = 0, psfoValue = 0;

            for (int i = 0; i < psfo.Tables.Count; i++)
            {
                if (psfo.Tables[i].Name == "RESOLUTION")
                {
                    int.TryParse(psfo.Tables[i].Value, out psfoValue);
                    iValue = i;
                    break;
                }
            }
        }

        #endregion << Resolutions >>

        private void button2_Click(object sender, EventArgs e)
        {

        }

        #endregion << Events >>

        public List<Param_SFO.PARAM_SFO.Table> AddNewItem(int Index, string Name, string Value, Param_SFO.PARAM_SFO.FMT format, int lenght, int maxlength, List<Param_SFO.PARAM_SFO.Table> xtable)
        {
            Param_SFO.PARAM_SFO.index_table indextable = new Param_SFO.PARAM_SFO.index_table();

            Param_SFO.PARAM_SFO.Table tableitem = new Param_SFO.PARAM_SFO.Table();

            indextable.param_data_fmt = format;
            indextable.param_data_len = Convert.ToUInt32(lenght);
            indextable.param_data_max_len = Convert.ToUInt32(maxlength);
            tableitem.index = Index;
            tableitem.Indextable = indextable;
            tableitem.Name = Name;
            tableitem.Value = Value;
            xtable.Add(tableitem);

            return xtable;
        }

        int NewItemIndex = 0; //this var is used for item indexes
        List<Param_SFO.PARAM_SFO.Table> xtables = new List<Param_SFO.PARAM_SFO.Table>();
        private void button4_Click(object sender, EventArgs e)
        {

        }

        public void ReloadSFO()
        {
            if (psfo != null)
            {
                //set initial load too true so we dont do anything unnasasary 
                InitialLoad = true;

                cbxAddon.Items.Clear();
                cbSystemVersion.Items.Clear();
                cbVersion.Items.Clear();
                cbxAppVersion.Items.Clear();

                //we just use this list to state that we already added an item just in case don't want duplicates
                List<string> AlreadyAdded = new List<string>();

                version = psfo.PlaystationVersion;

                if (version == PARAM_SFO.Playstation.ps4)
                {

                }

                foreach (Param_SFO.PARAM_SFO.Table t in psfo.Tables.ToList())
                {
                    #region << Pub tool Info >>

                    if (t.Name == "PUBTOOLINFO")
                    {
                        AlreadyAdded.Add(t.Name);
                        //and here we have it now we can add max lengths so users can't break anything
                    }
                    if (t.Name == "PUBTOOLVER")
                    {
                        //cbxPS4Pub
                        int value = Convert.ToInt32(t.Value);
                        string hexOutput = String.Format("{0:X}", value);
                        AlreadyAdded.Add(t.Name);
                    }
                    #endregion << Pub tool Info >>

                    #region << Vita Stuff >>

                    if (t.Name == "PSP2_SYSTEM_VER")
                    {
                        cbSystemVersion.Tag = t.Name;
                        //we know its a vita
                        int value = Convert.ToInt32(t.Value);
                        string hexOutput = String.Format("{0:X}", value);
                        cbSystemVersion.Items.Add(hexOutput);
                        AlreadyAdded.Add(t.Name);
                        cbSystemVersion.SelectedIndex = 0;

                        cbSystemVersion.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                    }

                    if (t.Name == "NP_COMMUNICATION_ID")
                    {
                        AlreadyAdded.Add(t.Name);
                    }

                    if (t.Name == "INSTALL_DIR_ADDCONT")
                    {
                        AlreadyAdded.Add(t.Name);
                    }
                    if (t.Name == "INSTALL_DIR_SAVEDATA")
                    {
                        AlreadyAdded.Add(t.Name);
                    }
                    if (t.Name == "SAVEDATA_MAX_SIZE")
                    {
                        AlreadyAdded.Add(t.Name);
                    }

                    if (t.Name == "STITLE")
                    {
                        AlreadyAdded.Add(t.Name);
                    }

                    #endregion << Vita Stuff >>

                    #region << PS3 Stuff >>

                    if (t.Name == "SOUND_FORMAT")
                    {
                        #region << PS3 Sound Format >>
                        int Val = 0;
                        int.TryParse(t.Value.Trim(), out Val);
                        switch (Val)
                        {
                            case 1:
                                break;
                            default:
                                break;
                        }
                        #endregion << PS3 Sound Format >>
                    }

                    if (t.Name == "PS3_SYSTEM_VER")
                    {
                        cbSystemVersion.Tag = t.Name;
                        //we know its PS3
                        cbSystemVersion.Items.Add(t.Value);
                        AlreadyAdded.Add(t.Name);
                        cbSystemVersion.SelectedIndex = 0;

                        cbSystemVersion.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                    }

                    #endregion << PS3 Stuff >>

                    #region << Cross Sony Platforms >>

                    if (t.Name == "TITLE_ID")
                    {
                        lblTitleID.Text = "TitleID:";
                        txtTitleId.Text = t.Value.Trim();
                        txtTitleId.Tag = t.Name;
                        AlreadyAdded.Add(t.Name);
                        //and here we have it now we can add max lengths so users can't break anything
                        txtTitleId.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                    }

                    if (t.Name == "ATTRIBUTE")
                    {
                        int Val = 0;
                        int.TryParse(t.Value.Trim(), out Val);
                        #region << PS4 >>
                        if (psfo.PlaystationVersion == PARAM_SFO.Playstation.ps4)
                        {
                            switch (Val)
                            {
                                case 0://this app does not support initial users to log out
                                    break;
                                case 1:
                                    break;
                            }
                        }
                        #endregion << PS4 >>
                        #region << PSVita >>
                        if (psfo.PlaystationVersion == PARAM_SFO.Playstation.psvita)
                        {
                            switch (Val)
                            {

                            }
                            //we need to check the tags and do some calculations 
                            int TempHolder = Val;
                        }
                        //AlreadyAdded.Add(t.Name);//dont add tp already added as we want to see if the attribute changes as we swap items
                        #endregion << PSVita >>
                    }

                    if (t.Name == "CONTENT_ID")
                    {
                        AlreadyAdded.Add(t.Name);
                    }
                    if (t.Name == "TITLE")
                    {
                        txtTitle.Text = t.Value.Trim();
                        txtTitle.Tag = t.Name;
                        AlreadyAdded.Add(t.Name);
                        txtTitle.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                    }
                    if (t.Name == "CATEGORY")
                    {
                        //we need to know what version of the sfo this is either ps3 / psvita(ps4)
                        //this id use for ps4 i geus vita can work 2
                        if (version == PARAM_SFO.Playstation.ps4)
                        {
                            var hex = (BitConverter.ToString(t.ValueBuffer, 0, Convert.ToInt32(t.Indextable.param_data_max_len))).ToString().Replace("-", string.Empty);
                            var temp = Convert.ToInt32(hex).ToString("X4");

                            var stringtemp = Encoding.ASCII.GetString(t.ValueBuffer).Replace("\0", "");

                            txtCATEGORY.Text = ((Param_SFO.PARAM_SFO.DataTypes)Convert.ToInt32(hex)).ToString();
                        }
                        else if (version == PARAM_SFO.Playstation.ps3)
                            //ps3
                            txtCATEGORY.Text = ((Param_SFO.PARAM_SFO.DataTypes)BitConverter.ToUInt16(Encoding.UTF8.GetBytes(t.Value), 0)).ToString();
                        else
                        {
                            //for now straight 
                            txtCATEGORY.Text = t.Value;
                        }
                        //var remp = BitConverter.ToUInt16(Encoding.Default.GetBytes(hex), 0);
                        txtCATEGORY.Tag = t.Name;
                        AlreadyAdded.Add(t.Name);
                        txtCATEGORY.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                    }
                    if (t.Name == "APP_VER")
                    {
                        cbxAppVersion.Enabled = true;
                        cbxAppVersion.Items.Add(t.Value.Trim());
                        cbxAppVersion.Tag = t.Name;
                        AlreadyAdded.Add(t.Name);
                        cbxAppVersion.SelectedIndex = 0;
                        cbxAppVersion.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                    }
                    if (t.Name == "APP_TYPE")
                    {
                        AlreadyAdded.Add(t.Name);
                    }
                    if (t.Name == "VERSION")
                    {
                        cbVersion.Items.Add(t.Value.Trim());
                        cbVersion.Tag = t.Name;
                        AlreadyAdded.Add(t.Name);
                        cbVersion.SelectedIndex = 0;
                        cbVersion.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                    }
                    if (t.Name == "PARENTAL_LEVEL")
                    {
                        if (t.Value == "")
                        {
                            cbxParent.SelectedIndex = 0;
                        }
                        else
                        {
                            cbxParent.Tag = t.Name;
                            cbxParent.SelectedIndex = Convert.ToInt32(t.Value);
                            AlreadyAdded.Add(t.Name);
                            cbxParent.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                        }
                    }

                    #endregion << Cross all playstation platforms>>

                    #region << PS4 Stuff >>

                    if (t.Name == "SYSTEM_VER")
                    {
                        cbSystemVersion.Tag = t.Name;
                        int value = Convert.ToInt32(t.Value);
                        string hexOutput = String.Format("{0:X}", value);
                        cbSystemVersion.Items.Add(t.Value);
                        AlreadyAdded.Add(t.Name);
                        cbSystemVersion.SelectedIndex = 0;
                        cbSystemVersion.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);

                    }

                    #endregion << PS4 Stuff >>

                    #region << PSP Stuff >>

                    if (t.Name == "PSP_SYSTEM_VER")
                    {
                        cbSystemVersion.Tag = t.Name;
                        //we know its a psp
                        cbSystemVersion.Items.Add(t.Value);

                        AlreadyAdded.Add(t.Name);
                        cbSystemVersion.SelectedIndex = 0;
                        cbSystemVersion.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                    }

                    if (t.Name == "DISC_VERSION")
                    {
                        cbVersion.Items.Add(t.Value.Trim());
                        cbVersion.Tag = t.Name;
                        AlreadyAdded.Add(t.Name);
                        cbVersion.SelectedIndex = 0;
                        cbVersion.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                        cbxAppVersion.Enabled = false;
                    }

                    if (t.Name == "DISC_ID")
                    {
                        lblTitleID.Text = "Disc ID:";
                        txtTitleId.Text = t.Value.Trim();
                        txtTitleId.Tag = t.Name;
                        AlreadyAdded.Add(t.Name);
                        //and here we have it now we can add max lengths so users can't break anything
                        txtTitleId.MaxLength = Convert.ToInt32(t.Indextable.param_data_max_len);
                    }

                    #endregion << PSP_Stuff >>

                    if (!AlreadyAdded.Contains(t.Name))
                    {
                        cbxAddon.Items.Add(t.Name);
                    }


                }

                //after loading we need to spesify some things
                cbxAddon.SelectedIndex = 0;
                if (backgroundWorker1.IsBusy == true)
                {
                    Stoptimer();
                    backgroundWorker1.CancelAsync();
                }

                RunTimer();
                InitialLoad = false;
                saveToolStripMenuItem.Enabled = true;
            }
        }

        private void txtCATEGORY_TextChanged(object sender, EventArgs e)
        {
            if (InitialLoad == false)
            {
                for (int i = 0; i < psfo.Tables.Count; i++)
                {
                    if (psfo.Tables[i].Name == "CATEGORY")
                    {
                        var tempitem = psfo.Tables[i];
                        tempitem.Value = txtCATEGORY.Text.Trim();
                        psfo.Tables[i] = tempitem;
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clear pannels
            cbxAddon.Items.Clear();
            cbVersion.Items.Clear();
            cbSystemVersion.Items.Clear();
            cbxAppVersion.Items.Clear();

            //Open the file diaglog and load up an sfo
            OpenFileDialog thedialog = new OpenFileDialog();
            thedialog.Title = "PARAM.SFO";
            thedialog.Filter = ".SFO|*.SFO";//file type 
            thedialog.InitialDirectory = System.Environment.SpecialFolder.MyComputer.ToString();//start somewhere in the users computer
            if (thedialog.ShowDialog() == DialogResult.OK)//wait for OK
            {
                //set sfo path to textbox 
                txtSFOpath.Text = thedialog.FileName.ToString();

                //we have a timer runnign to show some cool ui stuff (IMAGES Looping)
                timer.Stop();

                //open the file stream
                using (FileStream str = File.OpenRead(thedialog.FileName.ToString()))
                {
                    psfo = new Param_SFO.PARAM_SFO(thedialog.FileName.ToString());

                    MainPath = System.IO.Path.GetDirectoryName(thedialog.FileName.ToString());

                    //Check MAGIC
                    if (psfo != null)
                    {
                        ReloadSFO();
                    }
                    else
                    {
                        MessageBox.Show("The file selected isn't a valid SFO", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void aboutSFOEnforcerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // create an instance of the AboutForm
            AboutForm aboutForm = new AboutForm();

            // show the AboutForm as a dialog box
            aboutForm.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "PARAM.SFO (PARAM.SFO)|PARAM.SFO";
            dlg.DefaultExt = "SFO";
            dlg.AddExtension = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {

                //sort psfo just to get everything 
                Param_SFO.PARAM_SFO tempholder = psfo;

                //if ps4 add pub tool info 
                //we do need to check if this is all valid

                if (psfo.PlaystationVersion == PARAM_SFO.Playstation.ps4)
                {
                    bool foundpubinfo = false;
                    bool foundpubver = false;
                    for (int i = 0; i < psfo.Tables.Count; i++)
                    {
                        if (psfo.Tables[i].Name == "PUBTOOLINFO")
                        {
                            foundpubinfo = true;
                        }
                        if (psfo.Tables[i].Name == "PUBTOOLVER")
                        {
                            foundpubver = true;
                        }
                    }

                    NewItemIndex = psfo.Tables.Count;
                    if (foundpubinfo == false) { AddNewItem(NewItemIndex++, "PUBTOOLINFO", "c_date=20180504,sdk_ver=04008000,st_type=digital50,snd0_loud=-25.56,img0_l0_size=1032,img0_l1_size=0,img0_sc_ksize=4608,img0_pc_ksize=1344", Param_SFO.PARAM_SFO.FMT.Utf8Null, 139, 512, psfo.Tables); }
                    if (foundpubver == false) { AddNewItem(NewItemIndex++, "PUBTOOLVER", "2890000", Param_SFO.PARAM_SFO.FMT.UINT32, 4, 4, psfo.Tables); }//just give it custom file info
                }


                var SortedList = psfo.Tables.OrderBy(o => o.Name).ToList();

                for (int i = 0; i < SortedList.Count; i++)
                {
                    var temp = SortedList[i];
                    temp.index = i;
                    SortedList[i] = temp;
                }
                psfo.Tables = SortedList;//stupid me forgot to add this

                //user wants to save in a new location or whatever
                psfo.SaveSFO(psfo, dlg.FileName);
                //CreateSFX(psfo, dlg);/*Old Method using CMD*/
                MessageBox.Show("SFO Created", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}