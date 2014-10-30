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
    public partial class NewFile : Form
    {
        public NewFile()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {//确定键
            Class.Txt.NewFile(txtName.Text, lbParentPath.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {//按下Enter键
            if (e.KeyCode == Keys.Enter)            //当按下的键是Enter键触发事件
            {
                Class.Txt.Enter(txtName.Text, lbParentPath.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

    }
}