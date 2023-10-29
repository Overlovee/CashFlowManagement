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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void btnIncomeAdding_Click(object sender, EventArgs e)
        {
            CategoryAddingForm form= new CategoryAddingForm();
            form.ShowDialog();
        }

        private void btnExpendituresAdding_Click(object sender, EventArgs e)
        {
            CategoryAddingForm form = new CategoryAddingForm();
            form.ShowDialog();
        }

        private void Category_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Panel newPanel = new Panel();
                panelIncomeCategoryItem.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 70;

                CategoryItem item = new CategoryItem();

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 50;
            }
            for (int i = 0; i < 10; i++)
            {
                Panel newPanel = new Panel();
                panelExpendituresCategoryItem.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 70;

                CategoryItem item = new CategoryItem();

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 50;
            }
        }
    }
}
