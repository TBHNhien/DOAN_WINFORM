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
                        pass = "tjfxnmghsuumfnjj";
                        messageBody = "Mã xác nhận của bạn là " + randomCode + ".";
                        message.To.Add(to);
                        message.From = new MailAddress(from);
                        message.Body = messageBody;
                        message.Subject = "Mã xác nhận đặt lại mật khẩu ";
                        SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                        smtp.EnableSsl = true;
                        smtp.Port = 587;
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Credentials = new NetworkCredential(from, pass);
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
                catch
                {
                    MessageBox.Show("Lỗi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connectionSTR.Close();
                }
            }
        }
    }
}
