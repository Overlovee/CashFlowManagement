using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CentosCashFlow.Models
{
    public class ConnectCurrency
    {
        DbContext dbContext = new DbContext();
        public List<Currency> getData()
        {
            List<Currency> list = new List<Currency>();
            string sql = ("Select * from Currency");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Currency emp = new Currency();
                emp.CurrencyCode = rdr.GetValue(0).ToString();
                emp.CurrencyName = rdr.GetValue(1).ToString();
                emp.ExchangeRateUSD = decimal.Parse(rdr.GetValue(2).ToString());

                list.Add(emp);
            }

            return list;
        }
    }
}
