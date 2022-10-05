using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopApp
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
        public int bookIndex { get; set; }

        public Book() {}

        public Book(string ISBN, string Title, double Price, int Quantity, double TotalPrice, int bookIndex)
        {
            this.ISBN = ISBN;
            this.Title = Title;
            this.Price = Price;
            this.Quantity = Quantity;
            this.TotalPrice = TotalPrice;
            this.bookIndex = bookIndex;
        }

    }
}
