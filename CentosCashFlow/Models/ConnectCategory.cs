using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;

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
                emp.CategoryImg = rdr.GetValue(3).ToString();

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
        public Category getDataByID(string id)
        {
            Category emp = new Category();
            con.Open();
            string sql = ("Select * from Categories where ID = @id");
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                emp.CategoryID = rdr.GetValue(0).ToString();
                emp.CategoryName = rdr.GetValue(1).ToString();
                emp.CategoryType = rdr.GetValue(2).ToString();
                emp.CategoryImg = rdr.GetValue(3).ToString();

            }
            con.Close();

            return emp;
        }
        public Category getDataByName(string name)
        {
            Category emp = new Category();
            con.Open();
            string sql = ("Select * from Categories where Category_Name = @name");
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@name", name);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                emp.CategoryID = rdr.GetValue(0).ToString();
                emp.CategoryName = rdr.GetValue(1).ToString();
                emp.CategoryType = rdr.GetValue(2).ToString();
                emp.CategoryImg = rdr.GetValue(3).ToString();
            }
            con.Close();

            return emp;
        }
        public int addNewItem(Category category)
        {
            con.Open();
            int rs = 0;
            string sql = "INSERT INTO Categories VALUES(@id, @name, @type, @img)";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", category.CategoryID);
            cmd.Parameters.AddWithValue("@name", category.CategoryName);
            cmd.Parameters.AddWithValue("@type", category.CategoryType);
            cmd.Parameters.AddWithValue("@img", category.CategoryImg);
            rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }
        public int updateDataForItem(Category category)
        {
            con.Open();
            int rs = 0;
            string sql = "UPDATE Categories SET Category_Type = @type, Category_Name = @name, Category_Img = @img WHERE ID = @id";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", category.CategoryID);
            cmd.Parameters.AddWithValue("@type", category.CategoryType);
            cmd.Parameters.AddWithValue("@name", category.CategoryName);
            cmd.Parameters.AddWithValue("@img", category.CategoryImg);
            rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }

        public int deleteDataById(string id)
        {
            con.Open();
            int rs = 0;
            string sql = "EXEC DeleteCategory @Category_ID = @id";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }
    }
}
