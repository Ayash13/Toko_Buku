using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Buku
{
    public partial class CustomersForm : Form
    {
        public string CustomerID { get; private set; }

        public CustomersForm(string customerId)
        {
            InitializeComponent();
            CustomerID = customerId;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_transac_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm(CustomerID);
            transactionForm.TopLevel = false;
            transactionForm.FormBorderStyle = FormBorderStyle.None;
            transactionForm.Dock = DockStyle.Fill;

            panelContent.Controls.Clear();

            panelContent.Controls.Add(transactionForm);

            transactionForm.Show();
        }
    }
}
