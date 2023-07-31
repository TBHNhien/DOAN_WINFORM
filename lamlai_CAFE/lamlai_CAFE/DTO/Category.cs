using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamlai_CAFE.DTO
{
    public class Category
    {
        public Category(int foods,int id, string name)
        {
            this.Foods = foods;
            this.ID = id;
            this.Name = name;
        }

        public Category(DataRow row)
        {
            this.Foods = (int)row["FOODs"];
            this.ID = (int)row["IDFOODCATEGORY"];
            this.Name = row["NAMECATEGORYFOOD"].ToString();
        }



        private string name;

        private int iD;

        private int Foods;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Foods1 { get => Foods; set => Foods = value; }
    }
}
