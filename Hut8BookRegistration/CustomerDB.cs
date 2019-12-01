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
        /// <summary>
        /// Retrieves all customers from the database in alphabetical order by last name(asc) & dob(desc)
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Adds a single student to the database
        /// </summary>
        /// <exception cref="SqlException">There was a problem connecting to the database</exception>
        /// <param name="c"></param>
        public static void AddCustomer(Customer c)
        {
            SqlConnection con = HbrDBHelper.GetConnection();
        
            SqlCommand addCmd = new SqlCommand();
            addCmd.Connection = con;
            addCmd.CommandText = "insert into Customer(DateOfBirth, FirstName, LastName, Title)" +
                                 "values (@DoB, @fName, @lName, @honorificTitle)";
            addCmd.Parameters.AddWithValue("@Dob", c.DateOfBirth);
            addCmd.Parameters.AddWithValue("@fName", c.FirstName);
            addCmd.Parameters.AddWithValue("@lName", c.LastName);
            addCmd.Parameters.AddWithValue("@honorificTitle", c.Title);

            try
            {
                con.Open();
                int rows = addCmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    throw new Exception("No customer was added");
                }
            }
            finally
            {
                con.Dispose();
            }

        }
    }
}
