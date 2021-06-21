using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.IO;

namespace shoppingManagement
{
    public partial class NV_7Doitac : Form
    {
        public NV_7Doitac(string user, string pass)
        {
            InitializeComponent();
            usertxt.TextName = user;
            passtxt.TextName = pass;
        }

        public void connection()
        {
            string connstr = "Data Source=(DESCRIPTION=" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = orcl)" + ")" +
            "); User Id=ttp; Password=123456Az";

            OracleConnection con = new OracleConnection(connstr);
            try
            {

                string sql = "Select * from DOITAC  order by MaDT";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NV_7Doitac_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            MaDT.TextName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            TenDT.TextName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            DiaChi.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            sdt.TextName = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            GhiChu.TextName = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV_7Doitac f2 = new NV_7Doitac(usertxt.TextName, passtxt.TextName);
            f2.ShowDialog();
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            string connstr = "Data Source=(DESCRIPTION=" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = orcl)" + ")" +
            "); User Id=ttp; Password=123456Az";

            OracleConnection con = new OracleConnection(connstr);
            try
            {

                string sql = "Select * from DOITAC where MaDT=UPPER('" + TraCuu.TextName + "') order by MaDT";
                string sql1 = "Select * from DOITAC where TenCTY=UPPER('" + TraCuu.TextName + "') order by MaDT";
                string sql2 = "Select * from DOITAC where SDT=UPPER('" + TraCuu.TextName + "') order by MaDT";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
                OracleDataAdapter adapter1 = new OracleDataAdapter(sql1, con);
                OracleDataAdapter adapter2 = new OracleDataAdapter(sql2, con);

                if (LoaiTimKiem.Text == "MaDT")
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    if (LoaiTimKiem.Text == "TenCTY")
                    {
                        DataTable dt1 = new DataTable();
                        adapter1.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                    }
                    else
                    {
                        if (LoaiTimKiem.Text == "SDT")
                        {
                            DataTable dt2 = new DataTable();
                            adapter2.Fill(dt2);
                            dataGridView1.DataSource = dt2;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tieptuc_Click(object sender, EventArgs e)
        {
            if (MaDT.TextName == null)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng", "Chưa chọn khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            else
            {
                this.Hide();
                NV_8Maphieunhap f3 = new NV_8Maphieunhap(usertxt.TextName, passtxt.TextName, MaDT.TextName);
                f3.ShowDialog();
            }
        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV_Menu f3 = new NV_Menu(usertxt.TextName, passtxt.TextName);
            f3.ShowDialog();
        }
    }
}
