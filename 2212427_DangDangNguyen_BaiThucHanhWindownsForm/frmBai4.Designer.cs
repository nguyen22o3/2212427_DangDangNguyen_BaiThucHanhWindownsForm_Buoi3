namespace _2212427_DangDangNguyen_BaiThucHanhWindownsForm
{
    partial class frmBai4
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbNhapSoCanTim = new System.Windows.Forms.Label();
            this.btnTimSo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.lbHienThiKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(33, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(224, 238);
            this.listBox1.TabIndex = 0;
            // 
            // lbNhapSoCanTim
            // 
            this.lbNhapSoCanTim.AutoSize = true;
            this.lbNhapSoCanTim.Location = new System.Drawing.Point(364, 90);
            this.lbNhapSoCanTim.Name = "lbNhapSoCanTim";
            this.lbNhapSoCanTim.Size = new System.Drawing.Size(87, 13);
            this.lbNhapSoCanTim.TabIndex = 1;
            this.lbNhapSoCanTim.Text = "Nhập số cần tìm:";
            this.lbNhapSoCanTim.Click += new System.EventHandler(this.lbNhapSoCanTim_Click);
            // 
            // btnTimSo
            // 
            this.btnTimSo.Location = new System.Drawing.Point(468, 122);
            this.btnTimSo.Name = "btnTimSo";
            this.btnTimSo.Size = new System.Drawing.Size(75, 23);
            this.btnTimSo.TabIndex = 2;
            this.btnTimSo.Text = "Tìm số";
            this.btnTimSo.UseVisualStyleBackColor = true;
            this.btnTimSo.Click += new System.EventHandler(this.btnTimSo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(457, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.BackColor = System.Drawing.Color.White;
            this.lbKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetQua.ForeColor = System.Drawing.Color.Blue;
            this.lbKetQua.Location = new System.Drawing.Point(364, 221);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(80, 25);
            this.lbKetQua.TabIndex = 1;
            this.lbKetQua.Text = "Kết quả";
            // 
            // lbHienThiKetQua
            // 
            this.lbHienThiKetQua.AutoSize = true;
            this.lbHienThiKetQua.Location = new System.Drawing.Point(495, 221);
            this.lbHienThiKetQua.Name = "lbHienThiKetQua";
            this.lbHienThiKetQua.Size = new System.Drawing.Size(16, 13);
            this.lbHienThiKetQua.TabIndex = 1;
            this.lbHienThiKetQua.Text = "...";
            // 
            // frmBai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 373);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTimSo);
            this.Controls.Add(this.lbHienThiKetQua);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.lbNhapSoCanTim);
            this.Controls.Add(this.listBox1);
            this.Name = "frmBai4";
            this.Text = "frmBai4";
            this.Load += new System.EventHandler(this.frmBai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbNhapSoCanTim;
        private System.Windows.Forms.Button btnTimSo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbKetQua;
        private System.Windows.Forms.Label lbHienThiKetQua;
    }
}