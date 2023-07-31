using DevExpress.ReportServer.ServiceModel.DataContracts;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Customization;
using lamlai_CAFE.DAO;
using lamlai_CAFE.DTO;
using lamlai_CAFE.Model;
using Luong_nhan_vien_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using caCategory = lamlai_CAFE.DTO.Category;
using Category = lamlai_CAFE.DTO.Category;
using ComboBox = System.Windows.Forms.ComboBox;

namespace lamlai_CAFE
{
    public partial class fTableManager : DevExpress.XtraEditors.XtraForm
    {
        Model2 context = new Model2();
        public fTableManager()
        {
            InitializeComponent();
            LoadTable();
            List<FOODCATEGORY> fC = context.FOODCATEGORies.ToList();
            List<FOOD> fD = context.FOODs.ToList();

            FillFoodComboBox(fC, fD);
        }


        #region method



        void LoadTable()
        {
            flpTable.Controls.Clear(); // xóa tránh bị thêm bàn
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width=TableDAO.TableWidth , Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;

                //Set event Click cho nút btn
                btn.Click += btn_Click;

                //LẤY tableID khi nhấn vào nút (1)
                btn.Tag = item; // kiểu là obj 


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

        void ShowBill(int id)
        {
            //clear bàn
            lsvBill.Items.Clear();

            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

            float totalPrice = 0;

            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                //NHỮNG thằng sau đều là sub item

                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(lsvItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");//ĐẢM bảo luôn tiếng việt

            Thread.CurrentThread.CurrentCulture = culture;//culture c1

            txbTongGia.Text = totalPrice.ToString("c");

            //txbTotalPrice.Text = totalPrice.ToString("c",culture);//culter c2
        }


        private void FillFoodComboBox(List<FOODCATEGORY> listFOODCATEGORY, List<FOOD> listFOOD)
        {
            this.cbCategory.DataSource = listFOODCATEGORY;
            this.cbCategory.DisplayMember = "NAMECATEGORYFOOD";
            this.cbCategory.ValueMember = "IDFOODCATEGORY";

            this.cbFood.DataSource = listFOOD;
            this.cbFood.DisplayMember = "NAMEFOOD";
            this.cbFood.ValueMember = "IDFOOD";
        }

 

        //void LoadCategory()
        //{
        //    List<DTO.Category> listCategory = CategoryDAO.Instance.GetListCategory();
        //    cbCategory.DataSource = listCategory;

        //    //cần chỉ cho nó biết trường nào để lấy tên
        //    cbCategory.DisplayMember = "Name";
        //}

        void LoadFoodListByCategoryID(int id)
        {

            List<FOOD> foodList = context.FOODs.Where(food => food.IDFOODCATEGORY == id).ToList();

            //List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = foodList;

            //cần chỉ cho nó biết trường nào để lấy tên
            cbFood.DisplayMember = "NAMEFOOD";
        }

        #endregion

        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;

            //sử dụng lsv Tag => mỗi khi click sẽ có Tag bàn đó
            lsvBill.Tag = (sender as Button).Tag;

            ShowBill(tableID);
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoongTinTaiToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void xemLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fViewLuongNV f = new fViewLuongNV();
            f.Show();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            //lấy table hiện tại
            Table table = lsvBill.Tag as Table;

            if (table == null)
            {
                MessageBox.Show("Hãy Chọn Bàn");
                return;
            }

            //lấy idbill hiện tại
            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int idFood = (cbFood.SelectedItem as FOOD).IDFOOD;
            int count = (int)nmFoodCount.Value;//kiểu decimal => ép kiểu int

            string ten = Properties.Settings.Default.username;



            //nếu idbill ==-1 ko có bill nào hết => thêm bill mới
            if (idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(ten, BillDAO.Instance.GetMaxIDBill(), idFood, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(ten, idBill, idFood, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;


            //lấy id
            ComboBox cb = sender as ComboBox;

            //TH chưa có datasource
            if (cb.SelectedItem == null)
                return;

            //TH đã có datasource
            FOODCATEGORY selected = cb.SelectedItem as FOODCATEGORY;

            id = selected.IDFOODCATEGORY;

            LoadFoodListByCategoryID(id);
        }
    }
}