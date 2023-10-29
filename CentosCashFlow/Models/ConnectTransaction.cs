using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class ConnectTransaction
    {
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-G5HQJSJ2\\SQLEXPRESS; Initial Catalog=DB_CashFlowManagement;Integrated Security=True");
        public List<Category> getIncomeTypeData()
        {
            List<Category> list = new List<Category>();
            string sql = ("Select * from Categories where Category_Type = 'Income'");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Category emp = new Category();
                emp.CategoryID = rdr.GetValue(0).ToString();
                emp.CategoryName = rdr.GetValue(1).ToString();
                emp.CategoryType = rdr.GetValue(2).ToString();

                list.Add(emp);
            }
            con.Close();

            return list;
        }
    }
}
