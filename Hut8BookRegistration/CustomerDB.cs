using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hut8BookRegistration
{
    static class CustomerDB
    {
        public static List<Customer> GetAllCustomers()
        {
            // 1. Establish Connection
            SqlConnection con = HbrDBHelper.GetConnection();

            // 2. Setup Query
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = "select CustomerID, DateOfBirth, FirstName, LastName, Title " +
                                 "from Customer " +
                                 "order by LastName asc, DateOfBirth desc";

            // 3. Open Connection
            con.Open();

            // 4. Send Query to DB
            SqlDataReader rdr = selCmd.ExecuteReader();

            // 5. Process Query Results
            var customers = new List<Customer>();
            while (rdr.Read())
            {
                Customer tempCustomer = new Customer();
                //object.item = (cast)rdr["column"];
                tempCustomer.CustomerId = (int)rdr["CustomerID"];
                tempCustomer.DateOfBirth = (DateTime)rdr["DateOfBirth"];
                tempCustomer.FirstName = (string)rdr["FirstName"];
                tempCustomer.LastName = (string)rdr["LastName"];
                tempCustomer.Title = (string)rdr["Title"];
                customers.Add(tempCustomer);
            }

            // 6. Close DB
            con.Close();
            return customers;
            
        }
    }
}
