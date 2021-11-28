using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace on_off_proj
{
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }


        private void button_sing_up_save_Click(object sender, EventArgs e)
        {
            string myConnection = "Server=118.67.143.130;Port=3306;Database=DBP;Uid=root;Pwd=B3J5RmHYibc;Charset=utf8";
            using (MySqlConnection connection = new MySqlConnection(myConnection))
            {
                connection.Open();
                int count = 1; // 비밀키

                //아이디 중복확인 처리
                Boolean ID_check = true;

                try//예외 처리
                {
                    string Query = "SELECT * FROM on_off";

                    MySqlCommand mySqlCommand = new MySqlCommand(Query, connection);
                    MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                    if (mySqlDataReader.HasRows == true) //db에 1개 이상의 값이 있다면 실행
                    {
                        while (mySqlDataReader.Read())
                        {
                            if (textBox_sign_up_ID.Text == mySqlDataReader["ID"].ToString())
                            {
                                MessageBox.Show("아이디가 중복됩니다.");
                                ID_check = false;
                            }
                        }
                        count = Convert.ToInt32(mySqlDataReader["count"].ToString()) + 1;
                    }
                    mySqlDataReader.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }

                //비밀번호 암호화
                string pw = AES.Encryption(textBox_sign_up_PW.Text, count.ToString());

                //이미지파일 바이트단위저장
                byte[] IMG = null;
                if (textBox_sign_up_image_path.Text != "")
                {
                    IMG = imageBt.insert_imagebyte(this.textBox_sign_up_image_path.Text);
                }



                //회원가입
                string insertQuery = "INSERT INTO on_off(ID, PW, 이름, 주소, 별명, 프로필사진)" +
                   "VALUES('" + this.textBox_sign_up_ID.Text + "','" + pw + "','" + this.textBox_sign_up_Name.Text + "','"
                   + this.textBox_sign_up_Address.Text + "','" + this.textBox_sign_up_Nickname.Text + "',@IMG)";
                try
                {
                    MySqlCommand mySqlInsertCommand = new MySqlCommand(insertQuery, connection);

                    mySqlInsertCommand.Parameters.Add(new MySqlParameter("@IMG", IMG));


                    if (ID_check == true)
                    {
                        mySqlInsertCommand.ExecuteNonQuery();
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }
        }

            private void pictureBox_sign_up_Click(object sender, EventArgs e)
        {
            OpenFileDialog dig = new OpenFileDialog();
            dig.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";



            if (dig.ShowDialog() == DialogResult.OK)
            {
                string picLoc = dig.FileName.ToString();
                textBox_sign_up_image_path.Text = picLoc;
                pictureBox_sign_up.ImageLocation = picLoc;



            }

        }

        private void textBox_sign_up_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_sign_up_PW_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_sign_up_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }


        
    }
}
