using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bangnhanvien
{
    public partial class fBangNV : Form
    {
        SqlConnection Connect;
        SqlCommand com;
        string s = "Data Source=.\\SQLEXPRESS;Initial Catalog=luongnhanvien;Integrated Security=True ";
        SqlDataAdapter sqldata = new SqlDataAdapter();
        DataTable dttb = new DataTable();
        public fBangNV()
        {
            InitializeComponent();
        }
        public void DS()
        {
            com = Connect.CreateCommand();
            com.CommandText = "SELECT * FROM nhanvien";
            sqldata.SelectCommand = com;
            dttb.Clear();
            sqldata.Fill(dttb);
            bangnhanvien.DataSource = dttb;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Connect = new SqlConnection(s);
            Connect.Open();
            DS();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public bool kiemtranhap()
        {
            if (string.IsNullOrWhiteSpace(textmanv.Text))
            {
                MessageBox.Show("Ban chua nhap ma nhan vien", "Luu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textmanv.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(texttennv.Text))
            {
                MessageBox.Show("Ban chua nhap ten nhan vien", "Luu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                texttennv.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textsdt.Text))
            {
                MessageBox.Show("Ban chua nhap so ca lam", "Luu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textsdt.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textemail.Text))
            {
                MessageBox.Show("Ban chua nhap tong thoi gian lam", "Luu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textemail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textchucvu.Text))
            {
                MessageBox.Show("Ban chua nhap tong luong so", "Luu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textchucvu.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textnamsinh.Text))
            {
                MessageBox.Show("Ban chua nhap tong luong chu", "Luu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textnamsinh.Focus();
                return false;
            }
            return true;
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            if (kiemtranhap())
            {
                com = Connect.CreateCommand();
                com.CommandText = "INSERT INTO nhanvien VALUES ('" + textmanv.Text + "',N'" + texttennv.Text + "','" + textsdt.Text + "','" + textemail.Text + "',N'" + textchucvu.Text + "','" + textnamsinh.Text + "')";
                com.ExecuteNonQuery();
                DS();
            }
        }

        private void butsua_Click(object sender, EventArgs e)
        { 
            if (kiemtranhap())
            {
                com = Connect.CreateCommand();
                com.CommandText = "UPDATE nhanvien set TENNHANVIEN=N'" + texttennv.Text + "', SDT='" + textsdt.Text + "', EMAIL='" + textemail.Text + "' , CHUCVU=N'" + textchucvu.Text + "', NAMSINH='" + textnamsinh.Text +"' WHERE MANHANVIEN ='" + textmanv.Text + "'";
                com.ExecuteNonQuery();
                DS();
            }
        }

        private void bangnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = bangnhanvien.CurrentRow.Index;
            textmanv.Text = bangnhanvien.Rows[i].Cells[0].Value.ToString();
            texttennv.Text = bangnhanvien.Rows[i].Cells[1].Value.ToString();
            textsdt.Text = bangnhanvien.Rows[i].Cells[2].Value.ToString();
            textemail.Text = bangnhanvien.Rows[i].Cells[3].Value.ToString();
            textchucvu.Text = bangnhanvien.Rows[i].Cells[4].Value.ToString();
            textnamsinh.Text = bangnhanvien.Rows[i].Cells[5].Value.ToString();
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            com = Connect.CreateCommand();
            com.CommandText = "DELETE from  nhanvien WHERE MANHANVIEN='" + textmanv.Text + "'";
            com.ExecuteNonQuery();  
            DS();
        }
    }
}
