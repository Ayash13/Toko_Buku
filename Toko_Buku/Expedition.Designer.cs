﻿namespace Toko_Buku
{
    partial class Expedition
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
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbx_search = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txbx_price = new System.Windows.Forms.TextBox();
            this.txbx_expedition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_eta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_admin = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_search.Location = new System.Drawing.Point(1416, 765);
            this.btn_search.Margin = new System.Windows.Forms.Padding(6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(212, 102);
            this.btn_search.TabIndex = 60;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightCoral;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(1182, 765);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(210, 102);
            this.btn_delete.TabIndex = 59;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(918, 675);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 55);
            this.label7.TabIndex = 58;
            this.label7.Text = "ID Expedition";
            // 
            // txbx_search
            // 
            this.txbx_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_search.Location = new System.Drawing.Point(1182, 679);
            this.txbx_search.Margin = new System.Windows.Forms.Padding(6);
            this.txbx_search.Name = "txbx_search";
            this.txbx_search.Size = new System.Drawing.Size(442, 44);
            this.txbx_search.TabIndex = 57;
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Moccasin;
            this.btn_clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Location = new System.Drawing.Point(676, 546);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(188, 102);
            this.btn_clear.TabIndex = 56;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_update.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Location = new System.Drawing.Point(388, 546);
            this.btn_update.Margin = new System.Windows.Forms.Padding(6);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(252, 102);
            this.btn_update.TabIndex = 55;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Location = new System.Drawing.Point(108, 546);
            this.btn_add.Margin = new System.Windows.Forms.Padding(6);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(240, 102);
            this.btn_add.TabIndex = 54;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(932, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(698, 458);
            this.dataGridView1.TabIndex = 53;
            // 
            // txbx_price
            // 
            this.txbx_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_price.Location = new System.Drawing.Point(388, 438);
            this.txbx_price.Margin = new System.Windows.Forms.Padding(6);
            this.txbx_price.Name = "txbx_price";
            this.txbx_price.Size = new System.Drawing.Size(472, 44);
            this.txbx_price.TabIndex = 50;
            // 
            // txbx_expedition
            // 
            this.txbx_expedition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_expedition.Location = new System.Drawing.Point(388, 273);
            this.txbx_expedition.Margin = new System.Windows.Forms.Padding(6);
            this.txbx_expedition.Name = "txbx_expedition";
            this.txbx_expedition.Size = new System.Drawing.Size(472, 44);
            this.txbx_expedition.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(100, 435);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 55);
            this.label4.TabIndex = 45;
            this.label4.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 55);
            this.label2.TabIndex = 44;
            this.label2.Text = "Expedition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 55);
            this.label3.TabIndex = 43;
            this.label3.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 92);
            this.label1.TabIndex = 42;
            this.label1.Text = "Manage Expedition";
            // 
            // txbx_eta
            // 
            this.txbx_eta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_eta.Location = new System.Drawing.Point(388, 354);
            this.txbx_eta.Margin = new System.Windows.Forms.Padding(6);
            this.txbx_eta.Name = "txbx_eta";
            this.txbx_eta.Size = new System.Drawing.Size(472, 44);
            this.txbx_eta.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(100, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 55);
            this.label5.TabIndex = 61;
            this.label5.Text = "ETA";
            // 
            // cbx_admin
            // 
            this.cbx_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_admin.FormattingEnabled = true;
            this.cbx_admin.Location = new System.Drawing.Point(388, 197);
            this.cbx_admin.Margin = new System.Windows.Forms.Padding(6);
            this.cbx_admin.Name = "cbx_admin";
            this.cbx_admin.Size = new System.Drawing.Size(472, 45);
            this.cbx_admin.TabIndex = 63;
            // 
            // Expedition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1744, 935);
            this.Controls.Add(this.cbx_admin);
            this.Controls.Add(this.txbx_eta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbx_search);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txbx_price);
            this.Controls.Add(this.txbx_expedition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Expedition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expedition";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbx_search;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txbx_price;
        private System.Windows.Forms.TextBox txbx_expedition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_eta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_admin;
    }
}