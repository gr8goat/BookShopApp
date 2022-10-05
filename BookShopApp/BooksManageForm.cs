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
    public partial class BooksManageForm : Form
    {
        string thisFormTable = "Books";
        public BooksManageForm()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            booksGridView.DataSource = null;
            //customersGridView.Columns.Clear();

            List<String> booksData = DataAccess.GetAllData(thisFormTable);

            foreach (String book in booksData)
            {
                string[] strings = book.Split(',');
                booksGridView.Rows.Add(strings[0], strings[1], strings[2], strings[3]);
            }
        }

        public void SearchData()
        {
            string searchOption = searchComboBox.Text;

            string value = searchTextbox.Text;

            List<String> booksData = DataAccess.GetSearchData(thisFormTable ,searchOption, value);

            booksGridView.Rows.Clear();
            foreach (String book in booksData)
            {
                string[] strings = book.Split(',');
                booksGridView.Rows.Add(strings[0], strings[1], strings[2], strings[3]);
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void searchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchData();
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addBookForm addBookForm = new addBookForm();
            addBookForm.ShowDialog();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            booksGridView.Rows.Clear();
            LoadData();
        }

        private void booksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// If delete button is clicked
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
                string bookISBN = booksGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', delete book.
                    DataAccess.DeleteData(thisFormTable, bookISBN);
                }
                else
                {
                    // If 'No', do nothing.
                }
            }


            /// If edit button is clicked
            if (e.ColumnIndex == 4 && e.RowIndex >= 0)
            {

                Book book = new Book();
                int i = 0;
                book.ISBN = booksGridView.Rows[e.RowIndex].Cells[i].Value.ToString();
                i++;
                book.Title = booksGridView.Rows[e.RowIndex].Cells[i].Value.ToString();
                i++;
                book.Description = booksGridView.Rows[e.RowIndex].Cells[i].Value.ToString();
                i++;
                book.Price = Double.Parse(booksGridView.Rows[e.RowIndex].Cells[i].Value.ToString());
                i = 0;

                BookEditForm bookEditForm = new BookEditForm(book);
                bookEditForm.ShowDialog();

            }
        }



    }
}
