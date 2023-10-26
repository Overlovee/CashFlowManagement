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
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Overview_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Panel newPanel = new Panel();
                panelTotalIncome.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                Wide wide = new Wide();

                newPanel.Controls.Add(wide);
                wide.Dock = DockStyle.Top;
                wide.Height = 60;
            }
            for (int i = 0; i < 10; i++)
            {
                Panel newPanel = new Panel();
                panelTotalExpenditures.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                Wide wide = new Wide();

                newPanel.Controls.Add(wide);
                wide.Dock = DockStyle.Top;
                wide.Height = 60;
            }
        }
    }
}
