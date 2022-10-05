using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Documents;

namespace BookShopApp
{
    public partial class BookFinderFrom : Form
    {
        string thisFormTable = "Books";
        public string ISBN { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }


        public BookFinderFrom()
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
                booksGridView.Rows.Add(strings[0], strings[1], strings[2], strings[3], 0);
            }
        }

        public void SearchData()
        {
            string searchOption = searchComboBox.Text;

            string value = searchTextbox.Text;

            List<String> booksData = DataAccess.GetSearchData(thisFormTable, searchOption, value);

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

        private void booksGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /// If select button is clicked
            if (e.ColumnIndex == 5 && e.RowIndex >= 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to select this item ??",
                                     "Confirm Cancel!!",
                                     MessageBoxButtons.YesNo);
                int quantity = 0;

                bool success = int.TryParse(booksGridView.Rows[e.RowIndex].Cells[4].Value.ToString(), out quantity);
                if (!success)
                {
                    MessageBox.Show("กรุณากรอกตัวเลข");
                } else
                {
                    this.TotalPrice = this.Price * this.Quantity;
                    if (confirmResult == DialogResult.Yes)
                    {
                        this.ISBN = booksGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                        this.Title = booksGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                        this.Price = Double.Parse(booksGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                        this.Quantity = quantity;
                        this.TotalPrice = this.Price * this.Quantity;
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        // If 'No', do nothing.
                    }
                }

            }
        }

    }
}
