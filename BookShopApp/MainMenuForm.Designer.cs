namespace BookShopApp
{
    partial class MainMenuForm
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
            this.customerManageBtn = new System.Windows.Forms.Button();
            this.booksManageBtn = new System.Windows.Forms.Button();
            this.booksPurchaseBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.orderViewerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerManageBtn
            // 
            this.customerManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerManageBtn.Location = new System.Drawing.Point(173, 112);
            this.customerManageBtn.Name = "customerManageBtn";
            this.customerManageBtn.Size = new System.Drawing.Size(206, 76);
            this.customerManageBtn.TabIndex = 0;
            this.customerManageBtn.Text = "จัดการข้อมูลลูกค้า";
            this.customerManageBtn.UseVisualStyleBackColor = true;
            this.customerManageBtn.Click += new System.EventHandler(this.customerManageBtn_Click);
            // 
            // booksManageBtn
            // 
            this.booksManageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksManageBtn.Location = new System.Drawing.Point(398, 112);
            this.booksManageBtn.Name = "booksManageBtn";
            this.booksManageBtn.Size = new System.Drawing.Size(206, 76);
            this.booksManageBtn.TabIndex = 1;
            this.booksManageBtn.Text = "จัดการข้อมูลหนังสือ";
            this.booksManageBtn.UseVisualStyleBackColor = true;
            this.booksManageBtn.Click += new System.EventHandler(this.booksManageBtn_Click);
            // 
            // booksPurchaseBtn
            // 
            this.booksPurchaseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksPurchaseBtn.Location = new System.Drawing.Point(173, 215);
            this.booksPurchaseBtn.Name = "booksPurchaseBtn";
            this.booksPurchaseBtn.Size = new System.Drawing.Size(206, 76);
            this.booksPurchaseBtn.TabIndex = 2;
            this.booksPurchaseBtn.Text = "สั่งซื้อหนังสือ";
            this.booksPurchaseBtn.UseVisualStyleBackColor = true;
            this.booksPurchaseBtn.Click += new System.EventHandler(this.booksPurchaseBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(661, 381);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(107, 43);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "ออกจากระบบ";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // orderViewerBtn
            // 
            this.orderViewerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderViewerBtn.Location = new System.Drawing.Point(398, 215);
            this.orderViewerBtn.Name = "orderViewerBtn";
            this.orderViewerBtn.Size = new System.Drawing.Size(206, 76);
            this.orderViewerBtn.TabIndex = 5;
            this.orderViewerBtn.Text = "ตรวจสอบรายการสั่งซื้อ";
            this.orderViewerBtn.UseVisualStyleBackColor = true;
            this.orderViewerBtn.Click += new System.EventHandler(this.orderViewerBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderViewerBtn);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.booksPurchaseBtn);
            this.Controls.Add(this.booksManageBtn);
            this.Controls.Add(this.customerManageBtn);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customerManageBtn;
        private System.Windows.Forms.Button booksManageBtn;
        private System.Windows.Forms.Button booksPurchaseBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button orderViewerBtn;
    }
}