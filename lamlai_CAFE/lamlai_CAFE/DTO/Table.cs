﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lamlai_CAFE.DTO
{
    public class Table
    {
        public Table (int id , string name , string status)
        {
            this.ID = id;
            this.Name = name;
            this.Status = status;
        }
        
        public Table (DataRow row)
        {
            this.ID = (int)row["IDTABLEFOOD"];
            this.Name = row["NAME"].ToString();
            this.Status = row["STATUSTABLE"].ToString();
        }

        private int iD;
        private string name;
        private string status;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
    }
}
