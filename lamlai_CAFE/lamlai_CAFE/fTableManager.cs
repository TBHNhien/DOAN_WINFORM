using DevExpress.XtraEditors;
using lamlai_CAFE.DAO;
using lamlai_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamlai_CAFE
{
    public partial class fTableManager : DevExpress.XtraEditors.XtraForm
    {
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
        }


        #region method



        void LoadTable()
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width=TableDAO.TableWidth , Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Blue;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }

                flpTable.Controls.Add(btn);
            }
        }


        #endregion

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoongTinTaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile F = new fAccountProfile();
            //this.Hide();
            F.ShowDialog();
            //this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fStore fS = new fStore();
            this.Hide();
            fS.ShowDialog();
            this.Show();
        }
    }
}