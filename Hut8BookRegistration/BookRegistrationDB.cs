using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hut8BookRegistration
{
    static class BookRegistrationDB
    {
        public static List<Registration> RegisterBook()
        {
            // 1. Establish Connection
            SqlConnection con = HbrDBHelper.GetConnection();

            // 2. Setup Query
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = "select CustomerID, ISBN, RegDate " +
                                 "from Registration " +
                                 "order by RegDate desc, ISBN asc";

            // 3. Open Connection
            con.Open();

            // 4. Send Query to DB
            SqlDataReader rdr = selCmd.ExecuteReader();

            // 5. Process Query Results
            var bookRegistrations = new List<Registration>();
            while (rdr.Read())
            {
                Registration tempReg = new Registration();
                //object.item = (cast)rdr["column"];
                tempReg.CustomerId = (int)rdr["CustomerID"];
                tempReg.ISBN = (string)rdr["ISBN"];
                tempReg.RegDate = (DateTime)rdr["RegDate"];
                bookRegistrations.Add(tempReg);
            }

            // 6. Close DB
            con.Close();
            return bookRegistrations;
        }
    }
}
