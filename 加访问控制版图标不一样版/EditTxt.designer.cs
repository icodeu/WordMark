namespace FileManager
{
    partial class EditTxt
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBold = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemItalic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemUnderline = new System.Windows.Forms.ToolStripMenuItem();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.editTrim = new System.Windows.Forms.ToolStripMenuItem();
            this.editPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.editUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_fullname = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤消ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.选项ToolStripMenuItem,
            this.操作ToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(469, 24);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenu,
            this.NewMenu,
            this.SaveMenu,
            this.SaveAsMenu,
            this.ExitMenu});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // OpenMenu
            // 
            this.OpenMenu.Name = "OpenMenu";
            this.OpenMenu.Size = new System.Drawing.Size(106, 22);
            this.OpenMenu.Text = "打开";
            this.OpenMenu.Click += new System.EventHandler(this.OpenMenu_Click);
            // 
            // NewMenu
            // 
            this.NewMenu.Name = "NewMenu";
            this.NewMenu.Size = new System.Drawing.Size(106, 22);
            this.NewMenu.Text = "新建";
            this.NewMenu.Click += new System.EventHandler(this.NewMenu_Click);
            // 
            // SaveMenu
            // 
            this.SaveMenu.Name = "SaveMenu";
            this.SaveMenu.Size = new System.Drawing.Size(106, 22);
            this.SaveMenu.Text = "保存";
            this.SaveMenu.Click += new System.EventHandler(this.SaveMenu_Click);
            // 
            // SaveAsMenu
            // 
            this.SaveAsMenu.Name = "SaveAsMenu";
            this.SaveAsMenu.Size = new System.Drawing.Size(106, 22);
            this.SaveAsMenu.Text = "另存为";
            this.SaveAsMenu.Click += new System.EventHandler(this.SaveAsMenu_Click);
            // 
            // ExitMenu
            // 
            this.ExitMenu.Name = "ExitMenu";
            this.ExitMenu.Size = new System.Drawing.Size(106, 22);
            this.ExitMenu.Text = "退出";
            this.ExitMenu.Click += new System.EventHandler(this.ExitMenu_Click);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemBold,
            this.menuItemItalic,
            this.menuItemUnderline});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // menuItemBold
            // 
            this.menuItemBold.Name = "menuItemBold";
            this.menuItemBold.Size = new System.Drawing.Size(106, 22);
            this.menuItemBold.Text = "粗体";
            this.menuItemBold.Click += new System.EventHandler(this.menuItemBold_Click);
            // 
            // menuItemItalic
            // 
            this.menuItemItalic.Name = "menuItemItalic";
            this.menuItemItalic.Size = new System.Drawing.Size(106, 22);
            this.menuItemItalic.Text = "斜体";
            this.menuItemItalic.Click += new System.EventHandler(this.menuItemItalic_Click);
            // 
            // menuItemUnderline
            // 
            this.menuItemUnderline.Name = "menuItemUnderline";
            this.menuItemUnderline.Size = new System.Drawing.Size(106, 22);
            this.menuItemUnderline.Text = "下划线";
            this.menuItemUnderline.Click += new System.EventHandler(this.menuItemUnderline_Click);
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCopy,
            this.editTrim,
            this.editPaste,
            this.editUndo});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // editCopy
            // 
            this.editCopy.Name = "editCopy";
            this.editCopy.Size = new System.Drawing.Size(94, 22);
            this.editCopy.Text = "复制";
            this.editCopy.Click += new System.EventHandler(this.editCopy_Click);
            // 
            // editTrim
            // 
            this.editTrim.Name = "editTrim";
            this.editTrim.Size = new System.Drawing.Size(94, 22);
            this.editTrim.Text = "剪切";
            this.editTrim.Click += new System.EventHandler(this.editTrim_Click);
            // 
            // editPaste
            // 
            this.editPaste.Name = "editPaste";
            this.editPaste.Size = new System.Drawing.Size(94, 22);
            this.editPaste.Text = "粘贴";
            this.editPaste.Click += new System.EventHandler(this.editPaste_Click);
            // 
            // editUndo
            // 
            this.editUndo.Name = "editUndo";
            this.editUndo.Size = new System.Drawing.Size(94, 22);
            this.editUndo.Text = "撤消";
            this.editUndo.Click += new System.EventHandler(this.editUndo_Click);
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.Filter = "Text Document(*.txt)|*.txt";
            this.dlgSaveFile.FilterIndex = 2;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            this.dlgOpenFile.Filter = "Text Document(*.txt)|*.txt";
            this.dlgOpenFile.FilterIndex = 2;
            // 
            // txtContent
            // 
            this.txtContent.ContextMenuStrip = this.contextMenuStrip1;
            this.txtContent.Location = new System.Drawing.Point(12, 90);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(445, 205);
            this.txtContent.TabIndex = 1;
            this.txtContent.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前文本路径：";
            // 
            // lb_fullname
            // 
            this.lb_fullname.AutoSize = true;
            this.lb_fullname.Location = new System.Drawing.Point(104, 55);
            this.lb_fullname.Name = "lb_fullname";
            this.lb_fullname.Size = new System.Drawing.Size(41, 12);
            this.lb_fullname.TabIndex = 3;
            this.lb_fullname.Text = "label2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.剪切ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.撤消ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 92);
            // 
            // edit
            // 
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(94, 22);
            this.edit.Text = "复制";
            this.edit.Click += new System.EventHandler(this.editCopy_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.editTrim_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.editPaste_Click);
            // 
            // 撤消ToolStripMenuItem
            // 
            this.撤消ToolStripMenuItem.Name = "撤消ToolStripMenuItem";
            this.撤消ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.撤消ToolStripMenuItem.Text = "撤消";
            this.撤消ToolStripMenuItem.Click += new System.EventHandler(this.editUndo_Click);
            // 
            // EditTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 307);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lb_fullname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "EditTxt";
            this.Text = "EditTxt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditTxt_FormClosing);
            this.Load += new System.EventHandler(this.EditTxt_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenu;
        private System.Windows.Forms.ToolStripMenuItem NewMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveMenu;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenu;
        private System.Windows.Forms.ToolStripMenuItem ExitMenu;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemBold;
        private System.Windows.Forms.ToolStripMenuItem menuItemItalic;
        private System.Windows.Forms.ToolStripMenuItem menuItemUnderline;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lb_fullname;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCopy;
        private System.Windows.Forms.ToolStripMenuItem editTrim;
        private System.Windows.Forms.ToolStripMenuItem editPaste;
        private System.Windows.Forms.ToolStripMenuItem editUndo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 撤消ToolStripMenuItem;
    }
}