using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2212427_DangDangNguyen_BaiThucHanhWindownsForm
{
    public partial class frmBai3 : Form
    {
        List <string>list = new List <string> ();
        public frmBai3()
        {
            InitializeComponent();
        }
        private void frmBai3_Load(object sender, EventArgs e)
        {

        }
        private void lbTuMoi_Click(object sender, EventArgs e)
        {

        }
        private void btnThemTuMoi_Click(object sender, EventArgs e)
        {
            var tu =txtTuMoi.Text;
            var nghia=txtNghiaCuaTu.Text;
            listDSTM.Items.Add(tu);
            list.Add(nghia);
            txtTuMoi.Focus();
            txtTuMoi.Text = " ";
            txtNghiaCuaTu.Text = " ";
            listDSTM.SelectedIndex=listDSTM.Items.Count-1;
            txtHienThiNghiaTu.Text = nghia;
        }
        private void listDSTM_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt=listDSTM.SelectedIndex;
            txtHienThiNghiaTu.Text = list[stt];
        }
    }
}
