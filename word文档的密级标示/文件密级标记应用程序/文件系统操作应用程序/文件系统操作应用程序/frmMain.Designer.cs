namespace 文件系统操作应用程序
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnSecure = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnjm = new System.Windows.Forms.ToolStripButton();
            this.btn3 = new System.Windows.Forms.ToolStripButton();
            this.tvwFileSystem = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.lvwFileSystem = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btnSecure,
            this.btnClose,
            this.btnjm,
            this.btn3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(580, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.AutoToolTip = false;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(51, 22);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSecure
            // 
            this.btnSecure.AutoToolTip = false;
            this.btnSecure.Image = ((System.Drawing.Image)(resources.GetObject("btnSecure.Image")));
            this.btnSecure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSecure.Name = "btnSecure";
            this.btnSecure.Size = new System.Drawing.Size(75, 22);
            this.btnSecure.Text = "标定秘密";
            this.btnSecure.Click += new System.EventHandler(this.btnSecure_Click);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.AutoToolTip = false;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(51, 22);
            this.btnClose.Text = "关闭";
            // 
            // btnjm
            // 
            this.btnjm.AutoToolTip = false;
            this.btnjm.Image = ((System.Drawing.Image)(resources.GetObject("btnjm.Image")));
            this.btnjm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnjm.Name = "btnjm";
            this.btnjm.Size = new System.Drawing.Size(75, 22);
            this.btnjm.Text = "标定机密";
            this.btnjm.Click += new System.EventHandler(this.btnjm_Click);
            // 
            // btn3
            // 
            this.btn3.AutoToolTip = false;
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 22);
            this.btn3.Text = "标定绝密";
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // tvwFileSystem
            // 
            this.tvwFileSystem.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvwFileSystem.HideSelection = false;
            this.tvwFileSystem.Location = new System.Drawing.Point(0, 25);
            this.tvwFileSystem.Name = "tvwFileSystem";
            this.tvwFileSystem.Size = new System.Drawing.Size(173, 368);
            this.tvwFileSystem.TabIndex = 1;
            this.tvwFileSystem.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tvwFileSystem_AfterExpand);
            this.tvwFileSystem.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwFileSystem_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(173, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 368);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // lvwFileSystem
            // 
            this.lvwFileSystem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chNum,
            this.chDate});
            this.lvwFileSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFileSystem.FullRowSelect = true;
            this.lvwFileSystem.GridLines = true;
            this.lvwFileSystem.HideSelection = false;
            this.lvwFileSystem.Location = new System.Drawing.Point(176, 25);
            this.lvwFileSystem.Name = "lvwFileSystem";
            this.lvwFileSystem.Size = new System.Drawing.Size(404, 368);
            this.lvwFileSystem.TabIndex = 3;
            this.lvwFileSystem.UseCompatibleStateImageBehavior = false;
            this.lvwFileSystem.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.Text = "名称";
            this.chName.Width = 157;
            // 
            // chNum
            // 
            this.chNum.Text = "大小";
            this.chNum.Width = 70;
            // 
            // chDate
            // 
            this.chDate.Text = "修改时间";
            this.chDate.Width = 90;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 393);
            this.Controls.Add(this.lvwFileSystem);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tvwFileSystem);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "文件密级管理器";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnSecure;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.TreeView tvwFileSystem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ListView lvwFileSystem;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chNum;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ToolStripButton btnjm;
        private System.Windows.Forms.ToolStripButton btn3;

    }
}

