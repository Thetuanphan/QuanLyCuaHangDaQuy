﻿using System;
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
    public partial class NV_6_1Taophieudv : Form
    {
        public NV_6_1Taophieudv(string user, string pass, string makh, string mapdv)
        {
            InitializeComponent();
            txtuser.TextName = user;
            txtpass.TextName = pass;
            MaKH.TextName = makh;
            MaHD.TextName = mapdv;
        }

        private void NV_6_1Taophieudv_Load(object sender, EventArgs e)
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
                // string m = cthang.Text;

                Phieudichvu sr1 = new Phieudichvu();

                string sql1 = "Select * from PHIEUDV where MaPDV = '" + MaHD.TextName + "'";

                DataSet s2 = new DataSet();

                OracleDataAdapter adapter2 = new OracleDataAdapter(sql1, con);

                adapter2.Fill(s2, "PHIEUDV");
                DataTable dt = s2.Tables["PHIEUDV"];
                sr1.SetDataSource(s2.Tables["PHIEUDV"]);
                crystalReportViewer1.ReportSource = sr1;
                crystalReportViewer1.Refresh();

                /*
                Phieudichvu sr1 = new Phieudichvu();
                sr1.SetDataSource(s1.Tables["table1"]);
                sr1.SetDataSource(s1.DataSet);
                crystalReportViewer2.ReportSource = sr1;
                crystalReportViewer2.Refresh(); */
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

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            NV_6Dichvu f2 = new NV_6Dichvu(txtuser.TextName, txtpass.TextName, MaKH.TextName, MaHD.TextName);
            f2.ShowDialog();
        }
    }
}
