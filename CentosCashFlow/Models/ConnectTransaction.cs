using CentosCashFlow.ChildForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class ConnectTransaction
    {
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-G5HQJSJ2\\SQLEXPRESS; Initial Catalog=DB_CashFlowManagement;Integrated Security=True");
        public List<Transaction> getCurrentDataByID(int id)
        {

            List<Transaction> list = new List<Transaction>();
            string sql = ("SELECT TOP 20" +
                "T.ID AS Transaction_ID, " +
                "T.User_ID, " +
                "C.Category_Name, " +
                "T.Transaction_Type, " +
                "T.Amount, " +
                "T.Transaction_Date, " +
                "T.Transaction_Description, " +
                "C.Category_Img " +
                "FROM Transactions AS T " +
                "JOIN Categories AS C ON T.Category_ID = C.ID " +
                "WHERE T.User_ID = @id " +
                "ORDER BY T.Transaction_Date DESC;");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("id", id);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                Transaction emp = new Transaction();
                emp.TransactionID = int.Parse(rdr.GetValue(0).ToString());
                emp.UserID = int.Parse(rdr.GetValue(1).ToString());
                emp.CategoryName = rdr.GetValue(2).ToString();
                emp.TransactionType = rdr.GetValue(3).ToString();
                emp.Amount = decimal.Parse(rdr.GetValue(4).ToString());
                emp.TransactionDate = DateTime.Parse(rdr.GetValue(5).ToString());
                emp.TransactionDescription = rdr.GetValue(6).ToString();
                emp.TransactionImg = rdr.GetValue(7).ToString();

                list.Add(emp);
            }
            con.Close();

            return list;
        }

        public int addNewItem(Transaction transaction)
        {
            Models.ConnectCategory connectCategory = new Models.ConnectCategory();
            Models.Category category = connectCategory.getDataByName(transaction.CategoryName);
            con.Open();
            int rs = 0;
            string sql = "INSERT INTO Transactions " +
                "VALUES(@userID, @categoryID, @transactionType, @amount, @transactionDate, @transactionDescription)";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@userID", transaction.UserID);
            cmd.Parameters.AddWithValue("@categoryID", category.CategoryID);
            cmd.Parameters.AddWithValue("@transactionType", transaction.TransactionType);
            cmd.Parameters.AddWithValue("@amount", transaction.Amount);
            cmd.Parameters.AddWithValue("@transactionDate", transaction.TransactionDate);
            cmd.Parameters.AddWithValue("@transactionDescription", transaction.TransactionDescription);
            rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }
        public int updateDataForItem(Transaction transaction)
        {
            Models.ConnectCategory connectCategory = new Models.ConnectCategory();
            Models.Category category = connectCategory.getDataByName(transaction.CategoryName);
            con.Open();
            int rs = 0;
            string sql = "UPDATE Transactions " +
                "SET Category_ID = @categoryID, " +
                "Transaction_Type = @transactionType, " +
                "Amount = @amount, " +
                "Transaction_Date = @transactionDate, " +
                "Transaction_Description = @transactionDescription " +
                "WHERE ID = @id";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", transaction.TransactionID);
            cmd.Parameters.AddWithValue("@categoryID", category.CategoryID);
            cmd.Parameters.AddWithValue("@transactionType", transaction.TransactionType);
            cmd.Parameters.AddWithValue("@amount", transaction.Amount);
            cmd.Parameters.AddWithValue("@transactionDate", transaction.TransactionDate);
            cmd.Parameters.AddWithValue("@transactionDescription", transaction.TransactionDescription);

            rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }
        public int deleteDataById(int id)
        {
            con.Open();
            int rs = 0;
            string sql = "Delete from Transactions where ID = @id";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            rs = cmd.ExecuteNonQuery();
            con.Close();
            return rs;
        }
    }
}
