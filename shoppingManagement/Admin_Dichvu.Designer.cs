﻿
namespace shoppingManagement
{
    partial class Admin_Dichvu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TraCuu = new JMaterialTextbox.JMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.LoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DonGia = new JMaterialTextbox.JMaterialTextbox();
            this.TenDV = new JMaterialTextbox.JMaterialTextbox();
            this.MaDV = new JMaterialTextbox.JMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timkiem = new ePOSOne.btnProduct.Button_WOC();
            this.lammoi = new ePOSOne.btnProduct.Button_WOC();
            this.capnhat = new ePOSOne.btnProduct.Button_WOC();
            this.xoa = new ePOSOne.btnProduct.Button_WOC();
            this.them = new ePOSOne.btnProduct.Button_WOC();
            this.quayve = new ePOSOne.btnProduct.Button_WOC();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TraCuu
            // 
            this.TraCuu.BackColor = System.Drawing.Color.Transparent;
            this.TraCuu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TraCuu.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TraCuu.ForeColors = System.Drawing.Color.Black;
            this.TraCuu.HintText = null;
            this.TraCuu.IsPassword = false;
            this.TraCuu.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TraCuu.LineThickness = 2;
            this.TraCuu.Location = new System.Drawing.Point(515, 38);
            this.TraCuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TraCuu.MaxLength = 32767;
            this.TraCuu.Name = "TraCuu";
            this.TraCuu.OnFocusedColor = System.Drawing.Color.Black;
            this.TraCuu.OnFocusedTextColor = System.Drawing.Color.Black;
            this.TraCuu.ReadOnly = false;
            this.TraCuu.Size = new System.Drawing.Size(255, 23);
            this.TraCuu.TabIndex = 97;
            this.TraCuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TraCuu.TextName = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 19);
            this.label11.TabIndex = 96;
            this.label11.Text = "Nhập từ khóa:";
            // 
            // LoaiTimKiem
            // 
            this.LoaiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoaiTimKiem.FormattingEnabled = true;
            this.LoaiTimKiem.Items.AddRange(new object[] {
            "TenDV",
            "MaDV"});
            this.LoaiTimKiem.Location = new System.Drawing.Point(286, 38);
            this.LoaiTimKiem.Name = "LoaiTimKiem";
            this.LoaiTimKiem.Size = new System.Drawing.Size(92, 21);
            this.LoaiTimKiem.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 94;
            this.label6.Text = "Tìm kiếm theo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 93;
            this.label5.Text = "Bảng sản phẩm:";
            // 
            // DonGia
            // 
            this.DonGia.BackColor = System.Drawing.Color.Transparent;
            this.DonGia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DonGia.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DonGia.ForeColors = System.Drawing.Color.Black;
            this.DonGia.HintText = null;
            this.DonGia.IsPassword = false;
            this.DonGia.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DonGia.LineThickness = 2;
            this.DonGia.Location = new System.Drawing.Point(163, 243);
            this.DonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DonGia.MaxLength = 32767;
            this.DonGia.Name = "DonGia";
            this.DonGia.OnFocusedColor = System.Drawing.Color.Black;
            this.DonGia.OnFocusedTextColor = System.Drawing.Color.Black;
            this.DonGia.ReadOnly = false;
            this.DonGia.Size = new System.Drawing.Size(171, 18);
            this.DonGia.TabIndex = 88;
            this.DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DonGia.TextName = "";
            // 
            // TenDV
            // 
            this.TenDV.BackColor = System.Drawing.Color.Transparent;
            this.TenDV.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TenDV.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TenDV.ForeColors = System.Drawing.Color.Black;
            this.TenDV.HintText = null;
            this.TenDV.IsPassword = false;
            this.TenDV.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TenDV.LineThickness = 2;
            this.TenDV.Location = new System.Drawing.Point(163, 182);
            this.TenDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TenDV.MaxLength = 32767;
            this.TenDV.Name = "TenDV";
            this.TenDV.OnFocusedColor = System.Drawing.Color.Black;
            this.TenDV.OnFocusedTextColor = System.Drawing.Color.Black;
            this.TenDV.ReadOnly = false;
            this.TenDV.Size = new System.Drawing.Size(171, 18);
            this.TenDV.TabIndex = 87;
            this.TenDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TenDV.TextName = "";
            // 
            // MaDV
            // 
            this.MaDV.BackColor = System.Drawing.Color.Transparent;
            this.MaDV.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MaDV.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MaDV.ForeColors = System.Drawing.Color.Black;
            this.MaDV.HintText = null;
            this.MaDV.IsPassword = false;
            this.MaDV.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaDV.LineThickness = 2;
            this.MaDV.Location = new System.Drawing.Point(163, 124);
            this.MaDV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaDV.MaxLength = 32767;
            this.MaDV.Name = "MaDV";
            this.MaDV.OnFocusedColor = System.Drawing.Color.Black;
            this.MaDV.OnFocusedTextColor = System.Drawing.Color.Black;
            this.MaDV.ReadOnly = false;
            this.MaDV.Size = new System.Drawing.Size(96, 23);
            this.MaDV.TabIndex = 85;
            this.MaDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaDV.TextName = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(24, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 77;
            this.label9.Text = "Đơn giá:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 76;
            this.label8.Text = "Tên dịch vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 73;
            this.label3.Text = "Mã dịch vụ:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 503);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // timkiem
            // 
            this.timkiem.BackColor = System.Drawing.Color.White;
            this.timkiem.BorderColor = System.Drawing.Color.Black;
            this.timkiem.ButtonColor = System.Drawing.Color.Black;
            this.timkiem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.timkiem.FlatAppearance.BorderSize = 0;
            this.timkiem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.timkiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timkiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.Location = new System.Drawing.Point(794, 36);
            this.timkiem.Name = "timkiem";
            this.timkiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.timkiem.OnHoverButtonColor = System.Drawing.Color.White;
            this.timkiem.OnHoverTextColor = System.Drawing.Color.Black;
            this.timkiem.Size = new System.Drawing.Size(117, 36);
            this.timkiem.TabIndex = 98;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timkiem.UseVisualStyleBackColor = false;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // lammoi
            // 
            this.lammoi.BorderColor = System.Drawing.Color.Black;
            this.lammoi.ButtonColor = System.Drawing.Color.White;
            this.lammoi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lammoi.FlatAppearance.BorderSize = 0;
            this.lammoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lammoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lammoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lammoi.Location = new System.Drawing.Point(925, 36);
            this.lammoi.Name = "lammoi";
            this.lammoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lammoi.OnHoverButtonColor = System.Drawing.Color.Black;
            this.lammoi.OnHoverTextColor = System.Drawing.Color.White;
            this.lammoi.Size = new System.Drawing.Size(79, 39);
            this.lammoi.TabIndex = 83;
            this.lammoi.Text = "Làm mới";
            this.lammoi.TextColor = System.Drawing.Color.Black;
            this.lammoi.UseVisualStyleBackColor = true;
            this.lammoi.Click += new System.EventHandler(this.lammoi_Click);
            // 
            // capnhat
            // 
            this.capnhat.BorderColor = System.Drawing.Color.Black;
            this.capnhat.ButtonColor = System.Drawing.Color.Black;
            this.capnhat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.capnhat.FlatAppearance.BorderSize = 0;
            this.capnhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.capnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.capnhat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capnhat.Location = new System.Drawing.Point(114, 366);
            this.capnhat.Name = "capnhat";
            this.capnhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.capnhat.OnHoverButtonColor = System.Drawing.Color.White;
            this.capnhat.OnHoverTextColor = System.Drawing.Color.Black;
            this.capnhat.Size = new System.Drawing.Size(145, 38);
            this.capnhat.TabIndex = 81;
            this.capnhat.Text = "Cập nhật dịch vụ";
            this.capnhat.TextColor = System.Drawing.Color.White;
            this.capnhat.UseVisualStyleBackColor = true;
            this.capnhat.Click += new System.EventHandler(this.capnhat_Click);
            // 
            // xoa
            // 
            this.xoa.BorderColor = System.Drawing.Color.Black;
            this.xoa.ButtonColor = System.Drawing.Color.Black;
            this.xoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.xoa.FlatAppearance.BorderSize = 0;
            this.xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoa.Location = new System.Drawing.Point(215, 311);
            this.xoa.Name = "xoa";
            this.xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.xoa.OnHoverButtonColor = System.Drawing.Color.White;
            this.xoa.OnHoverTextColor = System.Drawing.Color.Black;
            this.xoa.Size = new System.Drawing.Size(138, 38);
            this.xoa.TabIndex = 80;
            this.xoa.Text = "Xóa dịch vụ";
            this.xoa.TextColor = System.Drawing.Color.White;
            this.xoa.UseVisualStyleBackColor = true;
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // them
            // 
            this.them.BorderColor = System.Drawing.Color.Black;
            this.them.ButtonColor = System.Drawing.Color.Black;
            this.them.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.them.FlatAppearance.BorderSize = 0;
            this.them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.them.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.them.Location = new System.Drawing.Point(13, 311);
            this.them.Name = "them";
            this.them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.them.OnHoverButtonColor = System.Drawing.Color.White;
            this.them.OnHoverTextColor = System.Drawing.Color.Black;
            this.them.Size = new System.Drawing.Size(138, 38);
            this.them.TabIndex = 79;
            this.them.Text = "Thêm dịch vụ";
            this.them.TextColor = System.Drawing.Color.White;
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // quayve
            // 
            this.quayve.BorderColor = System.Drawing.Color.Black;
            this.quayve.ButtonColor = System.Drawing.Color.White;
            this.quayve.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.quayve.FlatAppearance.BorderSize = 0;
            this.quayve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.quayve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quayve.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quayve.Location = new System.Drawing.Point(21, 27);
            this.quayve.Name = "quayve";
            this.quayve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.quayve.OnHoverButtonColor = System.Drawing.Color.Black;
            this.quayve.OnHoverTextColor = System.Drawing.Color.White;
            this.quayve.Size = new System.Drawing.Size(76, 36);
            this.quayve.TabIndex = 74;
            this.quayve.Text = "<<";
            this.quayve.TextColor = System.Drawing.Color.Black;
            this.quayve.UseVisualStyleBackColor = true;
            this.quayve.Click += new System.EventHandler(this.quayve_Click);
            // 
            // Admin_Dichvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 632);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.TraCuu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.LoaiTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DonGia);
            this.Controls.Add(this.TenDV);
            this.Controls.Add(this.MaDV);
            this.Controls.Add(this.lammoi);
            this.Controls.Add(this.capnhat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quayve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_Dichvu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dịch Vụ";
            this.Load += new System.EventHandler(this.Admin_Dichvu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC timkiem;
        private JMaterialTextbox.JMaterialTextbox TraCuu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox LoaiTimKiem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private JMaterialTextbox.JMaterialTextbox DonGia;
        private JMaterialTextbox.JMaterialTextbox TenDV;
        private JMaterialTextbox.JMaterialTextbox MaDV;
        private ePOSOne.btnProduct.Button_WOC lammoi;
        private ePOSOne.btnProduct.Button_WOC capnhat;
        private ePOSOne.btnProduct.Button_WOC xoa;
        private ePOSOne.btnProduct.Button_WOC them;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private ePOSOne.btnProduct.Button_WOC quayve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}