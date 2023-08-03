using lamlai_CAFE.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamlai_CAFE.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance 
        { 
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        /// <summary>
        /// Thành Công : billID
        /// thất bại : -1
        /// </summary>
        /// <param name="IDBILL"></param>
        /// <returns></returns>

        public int GetUncheckBillIDByTableID (int IDtable)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM BILL WHERE IDTABLEFOOD = "+ IDtable + " AND STATUS = 0");


            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;

        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_INSERTBILL @IDTABLEFOOD", new object[] { id });
        }

        public int GetMaxIDBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("select max(idbill) from bill");
            }
            catch
            {
                return 1;
            }
        }

        public void CheckOut(int id, int discount) // thay đổi status bàn về 1 là đã thanh toán
        {
            string query = "update bill set status = 1 , Datecheckout = GETDATE() , " + "DISCOUNT = " + discount + " WHERE IDbill = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);//Update ->nonquery
        }
    }
}
