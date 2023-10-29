using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace CentosCashFlow.Models
{

    public class ConnectCategory
    {
        //public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB_CashFlowManagement"].ToString());
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
        public List<Category> getExpenditureTypeData()
        {
            List<Category> list = new List<Category>();
            con.Open();
            string sql = ("Select * from Categories where Category_Type = 'Expenditure'");
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Category emp = new Category();
                emp.CategoryID = rdr.GetValue(0).ToString();
                emp.CategoryName = rdr.GetValue(1).ToString();
                emp.CategoryType = rdr.GetValue(2).ToString();
                emp.CategoryImg = rdr.GetValue(3).ToString();

                list.Add(emp);
            }
            con.Close();

            return list;
        }
    }
}
