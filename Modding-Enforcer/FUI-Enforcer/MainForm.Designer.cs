using FUI_Enforcer.Controls;
using FUI_Enforcer;

namespace FUI_Enforcer.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileOpenStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStripMenuSeparatorOpenSave = new System.Windows.Forms.ToolStripSeparator();
            this.fileSaveStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAsStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSaveAllImagesStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.openWorkingDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileStripMenuSeparatorSaveExit = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutFUIEnforcerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.Label();
            this.imageMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.invertColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSaveStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.imageReplaceStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.imageEditAttributeStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.imageBulkMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imageBulkSave = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImgLoadingIndicator = new System.Windows.Forms.ProgressBar();
            this.FUIPicturePreview = new System.Windows.Forms.PictureBox();
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.LabelSelectedIndex = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelTotalEntries = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelSelImgSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.FUIimageListView = new FUI_Enforcer.Controls.ChangableMenuListView();
            this.MainMenuStrip.SuspendLayout();
            this.imageMenuStrip.SuspendLayout();
            this.imageBulkMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FUIPicturePreview)).BeginInit();
            this.MainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenStripMenu,
            this.fileStripMenuSeparatorOpenSave,
            this.fileSaveStripMenu,
            this.fileSaveAsStripMenu,
            this.fileSaveAllImagesStripMenu,
            this.toolStripSeparator2,
            this.openWorkingDirectoryToolStripMenuItem,
            this.fileStripMenuSeparatorSaveExit,
            this.backgroundColorToolStripMenuItem,
            this.fontColorToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // fileOpenStripMenu
            // 
            this.fileOpenStripMenu.Name = "fileOpenStripMenu";
            resources.ApplyResources(this.fileOpenStripMenu, "fileOpenStripMenu");
            this.fileOpenStripMenu.Click += new System.EventHandler(this.OnClickFileOpen);
            // 
            // fileStripMenuSeparatorOpenSave
            // 
            this.fileStripMenuSeparatorOpenSave.Name = "fileStripMenuSeparatorOpenSave";
            resources.ApplyResources(this.fileStripMenuSeparatorOpenSave, "fileStripMenuSeparatorOpenSave");
            // 
            // fileSaveStripMenu
            // 
            resources.ApplyResources(this.fileSaveStripMenu, "fileSaveStripMenu");
            this.fileSaveStripMenu.Name = "fileSaveStripMenu";
            this.fileSaveStripMenu.Click += new System.EventHandler(this.OnClickFileSave);
            // 
            // fileSaveAsStripMenu
            // 
            resources.ApplyResources(this.fileSaveAsStripMenu, "fileSaveAsStripMenu");
            this.fileSaveAsStripMenu.Name = "fileSaveAsStripMenu";
            this.fileSaveAsStripMenu.Click += new System.EventHandler(this.OnClickFileSaveAs);
            // 
            // fileSaveAllImagesStripMenu
            // 
            resources.ApplyResources(this.fileSaveAllImagesStripMenu, "fileSaveAllImagesStripMenu");
            this.fileSaveAllImagesStripMenu.Name = "fileSaveAllImagesStripMenu";
            this.fileSaveAllImagesStripMenu.Click += new System.EventHandler(this.OnClickFileSaveAllImages);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // openWorkingDirectoryToolStripMenuItem
            // 
            this.openWorkingDirectoryToolStripMenuItem.Name = "openWorkingDirectoryToolStripMenuItem";
            resources.ApplyResources(this.openWorkingDirectoryToolStripMenuItem, "openWorkingDirectoryToolStripMenuItem");
            this.openWorkingDirectoryToolStripMenuItem.Click += new System.EventHandler(this.openWorkingDirectoryToolStripMenuItem_Click);
            // 
            // fileStripMenuSeparatorSaveExit
            // 
            this.fileStripMenuSeparatorSaveExit.Name = "fileStripMenuSeparatorSaveExit";
            resources.ApplyResources(this.fileStripMenuSeparatorSaveExit, "fileStripMenuSeparatorSaveExit");
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            resources.ApplyResources(this.backgroundColorToolStripMenuItem, "backgroundColorToolStripMenuItem");
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColorToolStripMenuItem_Click);
            // 
            // fontColorToolStripMenuItem
            // 
            this.fontColorToolStripMenuItem.Name = "fontColorToolStripMenuItem";
            resources.ApplyResources(this.fontColorToolStripMenuItem, "fontColorToolStripMenuItem");
            this.fontColorToolStripMenuItem.Click += new System.EventHandler(this.fontColorToolStripMenuItem_Click);
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(22)))));
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.moreToolStripMenuItem});
            resources.ApplyResources(this.MainMenuStrip, "MainMenuStrip");
            this.MainMenuStrip.Name = "MainMenuStrip";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutFUIEnforcerToolStripMenuItem});
            this.moreToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            resources.ApplyResources(this.moreToolStripMenuItem, "moreToolStripMenuItem");
            // 
            // aboutFUIEnforcerToolStripMenuItem
            // 
            this.aboutFUIEnforcerToolStripMenuItem.Name = "aboutFUIEnforcerToolStripMenuItem";
            resources.ApplyResources(this.aboutFUIEnforcerToolStripMenuItem, "aboutFUIEnforcerToolStripMenuItem");
            this.aboutFUIEnforcerToolStripMenuItem.Click += new System.EventHandler(this.aboutFUIEnforcerToolStripMenuItem_Click);
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // imageMenuStrip
            // 
            this.imageMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.imageMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.invertColorToolStripMenuItem,
            this.imageSaveStripMenu,
            this.imageReplaceStripMenu,
            this.imageEditAttributeStripMenu});
            this.imageMenuStrip.Name = "contextMenuStrip1";
            resources.ApplyResources(this.imageMenuStrip, "imageMenuStrip");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // invertColorToolStripMenuItem
            // 
            this.invertColorToolStripMenuItem.Name = "invertColorToolStripMenuItem";
            resources.ApplyResources(this.invertColorToolStripMenuItem, "invertColorToolStripMenuItem");
            this.invertColorToolStripMenuItem.Click += new System.EventHandler(this.invertColorToolStripMenuItem_Click);
            // 
            // imageSaveStripMenu
            // 
            this.imageSaveStripMenu.Name = "imageSaveStripMenu";
            resources.ApplyResources(this.imageSaveStripMenu, "imageSaveStripMenu");
            this.imageSaveStripMenu.Click += new System.EventHandler(this.OnClickImageSave);
            // 
            // imageReplaceStripMenu
            // 
            this.imageReplaceStripMenu.Name = "imageReplaceStripMenu";
            resources.ApplyResources(this.imageReplaceStripMenu, "imageReplaceStripMenu");
            this.imageReplaceStripMenu.Click += new System.EventHandler(this.OnClickImageReplace);
            // 
            // imageEditAttributeStripMenu
            // 
            this.imageEditAttributeStripMenu.Name = "imageEditAttributeStripMenu";
            resources.ApplyResources(this.imageEditAttributeStripMenu, "imageEditAttributeStripMenu");
            this.imageEditAttributeStripMenu.Click += new System.EventHandler(this.OnClickImageEditAttribute);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            resources.ApplyResources(this.imageList, "imageList");
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageBulkMenuStrip
            // 
            this.imageBulkMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.imageBulkMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageBulkSave,
            this.replaceSelectedToolStripMenuItem});
            this.imageBulkMenuStrip.Name = "imageBulkMenuStrip";
            resources.ApplyResources(this.imageBulkMenuStrip, "imageBulkMenuStrip");
            // 
            // imageBulkSave
            // 
            this.imageBulkSave.Name = "imageBulkSave";
            resources.ApplyResources(this.imageBulkSave, "imageBulkSave");
            this.imageBulkSave.Click += new System.EventHandler(this.OnClickImagesSave);
            // 
            // replaceSelectedToolStripMenuItem
            // 
            this.replaceSelectedToolStripMenuItem.Name = "replaceSelectedToolStripMenuItem";
            resources.ApplyResources(this.replaceSelectedToolStripMenuItem, "replaceSelectedToolStripMenuItem");
            this.replaceSelectedToolStripMenuItem.Click += new System.EventHandler(this.replaceSelectedToolStripMenuItem_Click);
            // 
            // ImgLoadingIndicator
            // 
            resources.ApplyResources(this.ImgLoadingIndicator, "ImgLoadingIndicator");
            this.ImgLoadingIndicator.MarqueeAnimationSpeed = 10;
            this.ImgLoadingIndicator.Name = "ImgLoadingIndicator";
            this.ImgLoadingIndicator.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ImgLoadingIndicator.Value = 50;
            // 
            // FUIPicturePreview
            // 
            resources.ApplyResources(this.FUIPicturePreview, "FUIPicturePreview");
            this.FUIPicturePreview.Name = "FUIPicturePreview";
            this.FUIPicturePreview.TabStop = false;
            this.FUIPicturePreview.Click += new System.EventHandler(this.PicPreview_Click);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelSelectedIndex,
            this.LabelTotalEntries,
            this.LabelSelImgSize});
            resources.ApplyResources(this.MainStatusStrip, "MainStatusStrip");
            this.MainStatusStrip.Name = "MainStatusStrip";
            // 
            // LabelSelectedIndex
            // 
            this.LabelSelectedIndex.Name = "LabelSelectedIndex";
            resources.ApplyResources(this.LabelSelectedIndex, "LabelSelectedIndex");
            // 
            // LabelTotalEntries
            // 
            this.LabelTotalEntries.Name = "LabelTotalEntries";
            resources.ApplyResources(this.LabelTotalEntries, "LabelTotalEntries");
            // 
            // LabelSelImgSize
            // 
            this.LabelSelImgSize.Name = "LabelSelImgSize";
            resources.ApplyResources(this.LabelSelImgSize, "LabelSelImgSize");
            // 
            // FUIimageListView
            // 
            this.FUIimageListView.AllowDrop = true;
            this.FUIimageListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.FUIimageListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.FUIimageListView, "FUIimageListView");
            this.FUIimageListView.ForeColor = System.Drawing.Color.White;
            this.FUIimageListView.HideSelection = false;
            this.FUIimageListView.LargeImageList = this.imageList;
            this.FUIimageListView.MultiSelectedContextMenuStrip = this.imageBulkMenuStrip;
            this.FUIimageListView.Name = "FUIimageListView";
            this.FUIimageListView.SingleSelectedContextMenuStrip = this.imageMenuStrip;
            this.FUIimageListView.SmallImageList = this.imageList;
            this.FUIimageListView.StateImageList = this.imageList;
            this.FUIimageListView.TileSize = new System.Drawing.Size(100, 100);
            this.FUIimageListView.UseCompatibleStateImageBehavior = false;
            this.FUIimageListView.View = System.Windows.Forms.View.SmallIcon;
            this.FUIimageListView.SelectedIndexChanged += new System.EventHandler(this.imageListView_SelectedIndexChanged);
            this.FUIimageListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.imageListView_MouseDoubleClick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.ImgLoadingIndicator);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.FUIPicturePreview);
            this.Controls.Add(this.FUIimageListView);
            this.Controls.Add(this.MainMenuStrip);
            this.Controls.Add(this.MainStatusStrip);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.imageMenuStrip.ResumeLayout(false);
            this.imageBulkMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FUIPicturePreview)).EndInit();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileOpenStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fileSaveStripMenu;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAsStripMenu;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.Label statusLabel;
        private ChangableMenuListView FUIimageListView;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip imageMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem imageReplaceStripMenu;
        private System.Windows.Forms.ToolStripMenuItem imageSaveStripMenu;
        private System.Windows.Forms.ToolStripSeparator fileStripMenuSeparatorOpenSave;
        private System.Windows.Forms.ToolStripMenuItem fileSaveAllImagesStripMenu;
        private System.Windows.Forms.ToolStripSeparator fileStripMenuSeparatorSaveExit;
        private System.Windows.Forms.ContextMenuStrip imageBulkMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem imageBulkSave;
        private System.Windows.Forms.ToolStripMenuItem imageEditAttributeStripMenu;
        private System.Windows.Forms.ToolStripMenuItem invertColorToolStripMenuItem;
        private System.Windows.Forms.PictureBox FUIPicturePreview;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LabelSelectedIndex;
        private System.Windows.Forms.ToolStripStatusLabel LabelTotalEntries;
        private System.Windows.Forms.ToolStripStatusLabel LabelSelImgSize;
        private System.Windows.Forms.ToolStripMenuItem replaceSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ProgressBar ImgLoadingIndicator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openWorkingDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutFUIEnforcerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontColorToolStripMenuItem;
    }
}

