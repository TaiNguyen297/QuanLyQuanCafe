using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCAFE
{
    public partial class TableManager : Form
    {
        private object flpTable;

        public TableManager()
        {
            InitializeComponent();

            LoadTable(GetFlpTable());
        }

        private object GetFlpTable()
        {
            return flpTable;
        }

        #region Method
        void LoadTable (object flpTable)
        {
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                flpTable.Controls.Add(btn);



            }
        }
        #endregion


        #region Events
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin f = new Admin();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
