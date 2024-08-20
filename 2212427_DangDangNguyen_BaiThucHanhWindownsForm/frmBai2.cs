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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item =listHH.SelectedItem;
            listHKDM.Items.Add(item);
        }

        private void lblDSHH_Click(object sender, EventArgs e)
        {

        }

        private void lbMHDM_Click(object sender, EventArgs e)
        {

        }

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            listHKDM.Items.Remove(listHKDM.SelectedItem);
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;
            foreach (string hang in listHKDM.Items)
            {
                switch (hang) 
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn phím":
                        soTien += 150000;
                        break;
                    case "Máy in":
                        soTien += 2000000;
                        break;
                    case "USB Kingmax":
                        soTien += 200000;
                        break;
                    default:
                        break;
                }
                lbSoTien.Text = soTien + " đồng";
            }
        }
    }
}
