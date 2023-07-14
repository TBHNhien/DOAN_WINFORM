﻿using lamlai_CAFE.DAO;
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

            if (Login(userName, passWord))
            {
                fTableManager f = new fTableManager();
                this.Hide();//ẩn flogin hiện tại , sau khi đăng nhập thành công
                f.ShowDialog();//thằng nào dialog là top mode
                this.Show();//hiện lại flogin , sau khi thoát ftablemanager
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !!!");
            }

        }
    }
}