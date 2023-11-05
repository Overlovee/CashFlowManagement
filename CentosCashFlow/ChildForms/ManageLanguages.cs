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
    public partial class ManageLanguages : Form
    {
        public ManageLanguages()
        {
            InitializeComponent();
        }

        private void Load_Data()
        {
            Models.ConnectLanguage connectLanguage = new Models.ConnectLanguage();
            List<Models.Language> list = connectLanguage.getData();
            foreach (Models.Language language in list)
            {
                Panel newPanel = new Panel();
                panelLanguagesLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                LanguageItem item = new LanguageItem();
                item.LanguageModel = language;

                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }

        public void Reload_Data()
        {
            foreach (Control control in panelLanguagesLoad.Controls)
            {
                control.Dispose();
            }

            panelLanguagesLoad.Controls.Clear();

            Load_Data();
        }
        private void ManageLanguages_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnAddNewLanguage_Click(object sender, EventArgs e)
        {
            LanguageAddingForm form = new LanguageAddingForm();
            form.ShowDialog();
            if(form.isChanged)
            {
                Reload_Data();
            }
        }
    }
}
