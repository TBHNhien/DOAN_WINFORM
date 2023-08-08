using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamlai_CAFE
{
    public partial class FQUENMATKHAU : Form
    {
        public FQUENMATKHAU()
        {
            InitializeComponent();
        }

        //public string connectionSTR = " Data Source=.\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True ";
        SqlConnection connectionSTR = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True" );

        string randomCode;
        public static string to;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ EMAIL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbEmail.Focus();
            }
            else
            {
                try
                {
                    String querry = "SELECT * FROM NHANVIEN WHERE EMAIL = '" + txbEmail.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry, connectionSTR);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0)
                    {
                        string from, pass, messageBody;
                        Random rand = new Random();
                        randomCode = (rand.Next(000000, 999999)).ToString();
                        MailMessage message = new MailMessage();
                        to = (txbEmail.Text).ToString();
                        from = "tbaohaonhien1995@gmail.com";
                        //pass = "tjfxnmghsuumfnjj";
                        messageBody = "Mã xác nhận của bạn là " + randomCode + ".";
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messageBody;
                        message.Subject = "Mã xác nhận đặt lại mật khẩu ";
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        //smtp.Credentials = new NetworkCredential(from, pass);

                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.UseDefaultCredentials = false; // Tắt sử dụng thông tin xác thực mặc định
                        smtp.Credentials = new NetworkCredential("tbaohaonhien1995@gmail.com", "lfoacrrmwkbgerwb");
                        try
                        {
                            smtp.Send(message);
                            MessageBox.Show("Mã xác nhận của bạn đã được gửi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txbMaXM.Enabled = true;
                            txbEmail.Enabled = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Địa chỉ Email không tồn tại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txbEmail.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    connectionSTR.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (randomCode == (txbMaXM.Text).ToString())
            {
                to = txbEmail.Text;
                MessageBox.Show("Mã xác nhận chính xác", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pnlXacMinh.Visible = false;
                pnlDoiMK.Visible = true;
            }
            else
            {
                MessageBox.Show("Nhập sai mã xác nhận!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMaXM.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txbMKMOI.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMKMOI.Focus();
            }
            else
            {
                if (txbMKMOI.TextLength < 8)
                {
                    MessageBox.Show("Mật khẩu phải đủ ít nhất 8 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbMKMOI.Clear();
                    txbMKMOI.Focus();
                }
                else
                {
                    if (txbMKMOI.Text == txbNHAPLAI.Text)
                    {
                        SqlCommand cmd = new SqlCommand("UPDATE [dbo].[NHANVIEN] SET [PASS] = '" + txbNHAPLAI.Text + "' WHERE EMAIL = '" + txbEmail.Text + "'", connectionSTR);
                        connectionSTR.Open();
                        cmd.ExecuteNonQuery();
                        connectionSTR.Close();
                        MessageBox.Show("Đặt lại mật khẩu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //fLogin f = new fLogin();
                        //f.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txbMKMOI.UseSystemPasswordChar = false;
                txbMKMOI.PasswordChar = '\0';

                txbNHAPLAI.UseSystemPasswordChar = false;
                txbNHAPLAI.PasswordChar = '\0';
            }
            else
            {
                txbMKMOI.UseSystemPasswordChar = true;
                txbMKMOI.PasswordChar = '●';

                txbNHAPLAI.UseSystemPasswordChar = true;
                txbNHAPLAI.PasswordChar = '●';
            }
        }
    }
}
