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

namespace Luong_admin_
{
    public partial class fLuong : Form
    {
        SqlConnection Connect;
        SqlCommand com;
        string s = @"Data Source=BRUHHH\SQLEXPRESS;Initial Catalog=luongnhanvien;Integrated Security=True";
        SqlDataAdapter sqldata = new SqlDataAdapter();
        DataTable dttb = new DataTable();
      
        public fLuong()
        {
            InitializeComponent();
        }
        public void DS()
        {
            com = Connect.CreateCommand();
            com.CommandText = "SELECT * FROM luongthang";
            sqldata.SelectCommand = com;
            dttb.Clear();
            sqldata.Fill(dttb);
            bangluong.DataSource = dttb;
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
            if (string.IsNullOrWhiteSpace(textsoca.Text))
            {
                MessageBox.Show("Ban chua nhap so ca lam", "Luu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textsoca.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textthoigian.Text))
            {
                MessageBox.Show("Ban chua nhap tong thoi gian lam", "Luu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textthoigian.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textluongso.Text))
            {
                MessageBox.Show("Ban chua nhap tong luong so", "Luu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textluongso.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textluongchu.Text))
            {
                MessageBox.Show("Ban chua nhap tong luong chu", "Luu y", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textluongchu.Focus();
                return false;
            }
            return true;
        }
        private void lbmanv_Click(object sender, EventArgs e)
        {

        }

        private void bangluong_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void bangluong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bangluong_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connect = new SqlConnection(s);
            Connect.Open();
            DS();
            
        }

        private void butthem_Click(object sender, EventArgs e)
        {
            
                if (kiemtranhap())
                {
                    com = Connect.CreateCommand();
                    com.CommandText = "INSERT INTO luongthang VALUES ('" + textmanv.Text + "',N'" + texttennv.Text + "','" + textsoca.Text + "','" + textthoigian.Text + "',N'" + textphat.Text + "','" + textluongso.Text + "',N'" + textluongchu.Text + "')";
                    com.ExecuteNonQuery();
                    DS();
                }
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            
            if (kiemtranhap())  
            {
                com = Connect.CreateCommand();
                com.CommandText = "UPDATE luongthang set TENNV=N'" + texttennv.Text + "', SOCA='" + textsoca.Text + "', TONGTHOIGIAN='" + textthoigian.Text + "' , PHAT =N'" + textphat.Text + "', TONGLUONGSO='" + textluongso.Text + "', TONGLUONGCHU=N'" + textluongchu.Text + "' WHERE MANHANVIEN ='" + textmanv.Text + "'";
                com.ExecuteNonQuery();
                DS();
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            
            if (kiemtranhap())
            {
                if (MessageBox.Show("Ban co chac chan muon xoa thong tin ve luong cua nhan vien nay khong?", "LUU Y", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
                com = Connect.CreateCommand();
                com.CommandText = "DELETE FROM luongthang WHERE MANHANVIEN='" + textmanv.Text + "'";
                com.ExecuteNonQuery();
                DS();
            }
        }

        private void butxoahet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa tat ca thong tin khong?", "LUU Y", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                com = Connect.CreateCommand();
                com.CommandText = "DELETE FROM luongthang";
                com.ExecuteNonQuery();
                DS();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bangluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int i;
                i = bangluong.CurrentRow.Index;
                textmanv.Text = bangluong.Rows[i].Cells[0].Value.ToString();
                texttennv.Text = bangluong.Rows[i].Cells[1].Value.ToString();
                textsoca.Text = bangluong.Rows[i].Cells[2].Value.ToString();
                textthoigian.Text = bangluong.Rows[i].Cells[3].Value.ToString();
                textphat.Text = bangluong.Rows[i].Cells[4].Value.ToString();
                textluongso.Text = bangluong.Rows[i].Cells[5].Value.ToString();
                textluongchu.Text = bangluong.Rows[i].Cells[6].Value.ToString();
        }
    }
}
