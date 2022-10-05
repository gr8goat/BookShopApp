namespace BookShopApp
{
    partial class BookFinderFrom
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.BookISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(238, 33);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(89, 30);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "ค้นหา";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(98, 33);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(134, 29);
            this.searchTextbox.TabIndex = 15;
            // 
            // searchComboBox
            // 
            this.searchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "ISBN",
            "Title"});
            this.searchComboBox.Location = new System.Drawing.Point(21, 34);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(71, 28);
            this.searchComboBox.TabIndex = 14;
            // 
            // booksGridView
            // 
            this.booksGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.booksGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookISBN,
            this.BookTitle,
            this.BookDescription,
            this.BookPrice,
            this.BookQuantity,
            this.SelectBtn});
            this.booksGridView.Location = new System.Drawing.Point(22, 69);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.Size = new System.Drawing.Size(874, 363);
            this.booksGridView.TabIndex = 13;
            this.booksGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGridView_CellClick);
            // 
            // BookISBN
            // 
            this.BookISBN.DataPropertyName = "bookISBN";
            this.BookISBN.HeaderText = "ISBN";
            this.BookISBN.Name = "BookISBN";
            this.BookISBN.ReadOnly = true;
            this.BookISBN.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BookISBN.Width = 180;
            // 
            // BookTitle
            // 
            this.BookTitle.DataPropertyName = "bookTitle";
            this.BookTitle.HeaderText = "Title";
            this.BookTitle.Name = "BookTitle";
            this.BookTitle.ReadOnly = true;
            this.BookTitle.Width = 200;
            // 
            // BookDescription
            // 
            this.BookDescription.DataPropertyName = "bookDescription";
            this.BookDescription.HeaderText = "Description";
            this.BookDescription.Name = "BookDescription";
            this.BookDescription.ReadOnly = true;
            this.BookDescription.Width = 240;
            // 
            // BookPrice
            // 
            this.BookPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPrice.DataPropertyName = "bookPrice";
            this.BookPrice.HeaderText = "Price";
            this.BookPrice.MinimumWidth = 50;
            this.BookPrice.Name = "BookPrice";
            this.BookPrice.ReadOnly = true;
            // 
            // BookQuantity
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.BookQuantity.DefaultCellStyle = dataGridViewCellStyle1;
            this.BookQuantity.HeaderText = "Quantity";
            this.BookQuantity.Name = "BookQuantity";
            this.BookQuantity.Width = 60;
            // 
            // SelectBtn
            // 
            this.SelectBtn.DataPropertyName = "selectBtn";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.NullValue = "Select";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.SelectBtn.DefaultCellStyle = dataGridViewCellStyle2;
            this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectBtn.HeaderText = "Select";
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.ReadOnly = true;
            this.SelectBtn.Text = "SELECT";
            // 
            // BookFinderFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 461);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.booksGridView);
            this.Name = "BookFinderFrom";
            this.Text = "BookFinderFrom";
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookQuantity;
        private System.Windows.Forms.DataGridViewButtonColumn SelectBtn;
    }
}