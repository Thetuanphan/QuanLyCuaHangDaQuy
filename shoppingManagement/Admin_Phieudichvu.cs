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
    public partial class Admin_Phieudichvu : Form
    {
        public Admin_Phieudichvu()
        {
            InitializeComponent();
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

                string sql = "Select * from PHIEUDV  order by MaPDV";

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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Phieudichvu_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void quayve_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Menu f4 = new Admin_Menu();
            f4.ShowDialog();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtmaphieu.TextName = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtmanv.TextName = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtmakh.TextName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dLap.TextName = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtsldv.TextName = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txttongtien.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtthanhtoantruoc.TextName = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtconlai.TextName = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txttinhtrang.TextName = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
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

                string sql = "INSERT INTO PHIEUDV (MaNV, MaQL, TenNV, ChucVu, NgaySinh, GioiTinh, DiaChi, SDT, NgayVaoLam) values " +
                    "(" + "'" + MaNV.TextName + "','" + MaQL.TextName + "','" + TenNV.TextName + "','" + ChucVu.TextName + "', TO_DATE('" + dSinh.TextName + "','dd/mm/yyyy hh:mi:ss AM'),'" + GioiTinh.Text + "','" + DiaChi.TextName + "'," + Int32.Parse(sdt.TextName) + "," + " TO_DATE('" + dVaoLam.TextName + "','dd/mm/yyyy hh:mi:ss AM')" + ")";
                OracleCommand cmd = new OracleCommand(sql, con);

                con.Open();

                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm phiếu thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OracleDataAdapter adapter = new OracleDataAdapter("select * from PHIEUDV order by MaPDV", con);
                DataTable dt = new DataTable();

                adapter.Fill(dt);


                dataGridView1.DataSource = dt;
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

        private void xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    string sql = "DELETE FROM NHANVIEN Where MaNV=" + "'" + MaNV.TextName + "'";
                    OracleCommand cmd = new OracleCommand(sql, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa nhân viên thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OracleDataAdapter adapter = new OracleDataAdapter("select * from NHANVIEN order by MaNV", con);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);


                    dataGridView1.DataSource = dt;
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

            else
            {
                MessageBox.Show("Dữ liệu chưa được xóa", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void capnhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn cập nhật?", "Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    string sql = "update NHANVIEN" +
                         " SET " + "MaQL= '" + MaQL.Text + "', TenNV='" + TenNV.TextName + "', ChucVu='" + ChucVu.TextName + "', NgaySinh=" + "TO_DATE('" + dSinh.TextName + "', 'dd/mm/yyyy hh:mi:ss AM')" + ", GioiTinh='" + GioiTinh.Text + "', DiaChi='" + DiaChi.TextName + "', SDT=" + sdt.TextName + ", NgayVaoLam= " + "TO_DATE('" + dVaoLam.TextName + "', 'dd/mm/yyyy hh:mi:ss AM')" +
                        " where MaNV ='" + MaNV.TextName + "'";

                    /* string sql = "update NHANVIEN SET NgaySinh=" + "TO_DATE('" + dSinh.TextName + "','dd-mm-yyy')" + "where MaNV='" + MaNV.TextName + "'"; */
                    OracleCommand cmd = new OracleCommand(sql, con);

                    con.Open();

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật nhân viên thành công!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OracleDataAdapter adapter = new OracleDataAdapter("select * from NHANVIEN order by MaNV", con);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);


                    dataGridView1.DataSource = dt;
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

            else
            {
                MessageBox.Show("Dữ liệu chưa được cập nhật", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lammoi_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Phieudichvu f2 = new Admin_Phieudichvu();
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

                string sql = "Select * from NHANVIEN where MaNV='" + TraCuu.TextName + "' order by MaNV";
                string sql1 = "Select * from NHANVIEN where MaQL='" + TraCuu.TextName + "' order by MaNV";
                string sql2 = "Select * from NHANVIEN where TenNV='" + TraCuu.TextName + "' order by MaNV";

                OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
                OracleDataAdapter adapter1 = new OracleDataAdapter(sql1, con);
                OracleDataAdapter adapter2 = new OracleDataAdapter(sql2, con);

                if (LoaiTimKiem.Text == "MaNV")
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    if (LoaiTimKiem.Text == "MaQL")
                    {
                        DataTable dt1 = new DataTable();
                        adapter1.Fill(dt1);
                        dataGridView1.DataSource = dt1;
                    }
                    else
                    {
                        if (LoaiTimKiem.Text == "TenNV")
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
    }
}
