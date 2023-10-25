using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashFlowManagementProject.ChildForms
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            cbbLanguages.SelectedIndex = 1;
            cbbLanguages.ItemHeight= 40;
            cbbExport.SelectedIndex = 0;
            cbbExport.ItemHeight = 40;
            cbbTimeFormat.SelectedIndex = 0;
            cbbTimeFormat.ItemHeight = 40;
            cbbCurrencyUnit.SelectedIndex = 0;
            cbbCurrencyUnit.ItemHeight = 40;
            cbbOverviewDisplayMode.SelectedIndex = 0;
            cbbOverviewDisplayMode.ItemHeight = 40;
        }
    }
}
