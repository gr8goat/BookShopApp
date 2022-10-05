using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml;

namespace BookShopApp
{
    public partial class CustomersManageForm : Form
    {
        string thisFormTable = "Customers";

        public CustomersManageForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            customersGridView.DataSource = null;
            //customersGridView.Columns.Clear();

            List<String> customersData = DataAccess.GetAllData(thisFormTable);

            foreach(String customer in customersData)
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

            List<String> customersData = DataAccess.GetSearchData(thisFormTable ,searchOption, value);

            customersGridView.Rows.Clear();
            foreach (String customer in customersData)
            {
                string[] strings = customer.Split(',');
                customersGridView.Rows.Add(strings[0], strings[1], strings[2], strings[3]);
            }

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addCustomerForm addCustomerForm = new addCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            customersGridView.Rows.Clear();
            LoadData();
        }

        private void customersGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            /// If delete button is clicked
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                string customerID = customersGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', delete customer.
                    DataAccess.DeleteData("Customers", customerID);
                }
                else
                {
                    // If 'No', do nothing.
                }
            }


            /// If edit button is clicked
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {

                Customer customer = new Customer();
                int i = 0;
                customer.Id = int.Parse(customersGridView.Rows[e.RowIndex].Cells[i].Value.ToString());
                i++;
                customer.Name = customersGridView.Rows[e.RowIndex].Cells[i].Value.ToString();
                i++;
                customer.Address = customersGridView.Rows[e.RowIndex].Cells[i].Value.ToString();
                i++;
                customer.Email = customersGridView.Rows[e.RowIndex].Cells[i].Value.ToString();
                i = 0;

                CustomerEditForm customerEditForm = new CustomerEditForm(customer);
                customerEditForm.ShowDialog();

            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void searchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SearchData();
            }
        }
    }
}
