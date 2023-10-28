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
    public partial class CategoryItem : UserControl
    {
        public CategoryItem()
        {
            InitializeComponent();
        }
        private void btnEditingCategory_Click(object sender, EventArgs e)
        {
            CategoryEditForm form = new CategoryEditForm();
            form.ShowDialog();
        }
    }
}
