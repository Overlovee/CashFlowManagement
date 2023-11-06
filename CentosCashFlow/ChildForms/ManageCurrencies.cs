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
    public partial class ManageCurrencies : Form
    {
        public ManageCurrencies()
        {
            InitializeComponent();
        }

        private void Load_Data(bool isSearched)
        {
            Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
            List<Models.Currency> list = new List<Models.Currency>();
            if (isSearched)
            {
                list = connectCurrency.getDataByNameOrID(textBoxSearch.Text);
            }
            else
            {
                list = connectCurrency.getData();
            }
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

        public void Reload_Data(bool isSearched)
        {
            foreach (Control control in panelCurrenciesLoad.Controls)
            {
                control.Dispose();
            }

            panelCurrenciesLoad.Controls.Clear();

            Load_Data(isSearched);
        }
        private void ManageCurrencies_Load(object sender, EventArgs e)
        {
            Load_Data(false);
        }

        private void btnAddNewCurrency_Click(object sender, EventArgs e)
        {
            CurrencyAddingForm form = new CurrencyAddingForm();
            form.ShowDialog();
            if (form.isChanged)
            {
                Reload_Data(false);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                Reload_Data(true);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            Reload_Data(false);
        }
    }
}
