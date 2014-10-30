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
    public partial class NewFolder : Form
    {
        public NewFolder()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {//确定键
            Class.Folder.NewFolder(txtName.Text, lbParentPath.Text);
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
            if (e.KeyCode == Keys.Enter)
            {
                Class.Folder.Enter(txtName.Text, lbParentPath.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}