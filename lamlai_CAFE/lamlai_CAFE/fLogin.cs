using BaiLon;
using lamlai_CAFE.DAO;
using lamlai_CAFE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lamlai_CAFE
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

#region method

        bool Login(string userName ,string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }


#endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show ("Bạn có muốn thoát chương trình ?" , "Thông báo " , MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK )
            {
                e.Cancel = true;
            }    
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;

            Properties.Settings.Default.username = userName;
            Properties.Settings.Default.password = passWord;


            Model2 context = new Model2();
            int typeql = 1;
            ACCOUNT dbType = context.ACCOUNTs.FirstOrDefault(p => p.USERNAME == Properties.Settings.Default.username);


            if (Login(userName, passWord))
            {
                if (dbType.TYPE == typeql)
                {
                    FQLy f = new FQLy();
                    this.Hide();//ẩn flogin hiện tại , sau khi đăng nhập thành công
                    f.ShowDialog();//thằng nào dialog là top mode
                    this.Show();//hiện lại flogin , sau khi thoát ftablemanager
                }
                else
                {
                    fTableManager fM = new fTableManager();
                    fM.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !!!");
            }

        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
