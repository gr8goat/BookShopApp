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
    public partial class PurchaseForm : Form
    {
        int totalBooksNumber;
        public PurchaseForm()
        {
            InitializeComponent();
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
            //BookFinderFrom bookFinderFrom = new BookFinderFrom();
            //bookFinderFrom.ShowDialog();

            using (var form = new BookFinderFrom())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string bookISBN = form.ISBN;            //values preserved after close
                    string bookTitle = form.Title;
                    double bookPrice = form.Price;
                    int bookQuantity = form.Quantity;
                    double bookTotalPrice = form.TotalPrice;

                    purchaseGridView.Rows.Add(bookISBN, bookTitle, bookPrice, bookQuantity, bookTotalPrice);
                    this.totalBooksNumber++;
                    UpdateTotalPrice();
                }
            }
        }

        private void UpdateTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < this.totalBooksNumber; i++)
            {
                double bookPrice = Double.Parse(purchaseGridView.Rows[i].Cells[4].Value.ToString());
                sum += bookPrice;
                i++;
            }
            totalPriceTextbox.Text = sum.ToString();
        }


    }

    public static class Buyer
    { 
        public static string Name { get; set; }
        public static int Id { get; set; }
    }

    public static class WantedBook<Book> 
    {
        public static string ISBN { get; set; }
        public static string Title { get; set; }
        public static double Price { get; set; }
        public static int Quantity { get; set; }
    }

}
