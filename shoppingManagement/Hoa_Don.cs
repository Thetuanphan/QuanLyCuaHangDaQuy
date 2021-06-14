using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.IO;

namespace shoppingManagement
{
    public partial class Hoa_Don : Form
    {
        public Hoa_Don()
        {
            InitializeComponent();
        }

        private void lapbc_Click(object sender, EventArgs e)
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
                string m = choadon.Text;

                string sql = "Select * from HOADON join CTHD using (MaHD) join SANPHAM using (MaSP) " +
                    "join NGUYENVATLIEU using (MaVL) where MaHD = 'HD10'";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);

                DataSet s1 = new DataSet();
                adapter.Fill(s1);

                CrystalReport1 sr = new CrystalReport1();
                sr.SetDataSource(s1.Tables["table1"]);
                MessageBox.Show(sr.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                crystalReportViewer2.ReportSource = sr;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
