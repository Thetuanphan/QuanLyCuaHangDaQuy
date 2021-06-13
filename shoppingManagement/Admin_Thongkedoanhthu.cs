﻿using System;
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
    public partial class Admin_Thongkedoanhthu : Form
    {
        public Admin_Thongkedoanhthu()
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
                string m = cthang.Text;

                string sql = "Select * from HOADON where to_char(thoigianlap, 'mm') = " + Int32.Parse(m);

                OracleDataAdapter adapter1 = new OracleDataAdapter(sql, con);


                DataSet s = new DataSet();
                adapter1.Fill(s);

                baocaothang sr = new baocaothang();
                sr.SetDataSource(s.Tables["table"]);
                crystalReportViewer2.ReportSource = sr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
