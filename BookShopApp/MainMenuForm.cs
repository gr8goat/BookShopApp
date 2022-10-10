using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookShopApp
{
    public partial class MainMenuForm : Form
    {
        
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customerManageBtn_Click(object sender, EventArgs e)
        {
            CustomersManageForm customersManageForm = new CustomersManageForm();
            customersManageForm.ShowDialog();
        }

        private void booksPurchaseBtn_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.ShowDialog();
        }

        private void booksManageBtn_Click(object sender, EventArgs e)
        {
            BooksManageForm booksManageForm = new BooksManageForm();
            booksManageForm.ShowDialog();
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            LoginForm loginForm = new LoginForm();
            loginForm.showForm();
        }

        private void orderViewerBtn_Click(object sender, EventArgs e)
        {
            OrderManageForm orderManageForm = new OrderManageForm();
            orderManageForm.ShowDialog();
        }
    }
}
