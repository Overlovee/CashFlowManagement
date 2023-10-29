using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosCashFlow.ChildForms
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                Panel newPanel = new Panel();
                panelCurrentTransactions.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                TransactionItem transaction = new TransactionItem();
                
                newPanel.Controls.Add(transaction);
                transaction.Dock = DockStyle.Top;
                transaction.Height = 60;
            }
            
        }
        private void btnAddNewTransaction_Click(object sender, EventArgs e)
        {
            TransactionAddingChildForm form = new TransactionAddingChildForm();
            form.ShowDialog();
        }
    }
}
