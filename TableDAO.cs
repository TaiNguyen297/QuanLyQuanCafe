using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyQuanCAFE.DAO;

namespace QuanLyQuanCAFE
{
    
    
    public class TableDAO
    {
        private static TableDAO instance;


        public static TableDAO Instance 
        { 
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int  TableWidth = 50;
        public static int TableHeight = 50;
        private List<Table> tableList;

        private TableDAO() { }

        public List<Table> LoadTableList()
        {
            List<Table> tablelist = new List<Table>();
            
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tablelist.Add(table);
            }

            return tableList;
        }
    }
}
