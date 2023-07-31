using BaiLon.BaoCaoLoiNhuan;
using BaiLon.BaoCaoLuong;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiLon
{
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
        }

   

        private void báoCáoLuongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LLuongDB context = new LLuongDB();
                List<luongthang> listluongthangs = context.luongthangs.ToList();
                List<classLuongthang> listreport = new List<classLuongthang>();
                foreach (luongthang nv in listluongthangs)
                {
                    classLuongthang temp = new classLuongthang();
                    temp.MaNV = nv.MANV;
                    temp.TenNV = nv.TENNV;
                    temp.TongThoiGian = nv.TONGTHOIGIAN;
                    temp.SoCa = nv.SOCA;
                    temp.Phat = nv.PHAT;
                    temp.luong = nv.TONGLUONGSO;
                    listreport.Add(temp);
                }
                reportViewer1.LocalReport.ReportPath = "BaoCaoLuong.rdlc";
                var sourse = new ReportDataSource("DataSet1", listreport);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(sourse);
                this.reportViewer1.RefreshReport();
            }
            catch 
            {
                MessageBox.Show("Có lỗi xin thử lại");
            }
        }

        private void báoCáoLợiNhuậnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                LoiNhuanDB context = new LoiNhuanDB();
                List<BILLINFO> listluongthangs = context.BILLINFOes.ToList();
                List<classLoiNhuan> listreport = new List<classLoiNhuan>();
                foreach (BILLINFO nv in listluongthangs)
                {
                    classLoiNhuan temp = new classLoiNhuan();
                    temp.MaHD = nv.IDBILLINFO;
                    temp.tenFood = nv.FOOD.NAMEFOOD;
                    temp.IDBill = nv.IDBILL;
                    temp.demfood = nv.COUNTFOOD;
                    temp.Tong = nv.FOOD.PRICE+double.Parse(nv.COUNTFOOD.ToString());
                    
                    listreport.Add(temp);
                }
                reportViewer1.LocalReport.ReportPath = "BaoCaoLoiNhuan.rdlc";
                var sourse = new ReportDataSource("DataSet1", listreport);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(sourse);
                this.reportViewer1.RefreshReport();
            }
            catch
            {
                MessageBox.Show("Có lỗi xin thử lại");
            }
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {

        }
    }
}
