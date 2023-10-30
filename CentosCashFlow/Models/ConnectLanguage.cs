using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class ConnectLanguage
    {
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-G5HQJSJ2\\SQLEXPRESS; Initial Catalog=DB_CashFlowManagement;Integrated Security=True");
        public List<Language> getData()
        {
            List<Language> list = new List<Language>();
            string sql = ("Select * from Languages");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Language emp = new Language();
                emp.Language_Code = rdr.GetValue(0).ToString();
                emp.Language_Name = rdr.GetValue(1).ToString();

                list.Add(emp);
            }
            con.Close();

            return list;
        }
        public Language getDataByID(string id)
        {
            Language emp = new Language();
            con.Open();
            string sql = ("Select * from Languages where Language_Code = @id");
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                emp.Language_Code = rdr.GetValue(0).ToString();
                emp.Language_Name = rdr.GetValue(1).ToString();
            }
            con.Close();

            return emp;
        }
    }
}
