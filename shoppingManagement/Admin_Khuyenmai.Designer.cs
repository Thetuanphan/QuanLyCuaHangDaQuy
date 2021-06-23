
namespace shoppingManagement
{
    partial class Admin_Khuyenmai
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
            this.TenKM = new JMaterialTextbox.JMaterialTextbox();
            this.MaKM = new JMaterialTextbox.JMaterialTextbox();
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
            this.TraCuu.Location = new System.Drawing.Point(515, 36);
            this.TraCuu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TraCuu.MaxLength = 32767;
            this.TraCuu.Name = "TraCuu";
            this.TraCuu.OnFocusedColor = System.Drawing.Color.Black;
            this.TraCuu.OnFocusedTextColor = System.Drawing.Color.Black;
            this.TraCuu.ReadOnly = false;
            this.TraCuu.Size = new System.Drawing.Size(255, 23);
            this.TraCuu.TabIndex = 113;
            this.TraCuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TraCuu.TextName = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(388, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 19);
            this.label11.TabIndex = 112;
            this.label11.Text = "Nhập từ khóa:";
            // 
            // LoaiTimKiem
            // 
            this.LoaiTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoaiTimKiem.FormattingEnabled = true;
            this.LoaiTimKiem.Items.AddRange(new object[] {
            "TenKM",
            "MaKM"});
            this.LoaiTimKiem.Location = new System.Drawing.Point(286, 36);
            this.LoaiTimKiem.Name = "LoaiTimKiem";
            this.LoaiTimKiem.Size = new System.Drawing.Size(92, 21);
            this.LoaiTimKiem.TabIndex = 111;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(159, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 110;
            this.label6.Text = "Tìm kiếm theo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 19);
            this.label5.TabIndex = 109;
            this.label5.Text = "Bảng khuyến mãi:";
            // 
            // TenKM
            // 
            this.TenKM.BackColor = System.Drawing.Color.Transparent;
            this.TenKM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TenKM.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TenKM.ForeColors = System.Drawing.Color.Black;
            this.TenKM.HintText = null;
            this.TenKM.IsPassword = false;
            this.TenKM.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TenKM.LineThickness = 2;
            this.TenKM.Location = new System.Drawing.Point(163, 217);
            this.TenKM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TenKM.MaxLength = 32767;
            this.TenKM.Name = "TenKM";
            this.TenKM.OnFocusedColor = System.Drawing.Color.Black;
            this.TenKM.OnFocusedTextColor = System.Drawing.Color.Black;
            this.TenKM.ReadOnly = false;
            this.TenKM.Size = new System.Drawing.Size(171, 18);
            this.TenKM.TabIndex = 108;
            this.TenKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TenKM.TextName = "";
            // 
            // MaKM
            // 
            this.MaKM.BackColor = System.Drawing.Color.Transparent;
            this.MaKM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MaKM.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MaKM.ForeColors = System.Drawing.Color.Black;
            this.MaKM.HintText = null;
            this.MaKM.IsPassword = false;
            this.MaKM.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaKM.LineThickness = 2;
            this.MaKM.Location = new System.Drawing.Point(163, 145);
            this.MaKM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaKM.MaxLength = 32767;
            this.MaKM.Name = "MaKM";
            this.MaKM.OnFocusedColor = System.Drawing.Color.Black;
            this.MaKM.OnFocusedTextColor = System.Drawing.Color.Black;
            this.MaKM.ReadOnly = false;
            this.MaKM.Size = new System.Drawing.Size(96, 23);
            this.MaKM.TabIndex = 107;
            this.MaKM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MaKM.TextName = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 19);
            this.label8.TabIndex = 102;
            this.label8.Text = "Tên khuyến mãi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 19);
            this.label3.TabIndex = 100;
            this.label3.Text = "Mã khuyến mãi:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(427, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 503);
            this.dataGridView1.TabIndex = 99;
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
            this.timkiem.Location = new System.Drawing.Point(794, 34);
            this.timkiem.Name = "timkiem";
            this.timkiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.timkiem.OnHoverButtonColor = System.Drawing.Color.White;
            this.timkiem.OnHoverTextColor = System.Drawing.Color.Black;
            this.timkiem.Size = new System.Drawing.Size(117, 36);
            this.timkiem.TabIndex = 114;
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
            this.lammoi.Location = new System.Drawing.Point(925, 34);
            this.lammoi.Name = "lammoi";
            this.lammoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lammoi.OnHoverButtonColor = System.Drawing.Color.Black;
            this.lammoi.OnHoverTextColor = System.Drawing.Color.White;
            this.lammoi.Size = new System.Drawing.Size(79, 39);
            this.lammoi.TabIndex = 106;
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
            this.capnhat.Location = new System.Drawing.Point(114, 348);
            this.capnhat.Name = "capnhat";
            this.capnhat.OnHoverBorderColor = System.Drawing.Color.Black;
            this.capnhat.OnHoverButtonColor = System.Drawing.Color.White;
            this.capnhat.OnHoverTextColor = System.Drawing.Color.Black;
            this.capnhat.Size = new System.Drawing.Size(145, 38);
            this.capnhat.TabIndex = 105;
            this.capnhat.Text = "Cập nhật khuyến mãi";
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
            this.xoa.Location = new System.Drawing.Point(215, 293);
            this.xoa.Name = "xoa";
            this.xoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.xoa.OnHoverButtonColor = System.Drawing.Color.White;
            this.xoa.OnHoverTextColor = System.Drawing.Color.Black;
            this.xoa.Size = new System.Drawing.Size(138, 38);
            this.xoa.TabIndex = 104;
            this.xoa.Text = "Xóa khuyến mãi";
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
            this.them.Location = new System.Drawing.Point(13, 293);
            this.them.Name = "them";
            this.them.OnHoverBorderColor = System.Drawing.Color.Black;
            this.them.OnHoverButtonColor = System.Drawing.Color.White;
            this.them.OnHoverTextColor = System.Drawing.Color.Black;
            this.them.Size = new System.Drawing.Size(138, 38);
            this.them.TabIndex = 103;
            this.them.Text = "Thêm khuyến mãi";
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
            this.quayve.Location = new System.Drawing.Point(21, 25);
            this.quayve.Name = "quayve";
            this.quayve.OnHoverBorderColor = System.Drawing.Color.Black;
            this.quayve.OnHoverButtonColor = System.Drawing.Color.Black;
            this.quayve.OnHoverTextColor = System.Drawing.Color.White;
            this.quayve.Size = new System.Drawing.Size(76, 36);
            this.quayve.TabIndex = 101;
            this.quayve.Text = "<<";
            this.quayve.TextColor = System.Drawing.Color.Black;
            this.quayve.UseVisualStyleBackColor = true;
            this.quayve.Click += new System.EventHandler(this.quayve_Click);
            // 
            // Admin_Khuyenmai
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
            this.Controls.Add(this.TenKM);
            this.Controls.Add(this.MaKM);
            this.Controls.Add(this.lammoi);
            this.Controls.Add(this.capnhat);
            this.Controls.Add(this.xoa);
            this.Controls.Add(this.them);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.quayve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin_Khuyenmai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Khuyến Mãi";
            this.Load += new System.EventHandler(this.Admin_Khuyenmai_Load);
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
        private JMaterialTextbox.JMaterialTextbox TenKM;
        private JMaterialTextbox.JMaterialTextbox MaKM;
        private ePOSOne.btnProduct.Button_WOC lammoi;
        private ePOSOne.btnProduct.Button_WOC capnhat;
        private ePOSOne.btnProduct.Button_WOC xoa;
        private ePOSOne.btnProduct.Button_WOC them;
        private System.Windows.Forms.Label label8;
        private ePOSOne.btnProduct.Button_WOC quayve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}