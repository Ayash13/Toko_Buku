﻿namespace Toko_Buku
{
    partial class CustomersForm
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_history = new System.Windows.Forms.Button();
            this.btn_transac = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Location = new System.Drawing.Point(318, 15);
            this.panelContent.Margin = new System.Windows.Forms.Padding(6);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1734, 927);
            this.panelContent.TabIndex = 12;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
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
            this.splitContainer1.Panel2.Controls.Add(this.btn_history);
            this.splitContainer1.Panel2.Controls.Add(this.btn_transac);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(306, 942);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "MENU";
            // 
            // btn_history
            // 
            this.btn_history.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_history.FlatAppearance.BorderSize = 3;
            this.btn_history.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_history.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_history.ForeColor = System.Drawing.Color.White;
            this.btn_history.Location = new System.Drawing.Point(24, 462);
            this.btn_history.Margin = new System.Windows.Forms.Padding(6);
            this.btn_history.Name = "btn_history";
            this.btn_history.Size = new System.Drawing.Size(258, 379);
            this.btn_history.TabIndex = 8;
            this.btn_history.Text = "Riwayat Transaksi";
            this.btn_history.UseVisualStyleBackColor = true;
            this.btn_history.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_transac
            // 
            this.btn_transac.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_transac.FlatAppearance.BorderSize = 3;
            this.btn_transac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transac.Font = new System.Drawing.Font("Sitka Text", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transac.ForeColor = System.Drawing.Color.White;
            this.btn_transac.Location = new System.Drawing.Point(24, 25);
            this.btn_transac.Margin = new System.Windows.Forms.Padding(6);
            this.btn_transac.Name = "btn_transac";
            this.btn_transac.Size = new System.Drawing.Size(258, 400);
            this.btn_transac.TabIndex = 6;
            this.btn_transac.Text = "Transaksi";
            this.btn_transac.UseVisualStyleBackColor = true;
            this.btn_transac.Click += new System.EventHandler(this.btn_transac_Click);
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(2066, 956);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Form";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_history;
        private System.Windows.Forms.Button btn_transac;
    }
}