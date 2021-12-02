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
    public partial class delete_FriendForm : Form
    {
        public string login_id { get; set; }
        string Friend_ID;

        public delete_FriendForm(object sender, string login_id)
        {
            InitializeComponent();
            UserControl1 user = sender as UserControl1;
            pictureBox_image.Image = user.Icon;
            label_ID.Text = user.Id;
            label_Name.Text = user.Uname;
            this.login_id = login_id;
            Friend_ID = user.Id;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Friend.Friend_delete(login_id, Friend_ID);
            MessageBox.Show("친구가 삭제 되었습니다.");
            this.Close();
        }
    }
}
