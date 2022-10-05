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
    public partial class CustomerEditForm : Form
    {
        string thisFormTable = "Customers";
        public CustomerEditForm(Customer customer)
        {
            InitializeComponent(customer);
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            // update database
            string[] strings = { this.nameTextbox.Text, this.addressTextbox.Text, this.emailTextbox.Text };

            DataAccess.UpdateData (thisFormTable, this.idTextbox.Text, strings);
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
