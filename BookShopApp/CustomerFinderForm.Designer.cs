namespace BookShopApp
{
    partial class CustomerFinderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.customersGridView = new System.Windows.Forms.DataGridView();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(255, 43);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(89, 30);
            this.searchBtn.TabIndex = 10;
            this.searchBtn.Text = "ค้นหา";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchTextbox
            // 
            this.searchTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.Location = new System.Drawing.Point(115, 43);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(134, 29);
            this.searchTextbox.TabIndex = 9;
            // 
            // searchComboBox
            // 
            this.searchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Address",
            "Email"});
            this.searchComboBox.Location = new System.Drawing.Point(38, 43);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(71, 28);
            this.searchComboBox.TabIndex = 8;
            // 
            // customersGridView
            // 
            this.customersGridView.BackgroundColor = System.Drawing.Color.LightGray;
            this.customersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerId,
            this.CustomerName,
            this.CustomerAddress,
            this.CustomerEmail,
            this.SelectBtn});
            this.customersGridView.Location = new System.Drawing.Point(36, 83);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.Size = new System.Drawing.Size(738, 379);
            this.customersGridView.TabIndex = 7;
            this.customersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGridView_CellClick);
            // 
            // customerId
            // 
            this.customerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customerId.DataPropertyName = "customerId";
            this.customerId.HeaderText = "ID";
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            this.customerId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerId.Width = 40;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "customerName";
            this.CustomerName.HeaderText = "Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 200;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "customerAddress";
            this.CustomerAddress.HeaderText = "Address";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.ReadOnly = true;
            this.CustomerAddress.Width = 260;
            // 
            // CustomerEmail
            // 
            this.CustomerEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerEmail.DataPropertyName = "customerEmail";
            this.CustomerEmail.HeaderText = "Email";
            this.CustomerEmail.Name = "CustomerEmail";
            this.CustomerEmail.ReadOnly = true;
            // 
            // SelectBtn
            // 
            this.SelectBtn.DataPropertyName = "selectBtn";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.NullValue = "SELECT";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gold;
            this.SelectBtn.DefaultCellStyle = dataGridViewCellStyle3;
            this.SelectBtn.HeaderText = "Select";
            this.SelectBtn.Name = "SelectBtn";
            this.SelectBtn.ReadOnly = true;
            this.SelectBtn.Text = "SELECT";
            this.SelectBtn.Width = 60;
            // 
            // CustomerFinderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 496);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.customersGridView);
            this.Name = "CustomerFinderForm";
            this.Text = "ค้นหาลูกค้า";
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.DataGridView customersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerEmail;
        private System.Windows.Forms.DataGridViewButtonColumn SelectBtn;
    }
}