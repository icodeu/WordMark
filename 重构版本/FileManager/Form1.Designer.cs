using System.Drawing;
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
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSmall = new System.Windows.Forms.ImageList(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextmenudelete = new System.Windows.Forms.ToolStripMenuItem();
            this.copy = new System.Windows.Forms.ToolStripMenuItem();
            this.cut = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.只显示秘密文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.只显示机密文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.只显示绝密文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.文件ToolStripMenuItem});
            this.mainMenu1.Location = new System.Drawing.Point(0, 0);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Size = new System.Drawing.Size(482, 25);
            this.mainMenu1.TabIndex = 0;
            this.mainMenu1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 22);
            this.Exit.Text = "退出";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // imageSmall
            // 
            this.imageSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageSmall.ImageStream")));
            this.imageSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageSmall.Images.SetKeyName(0, "CLSDFOLD.ICO");
            this.imageSmall.Images.SetKeyName(1, "NOTE03.ICO");
            this.imageSmall.Images.SetKeyName(2, "INFO.ICO");
            this.imageSmall.Images.SetKeyName(3, "35FLOPPY.ICO");
            this.imageSmall.Images.SetKeyName(4, "lock_yellow.ico");
            this.imageSmall.Images.SetKeyName(5, "word.ico");
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextmenudelete,
            this.copy,
            this.cut,
            this.paste,
            this.只显示秘密文件ToolStripMenuItem,
            this.只显示机密文件ToolStripMenuItem,
            this.只显示绝密文件ToolStripMenuItem,
            this.显示全部ToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(185, 180);
            // 
            // contextmenudelete
            // 
            this.contextmenudelete.Name = "contextmenudelete";
            this.contextmenudelete.Size = new System.Drawing.Size(184, 22);
            this.contextmenudelete.Text = "标记为秘密";
            this.contextmenudelete.Click += new System.EventHandler(this.contextmenudelete_Click);
            // 
            // copy
            // 
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(184, 22);
            this.copy.Text = "标记为机密";
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // cut
            // 
            this.cut.Name = "cut";
            this.cut.Size = new System.Drawing.Size(184, 22);
            this.cut.Text = "标记为绝密";
            this.cut.Click += new System.EventHandler(this.cut_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(184, 22);
            this.paste.Text = "查询该文件密级属性";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // 只显示秘密文件ToolStripMenuItem
            // 
            this.只显示秘密文件ToolStripMenuItem.Name = "只显示秘密文件ToolStripMenuItem";
            this.只显示秘密文件ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.只显示秘密文件ToolStripMenuItem.Text = "只显示秘密文件";
            this.只显示秘密文件ToolStripMenuItem.Click += new System.EventHandler(this.只显示秘密文件ToolStripMenuItem_Click);
            // 
            // 只显示机密文件ToolStripMenuItem
            // 
            this.只显示机密文件ToolStripMenuItem.Name = "只显示机密文件ToolStripMenuItem";
            this.只显示机密文件ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.只显示机密文件ToolStripMenuItem.Text = "只显示机密文件";
            this.只显示机密文件ToolStripMenuItem.Click += new System.EventHandler(this.只显示机密文件ToolStripMenuItem_Click);
            // 
            // 只显示绝密文件ToolStripMenuItem
            // 
            this.只显示绝密文件ToolStripMenuItem.Name = "只显示绝密文件ToolStripMenuItem";
            this.只显示绝密文件ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.只显示绝密文件ToolStripMenuItem.Text = "只显示绝密文件";
            this.只显示绝密文件ToolStripMenuItem.Click += new System.EventHandler(this.只显示绝密文件ToolStripMenuItem_Click);
            // 
            // 显示全部ToolStripMenuItem
            // 
            this.显示全部ToolStripMenuItem.Name = "显示全部ToolStripMenuItem";
            this.显示全部ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.显示全部ToolStripMenuItem.Text = "显示全部";
            this.显示全部ToolStripMenuItem.Click += new System.EventHandler(this.取消文件密级ToolStripMenuItem_Click);
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
            this.lv_allinfo.SelectedIndexChanged += new System.EventHandler(this.lv_allinfo_SelectedIndexChanged);
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
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ImageList imageSmall;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem contextmenudelete;
        private System.Windows.Forms.ImageList imageLarge;
        private System.Windows.Forms.Label lb_currentpath;
        private System.Windows.Forms.Button bt_back;
        private System.Windows.Forms.ListView lv_allinfo;
        private System.Windows.Forms.TextBox tb_currentpath;
        private System.Windows.Forms.ToolStripMenuItem copy;
        private System.Windows.Forms.ToolStripMenuItem cut;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem 只显示秘密文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 只显示机密文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 只显示绝密文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示全部ToolStripMenuItem;
    }
}

