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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void linkLabelChangingPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangingPasswordForm form = new ChangingPasswordForm();
            form.ShowDialog();
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "",
                  MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            }
        }
    }
}
