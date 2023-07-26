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

namespace Luong_nhan_vien_
{
    public partial class fViewLuongNV : Form
    {
        private DataGridView dataGridViewKetQua;
        SqlConnection Connect;
        SqlCommand com;
        string s = @"Data Source=BRUHHH\SQLEXPRESS;Initial Catalog=luongnhanvien;Integrated Security=True";
        SqlDataAdapter sqldata = new SqlDataAdapter();
        DataTable dttb = new DataTable();
        public fViewLuongNV()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            Connect = new SqlConnection(s);
            Connect.Open();
            DS();
        }
       
        private void buttimkiem_Click(object sender, EventArgs e)
        {


           


            string connectionString = @"Data Source=BRUHHH\SQLEXPRESS;Initial Catalog=luongnhanvien;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    using (SqlCommand command = new SqlCommand("SELECT * FROM luongthang WHERE MANHANVIEN LIKE '%' + @searchText + '%'", connection))
                    {
                        command.Parameters.AddWithValue("@searchText", texttimkiem.Text);

                        
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            bangluong.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: " + ex.Message);
            }
        }
            }



        }
    

