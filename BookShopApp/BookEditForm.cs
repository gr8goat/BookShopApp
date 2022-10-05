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
    public partial class BookEditForm : Form
    {
        string thisFormTable = "Books";
        public BookEditForm(Book book)
        {
            InitializeComponent(book);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            // update database
            string[] strings = { this.bookTitleTextbox.Text, this.descriptionTextbox.Text, this.priceTextbox.Text };

            DataAccess.UpdateData(thisFormTable, this.isbnTextbox.Text, strings);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
