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
        public Models.Language languageSetting { get; set; }
        public Languages.LanguageDictionary dictionary { get; set; }
        public Settings()
        {
            InitializeComponent();

            cbbLanguages.ItemHeight= 40;
            cbbExport.ItemHeight = 40;
            cbbTimeFormat.ItemHeight = 40;
            cbbCurrencyUnit.ItemHeight = 40;
            cbbOverviewDisplayMode.ItemHeight = 40;
            userSetting= new Models.Settings();
            languageSetting= new Models.Language();
            dictionary = new Languages.LanguageDictionary();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

            btnSave_display.Enabled = false;
            Models.ConnectLanguage connectLanguage = new Models.ConnectLanguage();
            List <Models.Language> languages = connectLanguage.getData();
            

            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            userSetting = connectUsers.getUserSettingsByID(int.Parse(this.Tag.ToString()));
            languageSetting = connectLanguage.getDataByID(userSetting.LanguageCode);

            dictionary = new Languages.LanguageDictionary(userSetting.LanguageCode);
            dictionary.SetLanguages((Control)this);

            foreach (Models.Language language in languages)
            {
                cbbLanguages.Items.Add(language.Language_Name);
            }

            Language l = connectLanguage.getDataByID(userSetting.LanguageCode);
            cbbLanguages.SelectedItem = l.Language_Name;
            cbbTimeFormat.Items.Add("dd/mm/yyyy");
            cbbTimeFormat.Items.Add("mm/dd/yyyy");
            cbbTimeFormat.Items.Add("yyyy/mm/dd");
            cbbTimeFormat.SelectedItem = userSetting.TimeFormat.ToString();

            Models.ConnectCurrency connectCurrency = new Models.ConnectCurrency();
            List<Models.Currency> currencies = connectCurrency.getData();
            foreach (Models.Currency currency in currencies)
            {
                cbbCurrencyUnit.Items.Add(currency.CurrencyCode);
            }
            cbbCurrencyUnit.SelectedItem = userSetting.CurrencyCode;

            cbbOverviewDisplayMode.Items.Add("beginning/ending balance");
            cbbOverviewDisplayMode.Items.Add("money in/money out");
            cbbOverviewDisplayMode.SelectedItem = userSetting.OverviewDisplayMode;

            cbbExport.Items.Add("Export Excel File");
            cbbExport.Items.Add("Export CSV File");
            cbbExport.SelectedItem = "Export Excel File";
        }

        private void cbbOverviewDisplayMode_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!(cbbLanguages.SelectedItem is null)
                && !(cbbCurrencyUnit.SelectedItem is null)
                && !(cbbTimeFormat.SelectedItem is null)
                && !(cbbOverviewDisplayMode.SelectedItem is null))
            {
                if (cbbLanguages.SelectedItem.ToString() != languageSetting.Language_Name
                || cbbCurrencyUnit.SelectedItem.ToString() != userSetting.CurrencyCode
                || cbbTimeFormat.SelectedItem.ToString() != userSetting.TimeFormat
                || cbbOverviewDisplayMode.SelectedItem.ToString() != userSetting.OverviewDisplayMode)
                {
                    btnSave_display.Enabled = true;
                }
                else
                {
                    btnSave_display.Enabled = false;
                }
            }
            else
            {
                btnSave_display.Enabled = false;
            }
        }

        private void btnSave_display_Click(object sender, EventArgs e)
        {
            Models.ConnectLanguage connectLanguage = new Models.ConnectLanguage();
            Models.Language languages = connectLanguage.getDataByName(cbbLanguages.SelectedItem.ToString());
            string pre_LanguageCode = userSetting.LanguageCode;

            userSetting.LanguageCode = languages.Language_Code;
            userSetting.TimeFormat = cbbTimeFormat.SelectedItem.ToString();
            userSetting.CurrencyCode = cbbCurrencyUnit.SelectedItem.ToString();
            userSetting.OverviewDisplayMode = cbbOverviewDisplayMode.SelectedItem.ToString();

            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            int kt = connectUsers.updateUserSettingsFor(userSetting);
            if(kt != 0)
            {
                MessageBox.Show("Completely editing!", "", MessageBoxButtons.OK);

                if (pre_LanguageCode != userSetting.LanguageCode)
                {
                    Control control = (Control)this;
                    while (control.Parent != null && !(control.Parent is Form))
                    {
                        control = control.Parent;
                    }
                    // Kiểm tra xem control.Parent có phải là Form
                    if (control.Parent is Form)
                    {
                        if (control.Parent is Menu)
                        {
                            Menu f = (Menu)control.Parent;

                            f.Reload_Form();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Cannot edit!", "", MessageBoxButtons.OK);
            }
        }
    }
}
