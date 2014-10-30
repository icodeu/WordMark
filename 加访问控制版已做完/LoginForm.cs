using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FileManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == "uhigh" && password == "123456")
            {
                Login("3");
            }
            else if (username == "umid" && password == "123456")
            {
                Login("2");
            }
            else if (username == "ulow" && password == "123456")
            {
                Login("1");
            }
            else if (username == "ucom" && password == "123456")
            {
                Login("0");
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重试");
            }
            
        }

        private void Login(string authority)
        {
            Form1 f1 = new Form1();
            f1.authority = authority;
            f1.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
