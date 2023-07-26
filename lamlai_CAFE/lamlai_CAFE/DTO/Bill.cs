using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamlai_CAFE.DTO
{
    public class Bill
    {
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int status;

        public Bill (int id ,DateTime? dateCheckIn , DateTime? dateCheckOut , int status)
        {
            this.ID = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }

        public Bill (DataRow row)
        {
            this.ID = (int)row["IDBILL"];
            this.DateCheckIn = (DateTime?)row["DATECHECKIN"];

            var datecheckoutTemp = row["DATECHECKOUT"];
            if(datecheckoutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)datecheckoutTemp;

            this.Status = (int)row["STATUS"];
        }

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int Status { get => status; set => status = value; }
    }
}
