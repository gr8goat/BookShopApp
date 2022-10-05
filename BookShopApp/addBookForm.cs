using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookShopApp
{
    public partial class addBookForm : Form
    {
        public addBookForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string isbn = isbnTextbox.Text;
            string title = bookTitleTextbox.Text;
            string description = descriptionTextbox.Text;
            double price = Double.Parse(priceTextbox.Text);

            if (String.IsNullOrEmpty(description))
            {
                description = "N/A";
            }

            DataAccess.AddBook(isbn, title, description, price);
            MessageBox.Show("เพิ่มหนังสือเรียบร้อย!");
            this.Close();

        }
    }
}
