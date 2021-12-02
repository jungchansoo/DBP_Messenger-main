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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        #region Properties
        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private string _id;
        private string _name;
        private Image _icon;
        [Category("Custom Props")]

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }
        }
        [Category("Custom Props")]
        public string Uname
        {
            get { return _name; }
            set { _name = value; lblName.Text = value; }
        }

        [Category("Custom Props")]


        public Image Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                roundPictureBox1.Image = value;
            }
        }
        #endregion
    }
}
