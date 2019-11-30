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
        /// <summary>
        /// Register Book
        /// </summary>
        /// <returns></returns>
        public static bool RegisterBook(Registration r)
        {   // similar to SMS edit student, I am pulling info from 
            // accept a Registration object
            // return a Boolean value that indicates if the operation was successful
            // Use the value that’s returned by the RegisterBook method to display a message indicating the result of the operation
            // true: book successfully registered
            // false: book registration unsuccessful

            SqlConnection con = HbrDBHelper.GetConnection();

            SqlCommand regCmd = new SqlCommand();
            regCmd.Connection = con;
            regCmd.CommandText = "insert into Registration (ISBN, CustomerID, RegDate) " +
                                 "values (@bookID, @CID, @rDate)";
            regCmd.Parameters.AddWithValue("@bookID", r.ISBN);
            regCmd.Parameters.AddWithValue("@CID", r.CustomerId);
            regCmd.Parameters.AddWithValue("@rDate", r.RegDate);

            try
            {
                con.Open();
                int rows = regCmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    
                    return false;
                }
                else
                {
                    return true;
                }
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
