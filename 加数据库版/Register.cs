using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FileManager
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //确定按钮
            string username = textBox1.Text;
            string password = textBox2.Text;
            string confirm = textBox3.Text;
            string authority = textBox4.Text;
            if (password == confirm)
            {
                writeToDB(username, password, confirm, authority);
                MessageBox.Show("新用户注册成功,点击确定返回登录");
                this.Close();
            }
            else
                MessageBox.Show("两次密码输入不一致，请重新输入");
        }

        void writeToDB(string username, string password, string confirm, string authority)
        {
            string ConString = "Server=.;" + "Database=WordMark;" + "Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            string sqlString = "insert into UserInfo values ('" + username + "', '" + password + "', '" + authority + "')";
            cmd.CommandText = sqlString;
            //SqlDataReader reader = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();


            con.Close();

        }




    }
}
