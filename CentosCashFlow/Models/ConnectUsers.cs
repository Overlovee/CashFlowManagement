using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentosCashFlow.Models
{
    public class ConnectUsers
    {
        public SqlConnection con = new SqlConnection("Data Source=LAPTOP-G5HQJSJ2\\SQLEXPRESS; Initial Catalog=DB_CashFlowManagement;Integrated Security=True");
        public User getUserDataByID(int id)
        {
         
            User emp = new User();
            string sql = ("SELECT " +
                "ID, Name, Email, Password, Role, Available_Money, Language_Code, TimeFormat, Currency_Code, OverviewDisplayMode " +
                "FROM Users, Setting " +
                "WHERE Users.ID = @id and Users.ID = Setting.User_ID;");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader rdr = cmd.ExecuteReader();
            if(rdr.Read())
            {
                emp.Id = int.Parse(rdr.GetValue(0).ToString());
                emp.Name = rdr.GetValue(1).ToString();
                emp.Email = rdr.GetValue(2).ToString();
                emp.Password = rdr.GetValue(3).ToString();
                emp.Role = rdr.GetValue(4).ToString();
                emp.AvailableMoney = decimal.Parse(rdr.GetValue(5).ToString());
                emp.UserSettings.UserID = emp.Id;
                emp.UserSettings.LanguageCode = rdr.GetValue(6).ToString();
                emp.UserSettings.TimeFormat = rdr.GetValue(7).ToString();
                emp.UserSettings.CurrencyCode = rdr.GetValue(8).ToString();
                emp.UserSettings.OverviewDisplayMode = rdr.GetValue(9).ToString();

            }
            con.Close();

            return emp;
        }
        public User Login(string email, string password)
        {
            string sql = ("SELECT ID FROM Users WHERE Email = @email and Password = @password");
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                int id = int.Parse(rdr.GetValue(0).ToString());
                con.Close();
                return getUserDataByID(id);
            }
            return null;
        }

        public Settings getUserSettingsByID(int id)
        {

            Settings emp = new Settings();
            string sql = ("SELECT * FROM Setting WHERE User_ID = @id");
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                emp.UserID = int.Parse(rdr.GetValue(0).ToString());
                emp.LanguageCode = rdr.GetValue(1).ToString();
                emp.TimeFormat = rdr.GetValue(2).ToString();
                emp.CurrencyCode = rdr.GetValue(3).ToString();
                emp.OverviewDisplayMode = rdr.GetValue(4).ToString();
            }
            con.Close();

            return emp;
        }
    }
}
