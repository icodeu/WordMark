namespace FileManager
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenu1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSmall = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenufolder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenufile = new System.Windows.Forms.ToolStripMenuItem();
            this.contextmenudelete = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.查看方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详细信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageLarge = new System.Windows.Forms.ImageList(this.components);
            this.lb_currentpath = new System.Windows.Forms.Label();
            this.tb_currentpath = new System.Windows.Forms.TextBox();
            this.bt_back = new System.Windows.Forms.Button();
            this.lv_allinfo = new System.Windows.Forms.ListView();
            this.mainMenu1.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem});
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(482, 24);
            this.mainMenu1.TabIndex = 0;
            this.mainMenu1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.Exit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFolder,
            this.NewFile});
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // NewFolder
            // 
            this.NewFolder.Name = "NewFolder";
            this.NewFolder.Size = new System.Drawing.Size(106, 22);
            this.NewFolder.Text = "文件夹";
            this.NewFolder.Click += new System.EventHandler(this.NewFolder_Click);
            // 
            // NewFile
            // 
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(106, 22);
            this.NewFile.Text = "文件";
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 22);
            this.Exit.Text = "退出";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(94, 22);
            this.Delete.Text = "删除";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // imageSmall
            // 
            this.imageSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSmall.ImageStream")));
            this.imageSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSmall.Images.SetKeyName(0, "CLSDFOLD.ICO");
            this.imageSmall.Images.SetKeyName(1, "NOTE03.ICO");
            this.imageSmall.Images.SetKeyName(2, "INFO.ICO");
            this.imageSmall.Images.SetKeyName(3, "35FLOPPY.ICO");
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem1,
            this.contextmenudelete,
            this.copy,
            this.cut,
            this.paste,
            this.查看方式ToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(119, 136);
            // 
            // 新建ToolStripMenuItem1
            // 
            this.新建ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmenufolder,
            this.contextmenufile});
            this.新建ToolStripMenuItem1.Name = "新建ToolStripMenuItem1";
            this.新建ToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.新建ToolStripMenuItem1.Text = "新建";
            // 
            // contextmenufolder
            // 
            this.contextmenufolder.Name = "contextmenufolder";
            this.contextmenufolder.Size = new System.Drawing.Size(106, 22);
            this.contextmenufolder.Text = "文件夹";
            this.contextmenufolder.Click += new System.EventHandler(this.contextmenufolder_Click);
            // 
            // contextmenufile
            // 
            this.contextmenufile.Name = "contextmenufile";
            this.contextmenufile.Size = new System.Drawing.Size(106, 22);
            this.contextmenufile.Text = "文件";
            this.contextmenufile.Click += new System.EventHandler(this.contextmenufile_Click);
            // 
            // contextmenudelete
            // 
            this.contextmenudelete.Name = "contextmenudelete";
            this.contextmenudelete.Size = new System.Drawing.Size(118, 22);
            this.contextmenudelete.Text = "删除";
            this.contextmenudelete.Click += new System.EventHandler(this.contextmenudelete_Click);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(118, 22);
            this.copy.Text = "复制";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(118, 22);
            this.cut.Text = "剪切";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(118, 22);
            this.paste.Text = "粘贴";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // 查看方式ToolStripMenuItem
            // 
            this.查看方式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.大图标ToolStripMenuItem,
            this.小图标ToolStripMenuItem,
            this.列表ToolStripMenuItem,
            this.详细信息ToolStripMenuItem,
            this.文件名ToolStripMenuItem});
            this.查看方式ToolStripMenuItem.Name = "查看方式ToolStripMenuItem";
            this.查看方式ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.查看方式ToolStripMenuItem.Text = "查看方式";
            // 
            // 大图标ToolStripMenuItem
            // 
            this.大图标ToolStripMenuItem.Name = "大图标ToolStripMenuItem";
            this.大图标ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.大图标ToolStripMenuItem.Text = "大图标";
            this.大图标ToolStripMenuItem.Click += new System.EventHandler(this.BigToolStripMenuItem_Click);
            // 
            // 小图标ToolStripMenuItem
            // 
            this.小图标ToolStripMenuItem.Name = "小图标ToolStripMenuItem";
            this.小图标ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.小图标ToolStripMenuItem.Text = "小图标";
            this.小图标ToolStripMenuItem.Click += new System.EventHandler(this.SmallToolStripMenuItem_Click);
            // 
            // 列表ToolStripMenuItem
            // 
            this.列表ToolStripMenuItem.Name = "列表ToolStripMenuItem";
            this.列表ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.列表ToolStripMenuItem.Text = "列表";
            this.列表ToolStripMenuItem.Click += new System.EventHandler(this.ListToolStripMenuItem_Click);
            // 
            // 详细信息ToolStripMenuItem
            // 
            this.详细信息ToolStripMenuItem.Name = "详细信息ToolStripMenuItem";
            this.详细信息ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.详细信息ToolStripMenuItem.Text = "详细信息";
            this.详细信息ToolStripMenuItem.Click += new System.EventHandler(this.DetailsToolStripMenuItem_Click);
            // 
            // 文件名ToolStripMenuItem
            // 
            this.文件名ToolStripMenuItem.Name = "文件名ToolStripMenuItem";
            this.文件名ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.文件名ToolStripMenuItem.Text = "文件名";
            this.文件名ToolStripMenuItem.Click += new System.EventHandler(this.TitleToolStripMenuItem_Click);
            // 
            // imageLarge
            // 
            this.imageLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageLarge.ImageStream")));
            this.imageLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageLarge.Images.SetKeyName(0, "CLSDFOLD.ICO");
            this.imageLarge.Images.SetKeyName(1, "NOTE03.ICO");
            this.imageLarge.Images.SetKeyName(2, "INFO.ICO");
            this.imageLarge.Images.SetKeyName(3, "35FLOPPY.ICO");
            // 
            // lb_currentpath
            // 
            this.lb_currentpath.AutoSize = true;
            this.lb_currentpath.Location = new System.Drawing.Point(12, 54);
            this.lb_currentpath.Name = "lb_currentpath";
            this.lb_currentpath.Size = new System.Drawing.Size(65, 12);
            this.lb_currentpath.TabIndex = 2;
            this.lb_currentpath.Text = "当前路径：";
            // 
            // tb_currentpath
            // 
            this.tb_currentpath.Location = new System.Drawing.Point(83, 51);
            this.tb_currentpath.Name = "tb_currentpath";
            this.tb_currentpath.Size = new System.Drawing.Size(237, 21);
            this.tb_currentpath.TabIndex = 3;
            // 
            // bt_back
            // 
            this.bt_back.Location = new System.Drawing.Point(336, 49);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(120, 23);
            this.bt_back.TabIndex = 4;
            this.bt_back.Text = "返回上级目录";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // lv_allinfo
            // 
            this.lv_allinfo.ContextMenuStrip = this.contextMenu;
            this.lv_allinfo.LargeImageList = this.imageLarge;
            this.lv_allinfo.Location = new System.Drawing.Point(12, 87);
            this.lv_allinfo.Name = "lv_allinfo";
            this.lv_allinfo.Size = new System.Drawing.Size(458, 209);
            this.lv_allinfo.SmallImageList = this.imageSmall;
            this.lv_allinfo.TabIndex = 5;
            this.lv_allinfo.UseCompatibleStateImageBehavior = false;
            this.lv_allinfo.View = System.Windows.Forms.View.Details;
            this.lv_allinfo.DoubleClick += new System.EventHandler(this.lv_allinfo_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(482, 308);
            this.Controls.Add(this.lv_allinfo);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.tb_currentpath);
            this.Controls.Add(this.lb_currentpath);
            this.Controls.Add(this.bt_back);
            this.MainMenuStrip = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mainMenu1.ResumeLayout(false);
            this.mainMenu1.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFolder;
        private System.Windows.Forms.ToolStripMenuItem NewFile;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ImageList imageSmall;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contextmenudelete;
        private System.Windows.Forms.ImageList imageLarge;
        private System.Windows.Forms.Label lb_currentpath;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.ListView lv_allinfo;
        private System.Windows.Forms.TextBox tb_currentpath;
        private System.Windows.Forms.ToolStripMenuItem contextmenufolder;
        private System.Windows.Forms.ToolStripMenuItem contextmenufile;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem 查看方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详细信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 文件名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paste;
    }
}

