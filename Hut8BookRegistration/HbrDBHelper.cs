using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hut8BookRegistration
{
    /// <summary>
    /// Helper class to get connection to Hut8 Book Registration database
    /// </summary>
    static class HbrDBHelper
    {
        public static SqlConnection GetConnection()
        {
            // Default DB Connection
            //string con = "Data Source=localhost;Initial Catalog=BookRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            // Home Specific DB Connection
            string con = "Data Source=OFFICETOWER\\SQLEXPRESS;Initial Catalog=BookRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection sqlCon = new SqlConnection();
            sqlCon.ConnectionString = con;
            return sqlCon;
        }
    }
}
