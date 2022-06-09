using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using QuanLyQuanCAFE.DAO;

namespace QuanLyQuanCAFE
{
    public partial class Admin : Form
    {
        BindingSource accountList = new BindingSource();
        public Admin()
        {
            InitializeComponent();
            
            LoadAccountList();
        }
             
        void LoadAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";

            DataProvider provider = new DataProvider();

            dataGridView2.DataSource = provider.ExecuteQuery(query, new object[] { "staff" });

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
