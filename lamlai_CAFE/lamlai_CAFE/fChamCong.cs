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

namespace Chamcong_nhan_vien_
{
    public partial class fChamCong : Form
    {
        SqlConnection Connect;
        SqlCommand com;
        string s = "Data Source=.\\SQLEXPRESS;Initial Catalog=luongnhanvien;Integrated Security=True";
        SqlDataAdapter sqldata = new SqlDataAdapter();
        DataTable dttb = new DataTable();
        public fChamCong()
        {
            InitializeComponent();
        }
        public void DS()
        {
            com = Connect.CreateCommand();
            com.CommandText = "SELECT * FROM chamcong";
            sqldata.SelectCommand = com;
            dttb.Clear();
            sqldata.Fill(dttb);
            bangchamcong.DataSource = dttb;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Connect = new SqlConnection(s);
            Connect.Open();
            DS();
        }

        private void butluu_Click(object sender, EventArgs e)
        {
            com = Connect.CreateCommand();
            com.CommandText = "INSERT INTO chamcong VALUES ('" + textmanv.Text + "','" + textthuhai.Text + "','" + textthuba.Text + "','" + textthutu.Text + "','" + textthunam.Text + "','" + textthusau.Text + "','" + textthubay.Text + "','" + textchunhat.Text + "')";
            com.ExecuteNonQuery();
            DS();
        }

        private void bangchamcong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = bangchamcong.CurrentRow.Index;
            textmanv.Text = bangchamcong.Rows[i].Cells[0].Value.ToString();
            textthuhai.Text = bangchamcong.Rows[i].Cells[1].Value.ToString();
            textthuba.Text = bangchamcong.Rows[i].Cells[2].Value.ToString();
            textthutu.Text = bangchamcong.Rows[i].Cells[3].Value.ToString();
            textthunam.Text = bangchamcong.Rows[i].Cells[4].Value.ToString();
            textthusau.Text = bangchamcong.Rows[i].Cells[5].Value.ToString();
            textthubay.Text = bangchamcong.Rows[i].Cells[6].Value.ToString();
            textchunhat.Text = bangchamcong.Rows[i].Cells[6].Value.ToString();
        }

        private void butsua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon sua lai lua chon khong?", "LUU Y", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                com = Connect.CreateCommand();
                com.CommandText = "UPDATE chamcong set THUHAI='" + textthuhai.Text + "', THUBA='" + textthuba.Text + "', THUTU='" + textthutu.Text + "' , THUNAM ='" + textthunam.Text + "', THUSAU='" + textthusau.Text + "', THUBAY='" + textthubay.Text + "', CHUNHAT='" + textchunhat.Text + "' WHERE MANHANVIEN ='" + textmanv.Text + "'";
                com.ExecuteNonQuery();
                DS();
            }
        }

        private void butxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co chac chan muon xoa het lua chon truoc do khong?", "LUU Y", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                com = Connect.CreateCommand();
                com.CommandText = "DELETE FROM chamcong WHERE MANHANVIEN='" + textmanv.Text + "'";
                com.ExecuteNonQuery();
                DS();
            }
        }
    }
}
