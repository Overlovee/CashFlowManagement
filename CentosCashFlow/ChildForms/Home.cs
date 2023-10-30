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
        public Models.Settings userSettings { get; set; }
        public Home()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            Models.ConnectTransaction connect = new Models.ConnectTransaction();
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            userSettings = connectUsers.getUserSettingsByID(int.Parse(this.Tag.ToString()));
            List<Models.Transaction> list = connect.getCurrentDataByID(int.Parse(this.Tag.ToString()));

            foreach (Models.Transaction transaction in list)
            {
                Panel newPanel = new Panel();
                panelCurrentTransactions.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                TransactionItem item = new TransactionItem();
                item.TransModel = transaction;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
        private void btnAddNewTransaction_Click(object sender, EventArgs e)
        {
            TransactionAddingChildForm form = new TransactionAddingChildForm();
            form.ShowDialog();
        }
    }
}
