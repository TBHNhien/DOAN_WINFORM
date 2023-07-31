
using lamlai_CAFE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiLon
{
    public partial class TaiLKhoan : Form
    {
        Model2 context=new Model2();
        public TaiLKhoan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<ChucVu> listChucVu = context.ChucVus.ToList();
                List<TaiKhoan> listTaiKhoan = context.TaiKhoans.ToList();
                BindGrind(listTaiKhoan);
                FillFalcultyComboBox(listChucVu);
            }

            catch 
            {
                MessageBox.Show("Có lỗi xin thử lại");
            }
        }
        private void BindGrind(List<TaiKhoan> ListHang)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in ListHang)
            {

                int index = dataGridView1.Rows.Add();
                dataGridView1.Rows[index].Cells[0].Value = item.MaTaiKhoan;
                dataGridView1.Rows[index].Cells[1].Value = item.Ten;
                dataGridView1.Rows[index].Cells[2].Value = item.MatKhau;
                dataGridView1.Rows[index].Cells[3].Value = item.ChucVu.TenChucVu;
            
            }

        }
        private void FillFalcultyComboBox(List<ChucVu> listFaculty)
        {
            this.cbxChucVu.DataSource = listFaculty;
            this.cbxChucVu.DisplayMember = "TenChucVu";
            this.cbxChucVu.ValueMember = "MaChucVu";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan Them = context.TaiKhoans.FirstOrDefault(p => p.MaTaiKhoan.ToString() == txtMaSo.Text.ToString());
                if (txtMaSo.Text != ""&&txtMatKhau.Text !="" && txtTen.Text != "") {
                    if (Them == null)
                    {
                        TaiKhoan s = new TaiKhoan()
                        {
                            MaTaiKhoan = txtMaSo.Text.ToString(),
                            Ten = txtTen.Text.ToString(),
                            MatKhau = txtMatKhau.Text.ToString(),
                            MaChucVu = int.Parse(cbxChucVu.SelectedValue.ToString()),
                        };
                        context.TaiKhoans.Add(s);
                        context.SaveChanges();
                        List<TaiKhoan> listStudents = context.TaiKhoans.ToList();
                        //context.SaveChanges();
                        BindGrind(listStudents);
                    }
                    else
                    {
                        MessageBox.Show("Trùng mã số xin đôi lại");
                    }
                }
                else {
                    MessageBox.Show("Chưa nhập đầy đủ thông tin");
                }
                
            }catch  {
                MessageBox.Show("Có lỗi xin thử lại");
            }
        

        }
          
        





    private void button2_Click_1(object sender, EventArgs e)
        {
            
        }
    

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow;
            selectedRow = dataGridView1.CurrentRow.Index;

            txtMaSo.Text = dataGridView1.Rows[selectedRow].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[selectedRow].Cells[1].Value.ToString();
            txtMatKhau.Text = dataGridView1.Rows[selectedRow].Cells[2].Value.ToString();
            cbxChucVu.Text = dataGridView1.Rows[selectedRow].Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                TaiKhoan Sua = context.TaiKhoans.FirstOrDefault(p => p.MaTaiKhoan.ToString() == txtMaSo.Text.ToString());

                if (Sua != null)
                {
                    Sua.MaTaiKhoan = txtMaSo.Text.ToString();
                    Sua.Ten = txtTen.Text.ToString();
                    Sua.MatKhau = txtMatKhau.Text.ToString();
                    Sua.MaChucVu = int.Parse(cbxChucVu.SelectedValue.ToString());

                    context.SaveChanges();
                    List<TaiKhoan> listStudents = context.TaiKhoans.ToList();
                    BindGrind(listStudents);
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xin thử lại");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Bạn có muốn xoá hay không","Exit",MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    TaiKhoan xoa = context.TaiKhoans.FirstOrDefault(p => p.MaTaiKhoan.ToString() == txtMaSo.Text.ToString());
                    if (xoa != null)
                    {
                        context.TaiKhoans.Remove(xoa);
                        context.SaveChanges();
                        List<TaiKhoan> listStudents = context.TaiKhoans.ToList();
                        BindGrind(listStudents);
                        txtMaSo.Text = "";
                        txtMatKhau.Text = "";
                        txtTen.Text = "";
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
