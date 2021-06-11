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

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void qlsanpham_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Sanpham f2 = new Admin_Sanpham();
            f2.ShowDialog();
        }

        private void qlvatlieu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Vatlieu f3 = new Admin_Vatlieu();
            f3.ShowDialog();
        }

        private void qldichvu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Dichvu f5 = new Admin_Dichvu();
            f5.ShowDialog();
        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Admin f5 = new Login_Admin();
            f5.ShowDialog();
        }

        private void qlkhuyenmai_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Khuyenmai f8 = new Admin_Khuyenmai();
            f8.ShowDialog();
        }

        private void qlnhanvien_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Nhanvien f1 = new Admin_Nhanvien();
            f1.ShowDialog();
        }

        private void qldoitac_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Doitac f4 = new Admin_Doitac();
            f4.ShowDialog();
        }
    }
}
