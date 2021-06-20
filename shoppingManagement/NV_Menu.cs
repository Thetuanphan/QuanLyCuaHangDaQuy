using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingManagement
{
    public partial class NV_Menu : Form
    {
        public NV_Menu(string user, string pass)
        {
            InitializeComponent();
            usertxt.TextName = user;
            passtxt.TextName = pass;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV_1Khachhang f2 = new NV_1Khachhang(usertxt.TextName, passtxt.TextName);
            f2.ShowDialog();
        }

        private void nhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV_4Khachhang f2 = new NV_4Khachhang(usertxt.TextName, passtxt.TextName);
            f2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
