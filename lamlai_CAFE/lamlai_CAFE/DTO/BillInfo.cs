using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamlai_CAFE.DTO
{
    public class BillInfo
    {
        private int iDBillInfo;

        private string userName;

        private int iDBill;

        private int iDFood;

        private int countFood;
        public int IDBillInfo { get => iDBillInfo; set => iDBillInfo = value; }
        public string UserName { get => userName; set => userName = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public int CountFood { get => countFood; set => countFood = value; }
        public int IDFood { get => iDFood; set => iDFood = value; }

        public BillInfo(int iDBillInfo, string userName, int iDBill, int iDFood, int countFood)
        {
            this.iDBillInfo = iDBillInfo;
            this.userName = userName;
            this.iDBill = iDBill;
            this.IDFood = iDFood;
            this.countFood = countFood;
        }

        public BillInfo(DataRow row)
        {
            this.iDBillInfo = (int)row["IDBILLINFO"];
            this.userName =row["USERNAME"].ToString();
            this.iDBill = (int)row["IDBILL"];
            this.IDFood = (int)row["IDFOOD"];
            this.countFood = (int)row["COUNTFOOD"];
        }

        

    }
}
