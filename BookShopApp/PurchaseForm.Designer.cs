namespace BookShopApp
{
    partial class PurchaseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerSearchBtn = new System.Windows.Forms.Button();
            this.customerIdTextbox = new System.Windows.Forms.TextBox();
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.purchaseGridView = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.totalPriceTextbox = new System.Windows.Forms.TextBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerSearchBtn
            // 
            this.customerSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerSearchBtn.Location = new System.Drawing.Point(247, 30);
            this.customerSearchBtn.Name = "customerSearchBtn";
            this.customerSearchBtn.Size = new System.Drawing.Size(89, 30);
            this.customerSearchBtn.TabIndex = 9;
            this.customerSearchBtn.Text = "ค้นหา";
            this.customerSearchBtn.UseVisualStyleBackColor = true;
            this.customerSearchBtn.Click += new System.EventHandler(this.customerSearchBtn_Click);
            // 
            // customerIdTextbox
            // 
            this.customerIdTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIdTextbox.Location = new System.Drawing.Point(29, 31);
            this.customerIdTextbox.Name = "customerIdTextbox";
            this.customerIdTextbox.ReadOnly = true;
            this.customerIdTextbox.Size = new System.Drawing.Size(72, 29);
            this.customerIdTextbox.TabIndex = 7;
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextbox.Location = new System.Drawing.Point(107, 31);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.ReadOnly = true;
            this.customerNameTextbox.Size = new System.Drawing.Size(134, 29);
            this.customerNameTextbox.TabIndex = 8;
            // 
            // purchaseGridView
            // 
            this.purchaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.BookTitle,
            this.BookPrice,
            this.PurchaseQuantity,
            this.TotalPrice,
            this.Edit,
            this.Delete});
            this.purchaseGridView.Location = new System.Drawing.Point(29, 72);
            this.purchaseGridView.Name = "purchaseGridView";
            this.purchaseGridView.Size = new System.Drawing.Size(740, 277);
            this.purchaseGridView.TabIndex = 10;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            this.ISBN.Width = 140;
            // 
            // BookTitle
            // 
            this.BookTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookTitle.HeaderText = "Title";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            // 
            // BookPrice
            // 
            this.BookPrice.HeaderText = "Price";
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.ReadOnly = true;
            this.BookPrice.Width = 80;
            // 
            // PurchaseQuantity
            // 
            this.PurchaseQuantity.HeaderText = "Quantity";
            this.PurchaseQuantity.Name = "PurchaseQuantity";
            this.PurchaseQuantity.ReadOnly = true;
            this.PurchaseQuantity.Width = 60;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // Edit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "EDIT";
            this.Edit.DefaultCellStyle = dataGridViewCellStyle1;
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "EDIT";
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "DELETE";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "DELETE";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemBtn.Location = new System.Drawing.Point(639, 26);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(130, 40);
            this.addItemBtn.TabIndex = 11;
            this.addItemBtn.Text = "เพิ่มรายการ";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseBtn.Location = new System.Drawing.Point(247, 401);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(130, 40);
            this.purchaseBtn.TabIndex = 12;
            this.purchaseBtn.Text = "สั่งซื้อ";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(383, 401);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(130, 40);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "ยกเลิก";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // totalPriceTextbox
            // 
            this.totalPriceTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceTextbox.Location = new System.Drawing.Point(635, 355);
            this.totalPriceTextbox.Name = "totalPriceTextbox";
            this.totalPriceTextbox.ReadOnly = true;
            this.totalPriceTextbox.Size = new System.Drawing.Size(134, 29);
            this.totalPriceTextbox.TabIndex = 14;
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(553, 358);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(76, 24);
            this.totalPriceLabel.TabIndex = 15;
            this.totalPriceLabel.Text = "ราคาสุทธิ";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(342, 31);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(89, 30);
            this.refreshBtn.TabIndex = 16;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 463);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalPriceTextbox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.addItemBtn);
            this.Controls.Add(this.purchaseGridView);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.customerSearchBtn);
            this.Controls.Add(this.customerIdTextbox);
            this.Name = "PurchaseForm";
            this.Text = "สั่งซื้อสินค้า";
            ((System.ComponentModel.ISupportInitialize)(this.purchaseGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button customerSearchBtn;
        private System.Windows.Forms.TextBox customerIdTextbox;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.DataGridView purchaseGridView;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox totalPriceTextbox;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Button refreshBtn;
    }
}