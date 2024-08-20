using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212427_DangDangNguyen_BTWindownsForm
{
    public partial class FrmBai3 : Form
    {
        public FrmBai3()
        {
            InitializeComponent();
        }

        private void FrmBai3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a =int.Parse(txtSoA.Text);
            int b =int.Parse(txtSoB.Text);
            int n=int.Parse(txtSoN.Text);
            int kq = 0;
            if (radioButton1.Checked)
                TinhToan.CongHaiSo(a, b, ref kq);
            else
                TinhToan.TongDaySo(n);
            lbHienThi.Text = kq.ToString();
        }
    }
}
