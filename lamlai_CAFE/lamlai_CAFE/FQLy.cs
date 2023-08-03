using BaiLon;
using Bangnhanvien;
using Chamcong_nhan_vien_;
using lamlai_CAFE.Model;
using Luong_admin_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamlai_CAFE
{
    public partial class FQLy : Form
    {

        
        public FQLy()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fTableManager f = new fTableManager();
            f.Show();
        }

        private void btnacc_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Type;



            TaiLKhoan f = new TaiLKhoan();
            f.Show();


        }

        private void btnqliNV_Click(object sender, EventArgs e)
        {
            fBangNV f = new fBangNV();
            f.Show();
        }

        private void btnluong_Click(object sender, EventArgs e)
        {
            fLuong f = new fLuong();
            f.Show();

        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            fStore f = new fStore();
            f.Show();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            BaoCao f = new BaoCao();
            f.Show();
        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {
            fChamCong f = new fChamCong();
            f.Show();
        }

        private void btnloinhuan_Click(object sender, EventArgs e)
        {
            BaoCao f = new BaoCao();
            f.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
