using MySql.Data.MySqlClient;
using on_off_proj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_SNS
{
    public partial class changeData : Form
    {
        
        public string login_id { get; set; }
        public string login_pw { get; set; }

        public changeData(string login_id, string login_pw)
        {
            InitializeComponent();
            this.login_id = login_id;
            this.login_pw = login_pw;
            SetForm();

        }
        string strconn = "Server=118.67.143.130;Port=3306;Database=DBP;Uid=root;Pwd=B3J5RmHYibc";


        //USERID, USERPW,NAME,ADDRESS,NICKNAME
        //로그인 완료 후 데이터를 불러오는 메소드
        public void SetForm()
        {
            string FileName = "";
            UInt32 FileSize;
            Byte[] imgData = null;

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
                        textBox_cgnickname.Text = (string)rdr["NICKNAME"];

                        try
                        {
                            FileSize = rdr.GetUInt32(rdr.GetOrdinal("filesize"));
                            imgData = new byte[FileSize];

                            rdr.GetBytes(rdr.GetOrdinal("file"), 0, imgData, 0, (int)FileSize);
                            FileName = @System.IO.Directory.GetCurrentDirectory() + "\\newfile.jpeg";

                            ProfilePicture.Image = imageBt.read_imagebyte(imgData);
                            


                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("NO Data");
                            return;
                        }
                        finally
                        {
                            rdr.Close();
                            conn.Close();
                        }
                        
                    }
                }

                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //패스워드,이름,주소,별명을 저장하는 버튼 이벤트
        private void button_cgsave_Click(object sender, EventArgs e)
        {
            string nickname = textBox_cgnickname.Text;

            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                string query = query = "UPDATE SNS SET NICKNAME='" + nickname + "' WHERE USERID ='" + login_id + "'";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("SAVED");

            }
        }

        //버튼 클릭시 이미지 표시, DB 저장
        String imgPath = "";
        private void button_change_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog pFileDlg = new OpenFileDialog();
            pFileDlg.Filter = "All Files(*.*)|*.*";
            pFileDlg.Title = "편집할 파일을 선택하여 주세요.";
            byte[] imgData = null;

            if (pFileDlg.ShowDialog() == DialogResult.OK)
            {
                imgPath = pFileDlg.FileName;
                UInt32 FileSize;
                FileStream fs;
                ProfilePicture.Load(imgPath);
                ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;

                using (MySqlConnection conn = new MySqlConnection(strconn))
                {
                    try
                    {
                        conn.Open();
                        fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read);
                        FileSize = (UInt32)fs.Length;
                        imgData = imageBt.insert_imagebyte(imgPath);

                        string query = "UPDATE SNS SET IMGNAME = '" + imgPath + "'FILESIZE ='" + FileSize + "', IMG = '" +
                        imgData + "' WHERE USERID ='" + login_id + "'";
                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("File Inserted into database successfully!",
                            "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        fs.Close();
                        conn.Close();
                    }
                    catch (MySql.Data.MySqlClient.MySqlException ex)
                    {
                        MessageBox.Show("Error " + ex.Number + " has occurred: " + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } // end of try to catch finally
                }
            }
        }
    }
}
