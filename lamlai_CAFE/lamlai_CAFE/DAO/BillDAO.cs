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
    }
}
