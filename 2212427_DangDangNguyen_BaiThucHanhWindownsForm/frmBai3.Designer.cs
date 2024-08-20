namespace _2212427_DangDangNguyen_BaiThucHanhWindownsForm
{
    partial class frmBai3
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
            this.lbTuMoi = new System.Windows.Forms.Label();
            this.lbNghiaCuaTu = new System.Windows.Forms.Label();
            this.txtTuMoi = new System.Windows.Forms.TextBox();
            this.txtNghiaCuaTu = new System.Windows.Forms.TextBox();
            this.btnThemTuMoi = new System.Windows.Forms.Button();
            this.listDSTM = new System.Windows.Forms.ListBox();
            this.lbDanhSachTuMoi = new System.Windows.Forms.Label();
            this.lbDanhSachNghiaTu = new System.Windows.Forms.Label();
            this.txtHienThiNghiaTu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbTuMoi
            // 
            this.lbTuMoi.AutoSize = true;
            this.lbTuMoi.Location = new System.Drawing.Point(86, 55);
            this.lbTuMoi.Name = "lbTuMoi";
            this.lbTuMoi.Size = new System.Drawing.Size(39, 13);
            this.lbTuMoi.TabIndex = 0;
            this.lbTuMoi.Text = "Từ mới";
            this.lbTuMoi.Click += new System.EventHandler(this.lbTuMoi_Click);
            // 
            // lbNghiaCuaTu
            // 
            this.lbNghiaCuaTu.AutoSize = true;
            this.lbNghiaCuaTu.Location = new System.Drawing.Point(86, 101);
            this.lbNghiaCuaTu.Name = "lbNghiaCuaTu";
            this.lbNghiaCuaTu.Size = new System.Drawing.Size(71, 13);
            this.lbNghiaCuaTu.TabIndex = 1;
            this.lbNghiaCuaTu.Text = "Nghĩa của từ";
            // 
            // txtTuMoi
            // 
            this.txtTuMoi.Location = new System.Drawing.Point(193, 52);
            this.txtTuMoi.Name = "txtTuMoi";
            this.txtTuMoi.Size = new System.Drawing.Size(100, 20);
            this.txtTuMoi.TabIndex = 0;
            // 
            // txtNghiaCuaTu
            // 
            this.txtNghiaCuaTu.Location = new System.Drawing.Point(193, 94);
            this.txtNghiaCuaTu.Name = "txtNghiaCuaTu";
            this.txtNghiaCuaTu.Size = new System.Drawing.Size(100, 20);
            this.txtNghiaCuaTu.TabIndex = 1;
            // 
            // btnThemTuMoi
            // 
            this.btnThemTuMoi.Location = new System.Drawing.Point(206, 132);
            this.btnThemTuMoi.Name = "btnThemTuMoi";
            this.btnThemTuMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemTuMoi.TabIndex = 2;
            this.btnThemTuMoi.Text = "Thêm từ mới";
            this.btnThemTuMoi.UseVisualStyleBackColor = true;
            this.btnThemTuMoi.Click += new System.EventHandler(this.btnThemTuMoi_Click);
            // 
            // listDSTM
            // 
            this.listDSTM.FormattingEnabled = true;
            this.listDSTM.Location = new System.Drawing.Point(124, 227);
            this.listDSTM.Name = "listDSTM";
            this.listDSTM.Size = new System.Drawing.Size(120, 95);
            this.listDSTM.TabIndex = 4;
            this.listDSTM.SelectedIndexChanged += new System.EventHandler(this.listDSTM_SelectedIndexChanged);
            // 
            // lbDanhSachTuMoi
            // 
            this.lbDanhSachTuMoi.AutoSize = true;
            this.lbDanhSachTuMoi.Location = new System.Drawing.Point(121, 175);
            this.lbDanhSachTuMoi.Name = "lbDanhSachTuMoi";
            this.lbDanhSachTuMoi.Size = new System.Drawing.Size(113, 13);
            this.lbDanhSachTuMoi.TabIndex = 0;
            this.lbDanhSachTuMoi.Text = "DANH SÁCH CỦA TỪ";
            this.lbDanhSachTuMoi.Click += new System.EventHandler(this.lbTuMoi_Click);
            // 
            // lbDanhSachNghiaTu
            // 
            this.lbDanhSachNghiaTu.AutoSize = true;
            this.lbDanhSachNghiaTu.Location = new System.Drawing.Point(424, 175);
            this.lbDanhSachNghiaTu.Name = "lbDanhSachNghiaTu";
            this.lbDanhSachNghiaTu.Size = new System.Drawing.Size(86, 13);
            this.lbDanhSachNghiaTu.TabIndex = 0;
            this.lbDanhSachNghiaTu.Text = "NGHĨA CỦA TỪ";
            this.lbDanhSachNghiaTu.Click += new System.EventHandler(this.lbTuMoi_Click);
            // 
            // txtHienThiNghiaTu
            // 
            this.txtHienThiNghiaTu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHienThiNghiaTu.Location = new System.Drawing.Point(412, 227);
            this.txtHienThiNghiaTu.Multiline = true;
            this.txtHienThiNghiaTu.Name = "txtHienThiNghiaTu";
            this.txtHienThiNghiaTu.ReadOnly = true;
            this.txtHienThiNghiaTu.Size = new System.Drawing.Size(120, 95);
            this.txtHienThiNghiaTu.TabIndex = 5;
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHienThiNghiaTu);
            this.Controls.Add(this.listDSTM);
            this.Controls.Add(this.btnThemTuMoi);
            this.Controls.Add(this.txtNghiaCuaTu);
            this.Controls.Add(this.txtTuMoi);
            this.Controls.Add(this.lbNghiaCuaTu);
            this.Controls.Add(this.lbDanhSachNghiaTu);
            this.Controls.Add(this.lbDanhSachTuMoi);
            this.Controls.Add(this.lbTuMoi);
            this.Name = "frmBai3";
            this.Text = "Từ điển Anh-Việt";
            this.Load += new System.EventHandler(this.frmBai3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTuMoi;
        private System.Windows.Forms.Label lbNghiaCuaTu;
        private System.Windows.Forms.TextBox txtTuMoi;
        private System.Windows.Forms.TextBox txtNghiaCuaTu;
        private System.Windows.Forms.Button btnThemTuMoi;
        private System.Windows.Forms.ListBox listDSTM;
        private System.Windows.Forms.Label lbDanhSachTuMoi;
        private System.Windows.Forms.Label lbDanhSachNghiaTu;
        private System.Windows.Forms.TextBox txtHienThiNghiaTu;
    }
}