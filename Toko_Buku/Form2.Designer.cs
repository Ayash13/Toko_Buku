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
            this.btn_customers = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_category = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_transaction
            // 
            this.btn_transaction.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_transaction.FlatAppearance.BorderSize = 3;
            this.btn_transaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transaction.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transaction.ForeColor = System.Drawing.Color.White;
            this.btn_transaction.Location = new System.Drawing.Point(12, 327);
            this.btn_transaction.Name = "btn_transaction";
            this.btn_transaction.Size = new System.Drawing.Size(129, 105);
            this.btn_transaction.TabIndex = 4;
            this.btn_transaction.Text = "Transaction";
            this.btn_transaction.UseVisualStyleBackColor = true;
            this.btn_transaction.Click += new System.EventHandler(this.btn_transaction_Click);
            // 
            // btn_product
            // 
            this.btn_product.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_product.FlatAppearance.BorderSize = 3;
            this.btn_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_product.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_product.ForeColor = System.Drawing.Color.White;
            this.btn_product.Location = new System.Drawing.Point(12, 94);
            this.btn_product.Name = "btn_product";
            this.btn_product.Size = new System.Drawing.Size(129, 65);
            this.btn_product.TabIndex = 5;
            this.btn_product.Text = "Product";
            this.btn_product.UseVisualStyleBackColor = true;
            this.btn_product.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // btn_expedition
            // 
            this.btn_expedition.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_expedition.FlatAppearance.BorderSize = 3;
            this.btn_expedition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_expedition.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_expedition.ForeColor = System.Drawing.Color.White;
            this.btn_expedition.Location = new System.Drawing.Point(12, 170);
            this.btn_expedition.Name = "btn_expedition";
            this.btn_expedition.Size = new System.Drawing.Size(129, 68);
            this.btn_expedition.TabIndex = 6;
            this.btn_expedition.Text = "Expedition";
            this.btn_expedition.UseVisualStyleBackColor = true;
            this.btn_expedition.Click += new System.EventHandler(this.btn_expedition_Click);
            // 
            // btn_customers
            // 
            this.btn_customers.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_customers.FlatAppearance.BorderSize = 3;
            this.btn_customers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customers.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customers.ForeColor = System.Drawing.Color.White;
            this.btn_customers.Location = new System.Drawing.Point(12, 250);
            this.btn_customers.Name = "btn_customers";
            this.btn_customers.Size = new System.Drawing.Size(129, 64);
            this.btn_customers.TabIndex = 8;
            this.btn_customers.Text = "Customers Data";
            this.btn_customers.UseVisualStyleBackColor = true;
            this.btn_customers.Click += new System.EventHandler(this.btn_customers_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.splitContainer1.Panel2.Controls.Add(this.btn_category);
            this.splitContainer1.Panel2.Controls.Add(this.btn_product);
            this.splitContainer1.Panel2.Controls.Add(this.btn_transaction);
            this.splitContainer1.Panel2.Controls.Add(this.btn_customers);
            this.splitContainer1.Panel2.Controls.Add(this.btn_expedition);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(153, 490);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "MENU";
            // 
            // btn_category
            // 
            this.btn_category.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_category.FlatAppearance.BorderSize = 3;
            this.btn_category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_category.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_category.ForeColor = System.Drawing.Color.White;
            this.btn_category.Location = new System.Drawing.Point(12, 17);
            this.btn_category.Name = "btn_category";
            this.btn_category.Size = new System.Drawing.Size(129, 66);
            this.btn_category.TabIndex = 7;
            this.btn_category.Text = "Category";
            this.btn_category.UseVisualStyleBackColor = true;
            this.btn_category.Click += new System.EventHandler(this.btn_transactionHistory_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Location = new System.Drawing.Point(160, 8);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(867, 482);
            this.panelContent.TabIndex = 10;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1035, 501);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.splitContainer1);
            this.Name = "form_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_menu";
            this.Load += new System.EventHandler(this.form_menu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_transaction;
        private System.Windows.Forms.Button btn_product;
        private System.Windows.Forms.Button btn_expedition;
        private System.Windows.Forms.Button btn_customers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button btn_category;
    }
}