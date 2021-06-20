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
    public partial class NV_6Dichvu : Form
    {
        private double grandTotal = 0;
        public NV_6Dichvu(string user, string pass, string makh, string mapdv)
        {
            InitializeComponent();
            txtuser.TextName = user;
            txtpass.TextName = pass;
            MaKH.TextName = makh;
            MaPDV.TextName = mapdv;
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

                //string sql = "Select * from SANPHAM  order by MaSP";
                string sql1 = "select * from DICHVU order by MaDV";

                //OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
                OracleDataAdapter adapter1 = new OracleDataAdapter(sql1, con);

                DataTable dt = new DataTable();
                adapter1.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NV_6Dichvu_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void themsp_Click(object sender, EventArgs e)
        {
            String MaDV = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            String TenDV = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            String TienDV = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

            String SLDV = SLsanpham.TextName;
            String NgayGiao = txtngaygiao.TextName;
            String TinhTrang = txttinhtrang.TextName;
            

            String quantity = SLsanpham.TextName;

            double total = (Double.Parse(TienDV) * Double.Parse(quantity));

            grandTotal = grandTotal + total;

            dataGridView2.Rows.Add(MaDV, TenDV, TienDV, quantity, total.ToString(), NgayGiao, TinhTrang);

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
                string date = DateTime.UtcNow.ToString("dd-MM-yyyy");
                string sql = "insert into chitietdv (MaDV, MaPDV, MaNV, NgayLap, SoLuongDV, NgayGiao, DonGiaDuocTinh, ThanhTien, TinhTrang) values ('"
                    + MaDV + "', '" + MaPDV.TextName + "', '" + txtuser.TextName + "', TO_DATE('" + date + "','dd/mm/yyyy'), " + quantity + ", TO_DATE('" + txtngaygiao.TextName + "','dd/mm/yyyy'), " + txtdongia.TextName + ", " + total + ", '" + txttinhtrang.TextName + "')";
                OracleCommand cmd = new OracleCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();
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
                //string sql = "DELETE (MaKM) FROM HOADON Where MaHD=" + "'" + MaHD.TextName + "'";
                string sql1 = "DELETE FROM chitietdv Where MaPDV=" + "'" + MaPDV.TextName + "'";
                //OracleCommand cmd = new OracleCommand(sql, con);
                OracleCommand cmd1 = new OracleCommand(sql1, con);

                con.Open();

                cmd1.ExecuteNonQuery();
                //cmd.ExecuteNonQuery();
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
            NV_6Dichvu f2 = new NV_6Dichvu(txtuser.TextName, txtpass.TextName, MaKH.TextName, MaPDV.TextName);
            f2.ShowDialog();
        }
    }
}
