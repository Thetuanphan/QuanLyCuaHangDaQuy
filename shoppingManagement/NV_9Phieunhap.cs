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
    public partial class NV_9Phieunhap : Form
    {
        private double grandTotal = 0;
        private double grandTotalGoc = 0;
        private double itemTotal = 0;
        public NV_9Phieunhap(string user, string pass, string madt, string maph)
        {
            InitializeComponent();
            txtuser.TextName = user;
            txtpass.TextName = pass;
            MaKH.TextName = madt;
            MaHD.TextName = maph;
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

                string sql = "Select * from SANPHAM  order by MaSP";

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

        private void NV_9Phieunhap_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void themsp_Click(object sender, EventArgs e)
        {
            String MaSP = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            String MaVL = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            String MaDT = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            String TenSP = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            String DVT = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            String SLTon = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            String DonGia = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            String DonGiaNhap = Dongianhap.TextName;
            String quantity = SLsanpham.TextName;

            double total = (Double.Parse(DonGiaNhap) * Double.Parse(quantity));

            grandTotal = grandTotal + total;
            grandTotalGoc += total;

            dataGridView2.Rows.Add(MaSP, MaVL, MaDT, TenSP, DVT, DonGiaNhap, quantity, total.ToString());

            label4.Text = grandTotal.ToString();

            string connstr = "Data Source=(DESCRIPTION=" +
            "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" +
            "(CONNECT_DATA =" +
            "(SERVER = DEDICATED)" +
            "(SERVICE_NAME = orcl)" + ")" +
            "); User Id=ttp; Password=123456Az";

            OracleConnection con = new OracleConnection(connstr);
            OracleCommand cmdn = con.CreateCommand();
            cmdn.CommandType = CommandType.Text;

            try
            {

                string sql = "insert into CHITIETNSP (MaSP, MaPH, SoLuongNhap, DonGiaNhap, MaDT) values ('"
                    + MaSP + "', '" + MaHD.TextName + "', " + quantity + ", '" + DonGiaNhap + "', '" + MaDT + "')";
                itemTotal++;
                string sql1 = "update PHIEUNSP SET TongNSP=" + grandTotal + 
                    " where MaPH= '" + MaHD.TextName + "'";

                OracleCommand cmd = new OracleCommand(sql, con);
                OracleCommand cmd1 = new OracleCommand(sql1, con);

                con.Open();

                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                //MessageBox.Show("Đã thêm sản phẩm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
        }

        private void lammoi_Click(object sender, EventArgs e)
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
                //string sql = "DELETE (MaPH) FROM PHIEUNSP Where MaPH=" + "'" + MaHD.TextName + "'";
                string sql1 = "DELETE FROM CHITIETNSP Where MaPH=" + "'" + MaHD.TextName + "'";
                string sql2 = "update PHIEUNSP SET TongNSP=" + grandTotal +
                    " where MaPH= '" + MaHD.TextName + "'";

                //OracleCommand cmd = new OracleCommand(sql, con);
                OracleCommand cmd1 = new OracleCommand(sql1, con);
                OracleCommand cmd2 = new OracleCommand(sql2, con);

                con.Open();

                cmd1.ExecuteNonQuery();
                //cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                //MessageBox.Show("Xóa sản phẩm thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                con.Close();
            }
            this.Hide();
            NV_9Phieunhap f2 = new NV_9Phieunhap(txtuser.TextName, txtpass.TextName, MaKH.TextName, MaHD.TextName);
            f2.ShowDialog();
        }
    }
}
