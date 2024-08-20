namespace _2212427_DangDangNguyen_BaiThucHanhWindownsForm
{
    partial class frmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblDSHH = new System.Windows.Forms.Label();
            this.listHH = new System.Windows.Forms.ListBox();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.lbMHDM = new System.Windows.Forms.Label();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.listHKDM = new System.Windows.Forms.ListBox();
            this.lbTongThanhToan = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.listHH);
            this.panel1.Controls.Add(this.lblDSHH);
            this.panel1.Location = new System.Drawing.Point(31, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 252);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.listHKDM);
            this.panel2.Controls.Add(this.btnBoHang);
            this.panel2.Controls.Add(this.lbSoTien);
            this.panel2.Controls.Add(this.lbTongThanhToan);
            this.panel2.Controls.Add(this.lbMHDM);
            this.panel2.Location = new System.Drawing.Point(410, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(378, 252);
            this.panel2.TabIndex = 1;
            // 
            // lblDSHH
            // 
            this.lblDSHH.AutoSize = true;
            this.lblDSHH.Location = new System.Drawing.Point(96, 14);
            this.lblDSHH.Name = "lblDSHH";
            this.lblDSHH.Size = new System.Drawing.Size(110, 13);
            this.lblDSHH.TabIndex = 0;
            this.lblDSHH.Text = "Danh sách hàng hóa:";
            this.lblDSHH.Click += new System.EventHandler(this.lblDSHH_Click);
            // 
            // listHH
            // 
            this.listHH.FormattingEnabled = true;
            this.listHH.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
            this.listHH.Location = new System.Drawing.Point(61, 30);
            this.listHH.Name = "listHH";
            this.listHH.Size = new System.Drawing.Size(188, 108);
            this.listHH.TabIndex = 1;
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(255, 52);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(86, 23);
            this.btnChonHang.TabIndex = 2;
            this.btnChonHang.Text = "Chọn hàng >";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // lbMHDM
            // 
            this.lbMHDM.AutoSize = true;
            this.lbMHDM.Location = new System.Drawing.Point(152, 14);
            this.lbMHDM.Name = "lbMHDM";
            this.lbMHDM.Size = new System.Drawing.Size(132, 13);
            this.lbMHDM.TabIndex = 0;
            this.lbMHDM.Text = "Các mặt hàng khách mua:";
            this.lbMHDM.Click += new System.EventHandler(this.lbMHDM_Click);
            // 
            // btnBoHang
            // 
            this.btnBoHang.Location = new System.Drawing.Point(37, 52);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(86, 23);
            this.btnBoHang.TabIndex = 2;
            this.btnBoHang.Text = "< Bỏ hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhTien.Location = new System.Drawing.Point(168, 144);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(106, 30);
            this.btnTinhTien.TabIndex = 2;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // listHKDM
            // 
            this.listHKDM.FormattingEnabled = true;
            this.listHKDM.Location = new System.Drawing.Point(129, 30);
            this.listHKDM.Name = "listHKDM";
            this.listHKDM.Size = new System.Drawing.Size(188, 108);
            this.listHKDM.TabIndex = 1;
            // 
            // lbTongThanhToan
            // 
            this.lbTongThanhToan.AutoSize = true;
            this.lbTongThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongThanhToan.Location = new System.Drawing.Point(18, 205);
            this.lbTongThanhToan.Name = "lbTongThanhToan";
            this.lbTongThanhToan.Size = new System.Drawing.Size(197, 25);
            this.lbTongThanhToan.TabIndex = 0;
            this.lbTongThanhToan.Text = "Tổng tiền thanh toán:";
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoTien.Location = new System.Drawing.Point(221, 205);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(22, 25);
            this.lbSoTien.TabIndex = 0;
            this.lbSoTien.Text = "..";
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 252);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán Hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listHH;
        private System.Windows.Forms.Label lblDSHH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.ListBox listHKDM;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.Label lbMHDM;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbTongThanhToan;
    }
}