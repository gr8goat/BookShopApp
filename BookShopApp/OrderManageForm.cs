using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopApp
{
    public partial class OrderManageForm : Form
    {
        string thisFormTable = "PurchaseOrders";
        public OrderManageForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            ordersGridView.DataSource = null;
            //customersGridView.Columns.Clear();

            List<String> orderData = DataAccess.GetAllData(thisFormTable);

            foreach (String order in orderData)
            {
                string[] strings = order.Split(',');
                ordersGridView.Rows.Add(strings[0], strings[1], strings[2], strings[3], strings[4], strings[5]);
            }
        }

        public void SearchData()
        {
            string searchOption = searchComboBox.Text;

            string value = searchTextbox.Text;

            List<String> booksData = DataAccess.GetSearchOrderData(thisFormTable, searchOption, value);

            ordersGridView.Rows.Clear();
            foreach (String book in booksData)
            {
                string[] strings = book.Split(',');
                ordersGridView.Rows.Add(strings[0], strings[1], strings[2], strings[3], strings[4], strings[5]);
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchData();
        }
    }
}
