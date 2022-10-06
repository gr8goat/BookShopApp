using System;
using System.Collections;
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
    public partial class PurchaseForm : Form
    {
        List<Book> books = new List<Book>();
        string thisFormTable = "PurchaseOrders";
        public PurchaseForm()
        {
            InitializeComponent();
            this.totalPriceTextbox.Text = "0";
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerSearchBtn_Click(object sender, EventArgs e)
        {
            //CustomerFinderForm customerFinderForm = new CustomerFinderForm();
            //customerFinderForm.ShowDialog();

            using (var form = new CustomerFinderForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string customerId = form.returnCustomerId.ToString();            //values preserved after close
                    string customerName = form.returnCustomerName;

                    customerIdTextbox.Text = customerId;
                    customerNameTextbox.Text = customerName;

                }
            }
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            using (var form = new BookFinderFrom())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Book book = new Book(form.ISBN, form.Title, form.Price, form.Quantity, form.TotalPrice);
                    //books.Add($"book{bookIndex}" ,book);
                    books.Add(book);
                    purchaseGridView.Rows.Add(book.ISBN, book.Title, book.Price, book.Quantity, book.TotalPrice);
                    UpdateTotalPrice();
                }
            }
        }

        private void UpdateTotalPrice()
        {
            double sum = 0;
            foreach (var book in books)
            {
                //Book book = (Book)books[key];
                double price = book.TotalPrice;
                sum += price;
            }
            totalPriceTextbox.Text = sum.ToString();
        }

        private void purchaseGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// If delete button is clicked
            if (e.ColumnIndex == 6 && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', delete book.
                    purchaseGridView.Rows.RemoveAt(e.RowIndex);
                    books.RemoveAt(e.RowIndex);
                    UpdateTotalPrice();
                }
                else
                {
                    // If 'No', do nothing.
                }
            }

            /// If edit button is clicked
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                using (var form = new PurchaseEditForm())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        books[e.RowIndex].Quantity = form.Quantity;
                        books[e.RowIndex].TotalPrice = books[e.RowIndex].Quantity * books[e.RowIndex].Price;
                        purchaseGridView.Rows[e.RowIndex].Cells[3].Value = books[e.RowIndex].Quantity;
                        purchaseGridView.Rows[e.RowIndex].Cells[4].Value = books[e.RowIndex].TotalPrice;
                        UpdateTotalPrice();
                    }
                }
            }
        }

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order(int.Parse(customerIdTextbox.Text), double.Parse(totalPriceTextbox.Text));
            DataAccess.MakeOrder(thisFormTable, order, books);
            MessageBox.Show("OK");
        }
    }


}
