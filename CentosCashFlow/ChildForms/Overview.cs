using CentosCashFlow.Models;
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
        DbContext dbContext = new DbContext();
        public Overview()
        {
            InitializeComponent();
        }

        public void Load_Data()
        {
            int month = dateTimePickerOverview.Value.Month;
            int year = dateTimePickerOverview.Value.Year;

            labelIncomeMonth.Text = "Incomes in " + dateTimePickerOverview.Value.ToString("MM/yyyy");
            labelExpendituresMonth.Text = "Expenditures in " + dateTimePickerOverview.Value.ToString("MM/yyyy");

            string sql = "";
            DataTable dataTable = new DataTable();

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
        private void Overview_Load(object sender, EventArgs e)
        {
            dateTimePickerOverview.CustomFormat = "MM/yyyy";
            dateTimePickerOverview.Format = DateTimePickerFormat.Custom;
            dateTimePickerOverview.MaxDate = DateTime.Now.AddMonths(3);
            dateTimePickerOverview.Value = DateTime.Now;
            dateTimePickerOverview.MaxDate = DateTime.Today;
            Load_Data();
        }
    }
}
