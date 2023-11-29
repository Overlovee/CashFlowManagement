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
    public partial class UserAccountItem : UserControl
    {
        public Models.UserAccountInfo user { get; set; }
        public UserAccountItem()
        {
            InitializeComponent();
            user= new Models.UserAccountInfo();
        }

        private void btnEditingUserAccount_Click(object sender, EventArgs e)
        {
            UserAccountEditingForm form = new UserAccountEditingForm();
            form.user = user;
            form.Tag = this.Tag;
            form.ShowDialog();
            if (form.isChanged)
            {
                Control control = (Control)this;
                while (control.Parent != null && !(control.Parent is Form))
                {
                    control = control.Parent;
                }
                // Kiểm tra xem control.Parent có phải là Form
                if (control.Parent is Form)
                {
                    if (control.Parent is ManageUserAccount)
                    {
                        ManageUserAccount f = (ManageUserAccount)control.Parent;

                        f.Reload_Data(false);
                    }
                    if (control.Parent is ManageAdminAccounts)
                    {
                        ManageAdminAccounts f = (ManageAdminAccounts)control.Parent;

                        f.Reload_Data(false);
                    }
                }
            }
        }

        private void UserAccountItem_Load(object sender, EventArgs e)
        {
            labelUserName.Text = user.UserName;
            labelUserEmail.Text = user.Email;
        }

        private void btnDisableUserAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
