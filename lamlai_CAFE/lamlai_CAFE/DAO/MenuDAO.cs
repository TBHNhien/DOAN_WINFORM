
using lamlai_CAFE.DTO;
using lamlai_CAFE.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;

namespace lamlai_CAFE.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }

        private MenuDAO() { }

        public List<DTO.Menu> GetListMenuByTable(int id)
        {
            List<DTO.Menu> listMenu = new List<DTO.Menu>();
            string query = "SELECT F.NAMEFOOD , BI.COUNTFOOD , F.PRICE,F.PRICE * BI.COUNTFOOD AS [TOTALPRICE] FROM BILLINFO BI ,BILL B, FOOD F WHERE BI.IDBILL = B.IDBILL AND BI.IDFOOD = F.IDFOOD AND B.idTableFood = " + id + "and B.STATUS = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DTO.Menu menu = new DTO.Menu(item);
                listMenu.Add(menu);
            }

            return listMenu;
        }
    }
}
