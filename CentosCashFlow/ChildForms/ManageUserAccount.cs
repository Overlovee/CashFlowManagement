﻿using CentosCashFlow.Models;
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
    public partial class ManageUserAccount : Form
    {
        public Models.Settings userSettings { get; set; }
        public Languages.LanguageDictionary dictionary { get; set; }
        public ManageUserAccount()
        {
            InitializeComponent();
            userSettings = new Models.Settings();
            dictionary = new Languages.LanguageDictionary();
        }

        public void Load_Data(bool isSearched)
        {
            Models.ConnectUsers connectUsers = new Models.ConnectUsers();
            userSettings = connectUsers.getUserSettingsByID(int.Parse(this.Tag.ToString()));
            dictionary = new Languages.LanguageDictionary(userSettings.LanguageCode);
            dictionary.SetLanguages((Control)this);

            List<Models.UserAccountInfo> list = new List<Models.UserAccountInfo>();
            if (isSearched)
            {
                list = connectUsers.getUserAccountsInfoByName(textBoxSearch.Text);
            }
            else
            {
                list = connectUsers.getUserAccountsInfo();
            }
            
            foreach (Models.UserAccountInfo info in list)
            {
                Panel newPanel = new Panel();
                panelUserAccountsLoad.Controls.Add(newPanel);
                newPanel.Dock = DockStyle.Top;
                newPanel.Height = 80;

                UserAccountItem item = new UserAccountItem();
                item.user = info;
                item.Tag = this.Tag;
                newPanel.Controls.Add(item);
                item.Dock = DockStyle.Top;
                item.Height = 60;
            }
        }
        public void Reload_Data(bool isSearched)
        {
            foreach (Control control in panelUserAccountsLoad.Controls)
            {
                control.Dispose();
            }

            panelUserAccountsLoad.Controls.Clear();

            Load_Data(isSearched);
        }
        private void ManageUserAccount_Load(object sender, EventArgs e)
        {
            Load_Data(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(textBoxSearch.Text != "")
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
