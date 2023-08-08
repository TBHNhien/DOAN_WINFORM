using lamlai_CAFE.Model;
using Microsoft.Reporting.WinForms;
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

namespace lamlai_CAFE
{
    public partial class fReportStore : Form
    {
        public fReportStore()
        {
            InitializeComponent();
        }

        private void fReportStore_Load(object sender, EventArgs e)
        {
            fStore fS = new fStore();

            using (var dbContext = new StoreContextDB())
            {
                using (var command = dbContext.Database.Connection.CreateCommand())
                {
                    command.CommandText = "GetStoreByDate";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@FROMDAY",fS.NgayF1));// DateTime.Parse("14-7-2023")
                    command.Parameters.Add(new SqlParameter("@TODAY", fS.NgayT1 ));//DateTime.Parse("15-7-2023")

                    dbContext.Database.Connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var STORES = new List<STORE>();

                        while (reader.Read())
                        {
                            var store = new STORE
                            {
                                MaterialID = reader["MaterialID"].ToString(),
                                NameMaterial = reader["NameMaterial"].ToString(),
                                RecivedDate = Convert.ToDateTime(reader["RecivedDate"]),
                                SupplierPrice = Convert.ToInt32(reader["SupplierPrice"]),
                                Unit = reader["Unit"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"])
                            };

                            STORES.Add(store);
                        }

                        List<StoreReport> lSR = new List<StoreReport>();
                        foreach (var i in STORES)
                        {

                            StoreReport temp = new StoreReport();
                            temp.MaterialID = i.MaterialID;
                            temp.NameMaterial = i.NameMaterial;
                            temp.RecivedDate = i.RecivedDate;
                            temp.SupplierPrice = i.SupplierPrice;
                            temp.Unit = i.Unit;
                            temp.Quantity = i.Quantity;

                            lSR.Add(temp);
                        }

                        this.reportViewer1.LocalReport.ReportPath = "C:\\Users\\Admin\\Desktop\\doanC#\\DOAN_WINFORM\\lamlai_CAFE\\lamlai_CAFE\\StoreReport.rdlc";
                        var RDataSource = new ReportDataSource("StoreDataSet", lSR);
                        this.reportViewer1.LocalReport.DataSources.Clear();
                        this.reportViewer1.LocalReport.DataSources.Add(RDataSource);
                        this.reportViewer1.RefreshReport();
                    }
                }
            }


            //StoreContextDB context = new StoreContextDB();
            //List<STORE> listSTORE = context.STOREs.ToList();
            //List<StoreReport> lSR = new List<StoreReport>();

            //foreach(STORE i in listSTORE)
            //{
            //    StoreReport temp = new StoreReport();
            //    temp.MaterialID = i.MaterialID;
            //    temp.NameMaterial = i.NameMaterial;
            //    temp.RecivedDate = i.RecivedDate;
            //    temp.SupplierPrice = i.SupplierPrice;
            //    temp.Unit = i.Unit;
            //    temp.Quantity = i.Quantity;

            //    lSR.Add(temp);
            //}
            //this.reportViewer1.LocalReport.ReportPath= "C:\\Users\\Admin\\Desktop\\DOAN\\lamlai_CAFE\\lamlai_CAFE\\StoreReport.rdlc";
            //var RDataSource = new ReportDataSource("StoreDataSet", lSR);
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(RDataSource);
            //this.reportViewer1.RefreshReport();
        }
    }
}
