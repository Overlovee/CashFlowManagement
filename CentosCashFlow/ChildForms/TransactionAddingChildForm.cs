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
    public partial class TransactionAddingChildForm : Form
    {
        public TransactionAddingChildForm()
        {
            InitializeComponent();
        }

        private void TransactionAddingChildForm_Load(object sender, EventArgs e)
        {
            textBoxDateTime.Text = DateTime.Now.Date.ToString("d");
            comboBoxTransactionType.Items.Clear();
            comboBoxTransactionType.Items.Add("Income");
            comboBoxTransactionType.Items.Add("Expenditure");
            comboBoxTransactionType.SelectedItem = "Expenditure";
            comboBoxCategory.Items.Clear();
            ConnectCategory connect = new ConnectCategory();
            if (comboBoxTransactionType.SelectedItem.ToString() == "Expenditure")
            {
                List<Models.Category> list = connect.getExpenditureTypeData();
                foreach(Models.Category category in list) {
                    comboBoxCategory.Items.Add(category.CategoryName);
                }
            }
            else
            {
                List<Models.Category> list = connect.getIncomeTypeData();
                foreach (Models.Category category in list)
                {
                    comboBoxCategory.Items.Add(category.CategoryName);
                }
            }
        }

        private void comboBoxTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCategory.Items.Clear();
            ConnectCategory connect = new ConnectCategory();
            if (comboBoxTransactionType.SelectedItem.ToString() == "Expenditure")
            {
                List<Models.Category> list = connect.getExpenditureTypeData();
                foreach (Models.Category category in list)
                {
                    comboBoxCategory.Items.Add(category.CategoryName);
                }
            }
            else
            {
                List<Models.Category> list = connect.getIncomeTypeData();
                foreach (Models.Category category in list)
                {
                    comboBoxCategory.Items.Add(category.CategoryName);
                }
            }
        }

        private void textBoxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != (char)Keys.Back && e.KeyChar != 32)
            {
                e.Handled = true; // Chặn ký tự không hợp lệ
            }
        }
    }
}
