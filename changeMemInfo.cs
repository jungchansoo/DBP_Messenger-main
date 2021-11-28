using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace on_off_proj
{
    public partial class changeMemInfo : Form
    {
        public string login_id { get; set; }
        public string login_pw { get; set; }

        public changeMemInfo(string login_id, string login_pw)
        {
            InitializeComponent();
            this.login_id = login_id;
            this.login_pw = login_pw;
            SetForm();
        }

        public void SetForm()
        {

            string strconn = "Server=27.96.130.41;Database=s5727722;Uid=s5727722;Pwd=s5727722";

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SNS WHERE USERID='" + login_id + "'";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        textBox_CMIpassword.Text = login_pw;
                        textBox_CMIname.Text = (string)rdr["NAME"];
                        textBox_CMIaddress.Text = (string)rdr["ADDRESS"];

                        
                        rdr.Close();
                        conn.Close();

                    }
                }

                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
