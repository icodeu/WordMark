using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 文件系统操作应用程序
{
   /* private string _FileName = null;
    ///<summary>
    ///处理的文件名
    ///</summary>
    public string FileName
    {
        get
        {
            return _FileName;
        }
        set
        {
            _FileName = value;
        }
    }*/  
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
        
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
    
}
