using MySql.Data.MySqlClient;
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

            string myConnection = connection.connect();

            using (MySqlConnection conn = new MySqlConnection(myConnection))
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
                        textBox_CMIname.Text = rdr["NAME"].ToString();
                        textBox_CMIaddress.Text = rdr["ADDRESS"].ToString();

                        
                        rdr.Close();
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
