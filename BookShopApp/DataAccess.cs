using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Windows.Storage;
using Windows.UI.Xaml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BookShopApp
{
    class DataAccess
    {
        public async static void InitializeDatabase()
        {
            await ApplicationData.Current.LocalFolder.CreateFileAsync("bookStoreDb.db", CreationCollisionOption.OpenIfExists);
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "bookStoreDb.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                String tableCommand;
                SqliteCommand createTable;

                db.Open();

                // Create Book Table
                tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Books (ISBN NVARCHAR(64) NOT NULL PRIMARY KEY, " +
                    "Title NVARCHAR(64) NOT NULL, " +
                    "Description NVARCHAR(255) NULL, " +
                    "Price DOUBLE NOT NULL);";

                createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();

                // Create Customer Table
                tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Customers (Customer_Id INTEGER PRIMARY KEY AUTOINCREMENT, " +
                    "Customer_Name NVARCHAR(124) NOT NULL, " +
                    "Address NVARCHAR(255) NOT NULL, " +
                    "Email NVARCHAR(64) NOT NULL);";

                createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();

                // Create Transactions Table
                tableCommand = "CREATE TABLE IF NOT " +
                    "EXISTS Transactions (ISBN NVARCHAR(64) NOT NULL, " +
                    "Customer_Id INTEGER NOT NULL, " +
                    "Quantity INTEGER NOT NULL, " +
                    "Total_Price DOUBLE NOT NULL, " +
                    "FOREIGN KEY (ISBN) REFERENCES Books (ISBN), " +
                    "FOREIGN KEY (Customer_Id) REFERENCES Customers (Customer_Id));";

                createTable = new SqliteCommand(tableCommand, db);

                createTable.ExecuteReader();

                db.Close();
            }
        }

        public static void AddCustomer(string name, string address, string email)
        {
            // Might add a parameter to change table to use this function in other form

            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "bookStoreDb.db");
            using (SqliteConnection db =
              new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO Customers (Customer_Name, Address, Email) VALUES (@CustomerName, @CustomerAddress, @CustomerEmail);";
                insertCommand.Parameters.AddWithValue("@CustomerName", name);
                insertCommand.Parameters.AddWithValue("@CustomerAddress", address);
                insertCommand.Parameters.AddWithValue("@CustomerEmail", email);

                insertCommand.ExecuteReader();

                db.Close();
            }

        }

        public static void AddBook(string isbn, string title, string description, double price)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "bookStoreDb.db");
            using (SqliteConnection db =
              new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = "INSERT INTO Books (ISBN, Title, Description, Price) VALUES (@bookISBN, @bookTitle, @bookDescription, @bookPrice);";
                insertCommand.Parameters.AddWithValue("@bookISBN", isbn);
                insertCommand.Parameters.AddWithValue("@bookTitle", title);
                insertCommand.Parameters.AddWithValue("@bookDescription", description);
                insertCommand.Parameters.AddWithValue("@bookPrice", price);

                insertCommand.ExecuteReader();

                db.Close();
            }
        }

        public static List<String> GetAllData(string table)
        {
            List<String> entries = new List<string>();

            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "bookStoreDb.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand selectCommand = new SqliteCommand
                    ($"SELECT * from {table}", db);

                SqliteDataReader query = selectCommand.ExecuteReader();

                while (query.Read())
                {
                    string formatedString = String.Concat(query.GetString(0),",",query.GetString(1),",",query.GetString(2),",",query.GetString(3));
                    entries.Add(formatedString);
                }

                db.Close();

            }

            return entries;
        }

        public static List<String> GetSearchData(string table, string searchOption, string value)
        {
            List<String> entries = new List<string>();

            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "bookStoreDb.db");
            using (SqliteConnection db =
               new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();
                string switchStatement = "";
                switch (searchOption)
                {
                    case "ID":
                    case "ISBN":
                        switchStatement = " = ";
                        break;
                    case "Name":
                    case "Address":
                    case "Email":
                    case "Title":
                        switchStatement = " LIKE '%";
                        value += "%'";
                        break;
                    default:
                        break;
                }

                SqliteCommand selectCommand = new SqliteCommand
                    ($"SELECT * from {table} WHERE {searchOption}{switchStatement}{value}", db);

                try
                {
                    SqliteDataReader query = selectCommand.ExecuteReader();
                    while (query.Read())
                    {
                        string formatedString = String.Concat(query.GetString(0), ",", query.GetString(1), ",", query.GetString(2), ",", query.GetString(3));
                        entries.Add(formatedString);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("กรุณาตรวจสอบข้อมูลที่ใช้ค้นหา");
                }


                db.Close();

            }

            return entries;
        }

        public static void DeleteData(string table, string primaryKey)
        {
            // need to add switch case to change condition


            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "bookStoreDb.db");
            using (SqliteConnection db =
              new SqliteConnection($"Filename={dbpath}"))
            {
                string queryOption = "";

                switch (table)
                {
                    case "Customers":
                        queryOption = "Customer_Id";
                        break;
                    case "Books":
                        queryOption = "ISBN";
                        break;
                    default:
                        break;
                
                }

                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;

                // Use parameterized query to prevent SQL injection attacks
                insertCommand.CommandText = $"DELETE FROM {table} WHERE {queryOption}={primaryKey};";
                insertCommand.ExecuteReader();

                db.Close();
            }
        }

        public static void UpdateData(string table, string primaryKey, string[] editedData)
        {
            string dbpath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "bookStoreDb.db");
            using (SqliteConnection db =
              new SqliteConnection($"Filename={dbpath}"))
            {
                db.Open();

                SqliteCommand insertCommand = new SqliteCommand();
                insertCommand.Connection = db;


                if (table == "Customers")
                {
                    insertCommand.CommandText = $"UPDATE {table} SET Customer_Name = '{editedData[0]}', Address = '{editedData[1]}', Email = '{editedData[2]}' WHERE Customer_Id={primaryKey};";
                } else if (table == "Books")
                {
                    insertCommand.CommandText = $"UPDATE {table} SET Title = '{editedData[0]}', Description = '{editedData[1]}', Price = '{editedData[2]}' WHERE ISBN={primaryKey};";
                }

                insertCommand.ExecuteReader();

                db.Close();
            }
        }

    }
}
