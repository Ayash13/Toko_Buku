namespace Toko_Buku
{
    partial class form_menu
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
            this.btn_transaction = new System.Windows.Forms.Button();
            this.btn_product = new System.Windows.Forms.Button();
            this.btn_expedition = new System.Windows.Forms.Button();
            this.btn_transactionHistory = new System.Windows.Forms.Button();
            this.btn_customers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_transaction
            // 
            this.btn_transaction.Location = new System.Drawing.Point(160, 302);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Size = new System.Drawing.Size(460, 105);
            this.btn_transaction.TabIndex = 4;
            this.btn_transaction.Text = "Transaction";
            this.btn_transaction.UseVisualStyleBackColor = true;
            this.btn_transaction.Click += new System.EventHandler(this.btn_transaction_Click);
            // 
            // btn_product
            // 
            this.btn_product.Location = new System.Drawing.Point(160, 51);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(217, 105);
            this.btn_product.TabIndex = 5;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            // 
            // btn_expedition
            // 
            this.btn_expedition.Location = new System.Drawing.Point(402, 51);
            this.btn_expedition.Name = "btn_expedition";
            this.btn_expedition.Size = new System.Drawing.Size(218, 105);
            this.btn_expedition.TabIndex = 6;
            this.btn_expedition.Text = "Expedition";
            this.btn_expedition.UseVisualStyleBackColor = true;
            // 
            // btn_transactionHistory
            // 
            this.btn_transactionHistory.Location = new System.Drawing.Point(160, 177);
            this.btn_transactionHistory.Name = "btn_transactionHistory";
            this.btn_transactionHistory.Size = new System.Drawing.Size(217, 105);
            this.btn_transactionHistory.TabIndex = 7;
            this.btn_transactionHistory.Text = "Transaction History";
            this.btn_transactionHistory.UseVisualStyleBackColor = true;
            // 
            // btn_customers
            // 
            this.btn_customers.Location = new System.Drawing.Point(402, 177);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(218, 105);
            this.btn_customers.TabIndex = 8;
            this.btn_customers.Text = "Customers Data";
            this.btn_customers.UseVisualStyleBackColor = true;
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_customers);
            this.Controls.Add(this.btn_transactionHistory);
            this.Controls.Add(this.btn_expedition);
            this.Controls.Add(this.btn_product);
            this.Controls.Add(this.btn_transaction);
            this.Name = "form_menu";
            this.Text = "form_menu";
            this.Load += new System.EventHandler(this.form_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_transaction;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_expedition;
        private System.Windows.Forms.Button btn_transactionHistory;
        private System.Windows.Forms.Button btn_customers;
    }
}