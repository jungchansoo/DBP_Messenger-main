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
    public partial class chattingList : Form
    {
        DataTable chatList, chatHistory, checkReceive;
        private string uId = DBManager.GetInstance().getUserId();


        public chattingList()
        {
            InitializeComponent();
        }

        private void chattingList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void chattingList_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM ";
            string whereLike = "WHERE (userId like '%" + uId + "%')";
            string where = "WHERE (userId = '" + uId + "')";

            chatList = DBManager.GetInstance().select(query + "Chat_list " + whereLike + "ORDER BY roomId;");
            checkReceive = DBManager.GetInstance().select(query + "CheckReceive " + where + ";");
            chatHistory = DBManager.GetInstance().select(query + "Chat_History;");

            for (int i = 0; i < chatList.Rows.Count; i++)
            {
                DataRow uIdRow = chatList.DefaultView.ToTable(false, "userId").Rows[i];
                string userList = uIdRow[0].ToString();
                DataRow rIdRow = chatList.DefaultView.ToTable(false, "roomId").Rows[i];
                int roomId = Convert.ToInt32(rIdRow[0].ToString());
                DataRow[] checkRow = checkReceive.Select("userId='"+uId+"' AND roomId = "+roomId+"");
                int check = Convert.ToInt32(checkRow[0]["checkRead"].ToString());

                DataRow[] chatLog = chatHistory.Select("roomId = " + roomId + "");
                string lastContents = chatLog[chatLog.Length-1]["contents"].ToString();



                GroupBox groupBox = new GroupBox();
                groupBox.Text = null;
                groupBox.Size = new Size(419, 100);
                groupBox.Location = new Point(37, 54 + 100*i);
                groupBox.Tag = i;
                groupBox.Click += new EventHandler(chatClick);

                Label chatName = new Label();
                chatName.Text = userList;
                chatName.Location = new Point(groupBox.Location.X + 10, groupBox.Location.Y + 10);

                Label lastCon = new Label();
                lastCon.Text = lastContents;
                lastCon.Location = new Point(groupBox.Location.X + 10, groupBox.Location.Y + 30);

                this.Controls.Add(lastCon);
                this.Controls.Add(chatName);
                this.Controls.Add(groupBox);
                
            }
            

        }

        private void chatClick(object sender, EventArgs e)
        {
            GroupBox group = sender as GroupBox;
            int tag = (int)group.Tag;
            chatWindow chat = new chatWindow();
            chat.Show();
        }
    }
}
