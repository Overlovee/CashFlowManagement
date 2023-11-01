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
        DbContext dbContext = new DbContext();
        public List<Language> getData()
        {
            List<Language> list = new List<Language>();
            string sql = ("Select * from Languages");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            while (rdr.Read())
            {
                Language emp = new Language();
                emp.Language_Code = rdr.GetValue(0).ToString();
                emp.Language_Name = rdr.GetValue(1).ToString();

                list.Add(emp);
            }
            rdr.Close();
            return list;
        }
        public Language getDataByID(string id)
        {
            Language emp = new Language();
            string sql = ("Select * from Languages where Language_Code = '"+id+"'");
            SqlDataReader rdr = dbContext.ExcuteQuery(sql);
            if (rdr.Read())
            {
                emp.Language_Code = rdr.GetValue(0).ToString();
                emp.Language_Name = rdr.GetValue(1).ToString();
            }
            return emp;
        }
    }
}
