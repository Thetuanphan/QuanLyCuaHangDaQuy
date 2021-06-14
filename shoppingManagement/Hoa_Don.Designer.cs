
namespace shoppingManagement
{
    partial class Hoa_Don
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
            this.label3 = new System.Windows.Forms.Label();
            this.choadon = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lapbc = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 91;
            this.label3.Text = "Chọn mã HD:";
            // 
            // choadon
            // 
            this.choadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choadon.FormattingEnabled = true;
            this.choadon.Items.AddRange(new object[] {
            "HD1",
            "HD2",
            "HD3",
            "HD4",
            "HD5",
            "HD6",
            "HD7",
            "HD8",
            "HD9",
            "HD10",
            "HD11"});
            this.choadon.Location = new System.Drawing.Point(27, 136);
            this.choadon.Name = "choadon";
            this.choadon.Size = new System.Drawing.Size(166, 21);
            this.choadon.TabIndex = 90;
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer2.Location = new System.Drawing.Point(213, 12);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.Size = new System.Drawing.Size(780, 608);
            this.crystalReportViewer2.TabIndex = 89;
            this.crystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.lapbc.Location = new System.Drawing.Point(27, 190);
            this.lapbc.Name = "lapbc";
            this.lapbc.OnHoverBorderColor = System.Drawing.Color.Black;
            this.lapbc.OnHoverButtonColor = System.Drawing.Color.Black;
            this.lapbc.OnHoverTextColor = System.Drawing.Color.White;
            this.lapbc.Size = new System.Drawing.Size(166, 39);
            this.lapbc.TabIndex = 88;
            this.lapbc.Text = "Xem hóa đơn";
            this.lapbc.TextColor = System.Drawing.Color.Black;
            this.lapbc.UseVisualStyleBackColor = true;
            this.lapbc.Click += new System.EventHandler(this.lapbc_Click);
            // 
            // Hoa_Don
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1017, 632);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.choadon);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.lapbc);
            this.Name = "Hoa_Don";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoa_Don";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox choadon;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private ePOSOne.btnProduct.Button_WOC lapbc;
    }
}