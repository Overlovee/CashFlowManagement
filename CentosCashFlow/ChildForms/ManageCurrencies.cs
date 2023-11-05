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
    public partial class ManageCurrencies : Form
    {
        public ManageCurrencies()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
            List<Models.Currency> list = connectCurrency.getData();
            foreach (Models.Currency currency in list)
            {
                Panel newPanel = new Panel();
                panelCurrenciesLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                CurrencyItem item = new CurrencyItem();
                item.currency = currency;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }

        public void Reload_Data()
        {
            foreach (Control control in panelCurrenciesLoad.Controls)
            {
                control.Dispose();
            }

            panelCurrenciesLoad.Controls.Clear();

            Load_Data();
        }
        private void ManageCurrencies_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnAddNewCurrency_Click(object sender, EventArgs e)
        {
            CurrencyAddingForm form = new CurrencyAddingForm();
            form.ShowDialog();
            if (form.isChanged)
            {
                Reload_Data();
            }
        }
    }
}
