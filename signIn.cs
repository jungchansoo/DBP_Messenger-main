using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using on_off_proj;

namespace DB_SNS
{
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
            
            setUp();
        }
        string strconn = "Server=118.67.143.130;Port=3306;Database=DBP;Uid=root;Pwd=B3J5RmHYibc;Charset=utf8";

        private void button_login_Click(object sender, EventArgs e)
        {
            BinaryWriter brChecked = new BinaryWriter(new FileStream("setting.stu", FileMode.OpenOrCreate));

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                
                string login_id = textBox_id.Text;
                string login_pw = textBox_pw.Text;

                DBManager.GetInstance().setUserId(login_id);

                string query = "SELECT * FROM on_off WHERE ID = '"+login_id+"'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                bool login = false;
                while (rdr.Read())
                {
                    if(login_id == (string)rdr["ID"] && login_pw == (string)rdr["PW"])
                    {
                        login = true;
                    }
                }
                rdr.Close();

                if (login)
                {
                    if (checkBox_Remember.Checked)
                    {
                        brChecked.Write("Remember_Account=true");
                        brChecked.Write("ID="+textBox_id.Text);
                        brChecked.Write("PW="+Encrypt.encryptAES128(textBox_pw.Text));
                    }
                    else
                    {
                        brChecked.Write("Remember_Account=false");
                    }
                    MessageBox.Show("LOGIN SUCCESS");
                    this.Visible = false;
                    chattingList chat = new chattingList();
                    chat.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("LOGIN FAILED");
                }
                brChecked.Close();
            }
        }
        
        public void setUp()
        {
            BinaryReader brChecked = new BinaryReader(new FileStream("setting.stu", FileMode.OpenOrCreate));
            try
            {
                string check = brChecked.ReadString();

                if (check.Substring(17) == "false")
                {
                    return;
                }
                else if (check.Substring(17) == "true")
                {
                    string id = brChecked.ReadString();
                    string pw = brChecked.ReadString();

                    checkBox_Remember.Checked = true;
                    textBox_id.Text = id.Substring(3);
                    textBox_pw.Text = Encrypt.decryptAES128(pw.Substring(3));
                }
            }
            catch (EndOfStreamException)
            {
                return;
            }
            finally
            {
                brChecked.Close();
            }
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void singUpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
