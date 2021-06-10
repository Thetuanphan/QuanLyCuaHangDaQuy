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
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Sanpham f5 = new Admin_Sanpham();
            f5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.ShowDialog();
        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
