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
    public partial class addCustomerForm : Form
    {
        public addCustomerForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string fullname = fullnameTextbox.Text;
            string address = addressTextbox.Text;
            string email = emailTextbox.Text;
            DataAccess.AddCustomer(fullname, address, email);
            MessageBox.Show("เพิ่มลูกค้าเรียบร้อย!");
            this.Close();
        }

    }
}
