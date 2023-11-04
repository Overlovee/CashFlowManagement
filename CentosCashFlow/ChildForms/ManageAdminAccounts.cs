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
    public partial class ManageAdminAccounts : Form
    {
        public ManageAdminAccounts()
        {
            InitializeComponent();
        }
        public void Load_Data()
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            List<Models.UserAccountInfo> list = new List<Models.UserAccountInfo>();
            list = connectUsers.getAdminAccountsInfo();
            foreach (Models.UserAccountInfo info in list)
            {
                Panel newPanel = new Panel();
                panelAdminAccountsLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                UserAccountItem item = new UserAccountItem();
                item.user = info;
                item.Tag = this.Tag;
                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }
        public void Reload_Data()
        {
            foreach (Control control in panelAdminAccountsLoad.Controls)
            {
                control.Dispose();
            }

            panelAdminAccountsLoad.Controls.Clear();

            Load_Data();
        }
        private void ManageAdminAccounts_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
            NewAdminAccountAddingForm form = new NewAdminAccountAddingForm();
            form.ShowDialog();
            if (form.isChanged)
            {
                this.Reload_Data();
            }
        }
    }
}
