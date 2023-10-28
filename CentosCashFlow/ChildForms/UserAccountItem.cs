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
        public UserAccountItem()
        {
            InitializeComponent();
        }

        private void btnEditingUserAccount_Click(object sender, EventArgs e)
        {
            UserAccountEditingForm form = new UserAccountEditingForm();
            form.ShowDialog();
        }
    }
}
