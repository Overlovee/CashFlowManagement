﻿using System;
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
    public partial class TransactionItem : UserControl
    {
        public TransactionItem()
        {
            InitializeComponent();
        }

        private void btnEditingTransaction_Click(object sender, EventArgs e)
        {
            TransactionEditingForm form = new TransactionEditingForm();
            form.ShowDialog();
        }
    }
}
