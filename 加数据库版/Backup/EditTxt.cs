using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FileManager
{
    public partial class EditTxt : Form
    {
        bool a;//主要用于判断文件是否保存
        public EditTxt()
        {
            InitializeComponent();
            a = false;
        }

        private void EditTxt_Load(object sender, EventArgs e)
        {//显示
            txtContent.Text = Class.Txt.Display(lb_fullname.Text);
        }

        private void OpenMenu_Click(object sender, EventArgs e)
        {//打开
            Class.Txt.Open(dlgOpenFile, lb_fullname.Text, txtContent.Text);
        }

        private void NewMenu_Click(object sender, EventArgs e)
        {//新建
            txtContent.Clear();
        }

        private void SaveMenu_Click(object sender, EventArgs e)
        {//保存
            Class.Txt.Save(lb_fullname.Text, txtContent.Text);
            a = true;
        }

        private void SaveAsMenu_Click(object sender, EventArgs e)
        {//另存为
            Class.Txt.SaveAs(dlgSaveFile, txtContent.Text);
            a = true;
            this.Close();
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {//退出
            this.Close();
        }

        private void menuItemBold_Click(object sender, EventArgs e)
        {//字体粗体
            Class.Txt.Bold(txtContent);
        }

        private void menuItemItalic_Click(object sender, EventArgs e)
        {//字体斜体
            Class.Txt.Italic(txtContent);
        }

        private void menuItemUnderline_Click(object sender, EventArgs e)
        {//字体下划线
            Class.Txt.Underline(txtContent);
        }

        private void editPaste_Click(object sender, EventArgs e)
        {//粘贴
            Class.Txt.Paste(txtContent);
        }

        private void editCopy_Click(object sender, EventArgs e)
        {//复制
            Class.Txt.Copy(txtContent);
        }

        private void editTrim_Click(object sender, EventArgs e)
        {//剪切
            Class.Txt.Cut(txtContent);
        }

        private void editUndo_Click(object sender, EventArgs e)
        {//撤消
            txtContent.Undo();
        }

        private void EditTxt_FormClosing(object sender, FormClosingEventArgs e)
        {//退出
            if (a == false)     //退出时判断是否保存
            {
                Class.Txt.Exit(lb_fullname.Text, txtContent.Text);
            }
        }
    }
}