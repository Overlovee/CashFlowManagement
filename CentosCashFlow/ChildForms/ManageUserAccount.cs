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
    public partial class ManageUserAccount : Form
    {
        public ManageUserAccount()
        {
            InitializeComponent();
        }

        private void ManageUserAccount_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Panel newPanel = new Panel();
                panelUserAccountsLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                UserAccountItem transaction = new UserAccountItem();

                newPanel.Controls.Add(transaction);
                transaction.Dock = DockStyle.Top;
                transaction.Height = 60;
            }
        }
    }
}
