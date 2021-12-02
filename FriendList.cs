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
    public partial class FriendList : Form
    {
        public string login_id { get; set; }

        public FriendList(string login_id)
        {
            InitializeComponent();
            this.login_id = login_id;
        }
        
        private void FriendList_Load_1(object sender, EventArgs e)
        {
            createFriendItems();
            createUserItem();
        }

        private void createUserItem()
        {
            UserControl1 listItem = new UserControl1();

            listItem.Uname = login_id;
            byte[] img = Friend.image(login_id);
            if(img == null)
            {
                listItem.Icon = Properties.Resources.imoji1;
            }
            else
            {
                listItem.Icon = imageBt.read_imagebyte(img);
            }
            

            panel1.Controls.Add(listItem);

        }


        private void createFriendItems()
        {
            int count = Friend.check_Friend_count(login_id);

            string[] Friend_info = Friend.Friend_info(count, login_id);
            UserControl1[] listItems = new UserControl1[count]; 
            
            for (int i = 0; i < count; i++)
            {

                listItems[i] = new UserControl1();

                string id = Friend_info[i];
                listItems[i].Id = id; 

                byte[] img = Friend.image(Friend_info[i]);
                if (img == null)
                {
                    listItems[i].Icon = Properties.Resources.imoji1;
                }
                else
                {
                    listItems[i].Icon = imageBt.read_imagebyte(img);
                }

                listItems[i].Uname = Friend.Friend_name(id); 


                flowLayoutPanel1.Controls.Add(listItems[i]);
                listItems[i].Cursor = Cursors.Hand;
                listItems[i].Click += new EventHandler(view_detail);
            }
        }

        public void view_detail(object sender, EventArgs e)
        {
            delete_FriendForm Friend_detail = new delete_FriendForm(sender,login_id);
            Friend_detail.ShowDialog();
            flowLayoutPanel1.Controls.Clear();
            createFriendItems();
            createUserItem();
        }

        public void search_friend()
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(UserControl1))
                {
                    UserControl1 targetf = (UserControl1)c;
                    if (!targetf.Uname.Contains(textBoxSearchFriend.Text))
                    {
                        flowLayoutPanel1.Controls.Remove(c);
                    }
                }
            }

            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(UserControl1))
                {
                    UserControl1 targetf = (UserControl1)c;
                    if (!targetf.Uname.Contains(textBoxSearchFriend.Text))
                    {
                        flowLayoutPanel1.Controls.Remove(c);
                    }
                }
            }
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(UserControl1))
                {
                    UserControl1 targetf = (UserControl1)c;
                    if (!targetf.Uname.Contains(textBoxSearchFriend.Text))
                    {
                        flowLayoutPanel1.Controls.Remove(c);
                    }
                }
            }
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(UserControl1))
                {
                    UserControl1 targetf = (UserControl1)c;
                    if (!targetf.Uname.Contains(textBoxSearchFriend.Text))
                    {
                        flowLayoutPanel1.Controls.Remove(c);

                    }
                }
            }
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c.GetType() == typeof(UserControl1))
                {
                    UserControl1 targetf = (UserControl1)c;
                    if (!targetf.Uname.Contains(textBoxSearchFriend.Text))
                    {
                        flowLayoutPanel1.Controls.Remove(c);

                    }
                }
            }

        }
        private void pictureBoxClick_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            createFriendItems();
            search_friend();
        }

        private void button_chat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            chattingList chat = new chattingList();
            chat.ShowDialog();
        }

        private void button_addFriend_Click(object sender, EventArgs e)
        {
            
            add_FriendForm add_FriendForm = new add_FriendForm(login_id);
            add_FriendForm.ShowDialog();
            flowLayoutPanel1.Controls.Clear();
            createFriendItems();
            createUserItem();
        }

        private void FriendList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
