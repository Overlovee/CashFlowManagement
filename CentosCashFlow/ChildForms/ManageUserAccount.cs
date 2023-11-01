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

        public void Load_Data()
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            List<Models.UserAccountInfo> list = new List<Models.UserAccountInfo>();
            list = connectUsers.getUserAccountsInfo();
            foreach (Models.UserAccountInfo info in list)
            {
                Panel newPanel = new Panel();
                panelUserAccountsLoad.Controls.Add(newPanel);
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
            foreach (Control control in panelUserAccountsLoad.Controls)
            {
                control.Dispose();
            }

            panelUserAccountsLoad.Controls.Clear();

            Load_Data();
        }
        private void ManageUserAccount_Load(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
