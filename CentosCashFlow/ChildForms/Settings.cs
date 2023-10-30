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
    public partial class Settings : Form
    {
        public Models.Settings userSetting { get; set; }
        public Settings()
        {
            InitializeComponent();

            cbbLanguages.ItemHeight= 40;
            cbbExport.ItemHeight = 40;
            cbbTimeFormat.ItemHeight = 40;
            cbbCurrencyUnit.ItemHeight = 40;
            cbbOverviewDisplayMode.ItemHeight = 40;
            userSetting= new Models.Settings();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Models.ConnectLanguage connectLanguage = new Models.ConnectLanguage();
            List <Models.Language> languages = connectLanguage.getData();
            foreach (Models.Language language in languages)
            {
                cbbLanguages.Items.Add(language.Language_Name);
            }

            cbbTimeFormat.Items.Add("dd/mm/yyyy");
            cbbTimeFormat.Items.Add("mm/dd/yyyy");
            cbbTimeFormat.Items.Add("yyyy/mm/dd");

            Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
            List<Models.Currency> currencies = connectCurrency.getData();
            foreach (Models.Currency currency in currencies)
            {
                cbbCurrencyUnit.Items.Add(currency.CurrencyCode);
            }

            cbbOverviewDisplayMode.Items.Add("beginning/ending balance");
            cbbOverviewDisplayMode.Items.Add("money in/money out");

            cbbExport.Items.Add("Export Excel File");
            cbbExport.Items.Add("Export CSV File");
            cbbExport.SelectedItem = "Export Excel File";

            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            userSetting = connectUsers.getUserSettingsByID(int.Parse(this.Tag.ToString()));

            Language l = connectLanguage.getDataByID(userSetting.LanguageCode);
            cbbLanguages.SelectedItem = l.Language_Name;

            cbbCurrencyUnit.SelectedItem = userSetting.CurrencyCode;
            cbbTimeFormat.SelectedItem = userSetting.TimeFormat.ToString();
            cbbOverviewDisplayMode.SelectedItem = userSetting.OverviewDisplayMode;
        }
    }
}
