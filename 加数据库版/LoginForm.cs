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

            string auth = getAuthorityFromDB(username, password);

            if (auth == "uhigh")
                Login("3");
            else if (auth == "umid")
                Login("2");
            else if (auth == "ulow")
                Login("1");
            else if (auth == "ucom")
                Login("0");
            else if (username == "uhigh" && password == "123456")
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
            //else if (auth == "-1")
            else
                MessageBox.Show("用户名或密码错误");

            /*
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
             */
            
        }

        private void Login(string authority)
        {
            Form1 f1 = new Form1();
            f1.authority = authority;
            f1.Show();
            this.Hide();
        }


        public string getAuthorityFromDB(string user, string pass)
        {
            string auth = "-1";

            string ConString = "Server=.;" + "Database=WordMark;" + "Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(ConString);
            con.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "select * from UserInfo";
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                String username = reader.GetValue(reader.GetOrdinal("username")).ToString();
                String password = reader.GetValue(reader.GetOrdinal("password")).ToString();
                if (username == user && password == pass)
                {
                    auth = reader.GetValue(reader.GetOrdinal("authority")).ToString();
                    break;
                }
            }

            con.Close();

            return auth;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //注册新用户
            Register regisForm = new Register();
            regisForm.Show();
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
