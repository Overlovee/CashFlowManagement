using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class Transaction
    {
        public int TransactionID { get; set; }
        public int UserID { get; set; }
        public string CategoryID { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string TransactionDateTime { get; set; }
        public string TransactionDescription { get; set; }
        public string TransactionCurrency { get; set; }

        public Transaction()
        {
            TransactionID = 0;
            UserID = 0;
            CategoryID = "TTN";
            TransactionType = "Income";
            Amount= 0;
            TransactionDateTime = DateTime.Now.Date.ToString();
            TransactionDescription = "";
            TransactionCurrency = "VND";
        }

    }
}
