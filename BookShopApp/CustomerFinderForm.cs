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
    public partial class CustomerFinderForm : Form
    {
        string thisFormTable = "Customers";
        public string returnCustomerId { get; set; }
        public string returnCustomerName { get; set; }
        public CustomerFinderForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            customersGridView.DataSource = null;
            //customersGridView.Columns.Clear();

            List<String> customersData = DataAccess.GetAllData(thisFormTable);

            foreach (String customer in customersData)
            {
                string[] strings = customer.Split(',');
                customersGridView.Rows.Add(strings[0], strings[1], strings[2], strings[3]);
            }
        }

        public void SearchData()
        {
            string searchOption = searchComboBox.Text;

            switch (searchOption)
            {
                case "ID":
                    searchOption = "Customer_Id";
                    break;
                case "Name":
                    searchOption = "Customer_Name";
                    break;
                default:
                    break;
            }


            string value = searchTextbox.Text;

            List<String> customersData = DataAccess.GetSearchData(thisFormTable, searchOption, value);

            customersGridView.Rows.Clear();
            foreach (String customer in customersData)
            {
                string[] strings = customer.Split(',');
                customersGridView.Rows.Add(strings[0], strings[1], strings[2], strings[3]);
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void customersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// If select button is clicked
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to select this item ??",
                                     "Select Cancel",
                                     MessageBoxButtons.YesNo);
                int gridCustomerId = int.Parse(customersGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                string customerName = customersGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', delete customer.
                    this.returnCustomerId = gridCustomerId.ToString();
                    this.returnCustomerName = customerName;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    // If 'No', do nothing.
                }
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
        }
    }
}
