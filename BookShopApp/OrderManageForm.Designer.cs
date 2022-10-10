namespace BookShopApp
{
    partial class OrderManageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(277, 21);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(89, 30);
            this.searchBtn.TabIndex = 14;
            this.searchBtn.Text = "ค้นหา";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(132, 21);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(134, 29);
            this.searchTextbox.TabIndex = 13;
            // 
            // searchComboBox
            // 
            this.searchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "Order_Id",
            "Customer_Id"});
            this.searchComboBox.Location = new System.Drawing.Point(30, 21);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(91, 28);
            this.searchComboBox.TabIndex = 12;
            // 
            // ordersGridView
            // 
            this.ordersGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.ordersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.CustomerId,
            this.BookISBN,
            this.BookTitle,
            this.Quantity,
            this.TotalPrice});
            this.ordersGridView.Location = new System.Drawing.Point(28, 61);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.Size = new System.Drawing.Size(886, 394);
            this.ordersGridView.TabIndex = 11;
            // 
            // OrderId
            // 
            this.OrderId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OrderId.DataPropertyName = "orderId";
            this.OrderId.HeaderText = "Order ID";
            this.OrderId.Name = "OrderId";
            this.OrderId.ReadOnly = true;
            this.OrderId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OrderId.Width = 80;
            // 
            // CustomerId
            // 
            this.CustomerId.DataPropertyName = "customerId";
            this.CustomerId.HeaderText = "Customer ID";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // BookISBN
            // 
            this.BookISBN.DataPropertyName = "bookISBN";
            this.BookISBN.HeaderText = "ISBN";
            this.BookISBN.Name = "BookISBN";
            this.BookISBN.ReadOnly = true;
            this.BookISBN.Width = 200;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTitle.DataPropertyName = "bookTitle";
            this.BookTitle.HeaderText = "Title";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // OrderManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 477);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.ordersGridView);
            this.Name = "OrderManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderManageForm";
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}