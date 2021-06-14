
namespace shoppingManagement
{
    partial class Admin_Thongkedoanhthu
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
            this.lapbc = new ePOSOne.btnProduct.Button_WOC();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.cthang = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lapbc
            // 
            this.lapbc.BorderColor = System.Drawing.Color.Black;
            this.lapbc.ButtonColor = System.Drawing.Color.White;
            this.lapbc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lapbc.FlatAppearance.BorderSize = 0;
            this.lapbc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.lapbc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lapbc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lapbc.Location = new System.Drawing.Point(39, 190);
            this.lapbc.Name = "lapbc";
            this.lapbc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lapbc.OnHoverButtonColor = System.Drawing.Color.Black;
            this.lapbc.OnHoverTextColor = System.Drawing.Color.White;
            this.lapbc.Size = new System.Drawing.Size(166, 39);
            this.lapbc.TabIndex = 84;
            this.lapbc.Text = "Lập báo cáo";
            this.lapbc.TextColor = System.Drawing.Color.Black;
            this.lapbc.UseVisualStyleBackColor = true;
            this.lapbc.Click += new System.EventHandler(this.lapbc_Click);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(225, 12);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(780, 608);
            this.crystalReportViewer2.TabIndex = 85;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // cthang
            // 
            this.cthang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cthang.FormattingEnabled = true;
            this.cthang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cthang.Location = new System.Drawing.Point(39, 136);
            this.cthang.Name = "cthang";
            this.cthang.Size = new System.Drawing.Size(166, 21);
            this.cthang.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 87;
            this.label3.Text = "Chọn tháng báo cáo:";
            // 
            // Admin_Thongkedoanhthu
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 632);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cthang);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.lapbc);
            this.Name = "Admin_Thongkedoanhthu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC lapbaocao;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private baocaothang crystalReport11;
        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.Label label4;
        private ePOSOne.btnProduct.Button_WOC lapbc;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private System.Windows.Forms.ComboBox cthang;
        private System.Windows.Forms.Label label3;
    }
}