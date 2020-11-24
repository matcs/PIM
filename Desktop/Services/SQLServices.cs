using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Services
{
    class SQLServices
    {
        
        SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=PIM_DB;Trusted_Connection=True;");
        public bool login(string email, string password)
        {
            string SQLQuery = "SELECT Password FROM Users WHERE Email='{0}'";
            bool SucessfulLogin = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = string.Format(SQLQuery, email);

            if (cmd.ExecuteScalar() != null)
            {
                string passwordSql = cmd.ExecuteScalar().ToString();
                SucessfulLogin = checkPassword(password, passwordSql);
            }
            conn.Close();
            
            return SucessfulLogin;
        }

        private bool checkPassword(string passwordInput, string passwordSql)
        {
            return passwordInput.Equals(passwordSql) ? true : false;
        }

        public List<int> GetBestClientsNumbers()
        {
            string SQLQuery = "SELECT c.TotalOfPayments FROM Customers as c " +
                              "ORDER BY TotalOfPayments DESC;";

            List<int> columnData = new List<int>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = SQLQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            {
                while (reader.Read())
                {
                    columnData.Add(reader.GetInt32(0));
                }
            }

            conn.Close();
            
            return columnData;
        }

        public List<string> GetBestClientsEmail()
        {
            string SQLQuery = "SELECT u.Email FROM Customers as c " +
                              "INNER JOIN Users as u ON UserId = u.Id " + 
                              "ORDER BY TotalOfPayments DESC; ";

            List<string> columnData = new List<string>();
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = SQLQuery;
            SqlDataReader reader = cmd.ExecuteReader();
            {
                while (reader.Read())
                {
                    columnData.Add(reader.GetString(0));
                }
            }

            conn.Close();

            return columnData;
        }

    }
}