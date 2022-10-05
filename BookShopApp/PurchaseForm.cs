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
        Hashtable books = new Hashtable();
        int bookIndex = 0;
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
                    Book book = new Book(form.ISBN, form.Title, form.Price, form.Quantity, form.TotalPrice, bookIndex);
                    books.Add($"book{bookIndex}" ,book);
                    bookIndex++;
                    purchaseGridView.Rows.Add(book.ISBN, book.Title, book.Price, book.Quantity, book.TotalPrice);
                    UpdateTotalPrice();
                }
            }
        }

        private void UpdateTotalPrice()
        {
            ICollection collection = books.Keys;
            double sum = 0;
            foreach (var key in collection)
            {
                Book book = (Book)books[key];
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
                    books.Remove("book" + e.RowIndex);
                    UpdateTotalPrice();
                }
                else
                {
                    // If 'No', do nothing.
                }
            }
        }
    }


}
