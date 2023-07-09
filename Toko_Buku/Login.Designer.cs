namespace Toko_Buku
{
    partial class Login
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
            this.txbx_password = new System.Windows.Forms.TextBox();
            this.btn_masuk = new System.Windows.Forms.Button();
            this.txbx_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbx_password
            // 
            this.txbx_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_password.Location = new System.Drawing.Point(492, 437);
            this.txbx_password.Margin = new System.Windows.Forms.Padding(6);
            this.txbx_password.Name = "txbx_password";
            this.txbx_password.Size = new System.Drawing.Size(400, 50);
            this.txbx_password.TabIndex = 16;
            this.txbx_password.TextChanged += new System.EventHandler(this.txbx_password_TextChanged);
            // 
            // btn_masuk
            // 
            this.btn_masuk.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_masuk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_masuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_masuk.Location = new System.Drawing.Point(366, 581);
            this.btn_masuk.Margin = new System.Windows.Forms.Padding(6);
            this.btn_masuk.Name = "btn_masuk";
            this.btn_masuk.Size = new System.Drawing.Size(530, 85);
            this.btn_masuk.TabIndex = 15;
            this.btn_masuk.Text = "Login";
            this.btn_masuk.UseVisualStyleBackColor = false;
            this.btn_masuk.Click += new System.EventHandler(this.btn_masuk_Click);
            // 
            // txbx_username
            // 
            this.txbx_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbx_username.Location = new System.Drawing.Point(492, 351);
            this.txbx_username.Margin = new System.Windows.Forms.Padding(6);
            this.txbx_username.Name = "txbx_username";
            this.txbx_username.Size = new System.Drawing.Size(400, 50);
            this.txbx_username.TabIndex = 14;
            this.txbx_username.TextChanged += new System.EventHandler(this.txbx_username_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(198, 437);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 55);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Subheading", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(198, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 55);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Moccasin;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(208, 581);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(6);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(146, 85);
            this.btn_clear.TabIndex = 18;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Subheading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(456, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 92);
            this.label2.TabIndex = 21;
            this.label2.Text = "LOGIN";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1127, 761);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txbx_password);
            this.Controls.Add(this.btn_masuk);
            this.Controls.Add(this.txbx_username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbx_password;
        private System.Windows.Forms.Button btn_masuk;
        private System.Windows.Forms.TextBox txbx_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label2;
    }
}