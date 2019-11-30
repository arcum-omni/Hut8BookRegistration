using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hut8BookRegistration
{
    static class BookDB
    {
        /// <summary>
        /// Retrieves all books from the database in alphabetical order by title
        /// </summary>
        /// <returns></returns>
        public static List<Book> GetAllBooks()
        {
            // 1. Establish Connection to DB
            SqlConnection con = HbrDBHelper.GetConnection();

            // 2. Setup Query
            SqlCommand selCmd = new SqlCommand();
            selCmd.Connection = con;
            selCmd.CommandText = "select ISBN, Price, Title " +
                                 "from Book " +
                                 "order by Title";

            // 3. Open Connection
            con.Open();

            // 4. Send Query to DB
            SqlDataReader rdr = selCmd.ExecuteReader();

            // 5. Process Query Results
            var books = new List<Book>();
            while (rdr.Read())
            {
                Book tempBook = new Book();
                //object.item = (cast)rdr["column"];
                tempBook.ISBN = (string)rdr["ISBN"];
                tempBook.Price = (decimal)rdr["Price"];
                tempBook.Title = (string)rdr["Title"];
                books.Add(tempBook);
            }

            // 6. Dispose DB & return data
            con.Close();
            return books;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a single book to the database
        /// </summary>
        /// <exception cref="SqlException">There was a problem connecting to the database</exception>
        /// <param name="b"></param>
        public static void Add(Book b)
        {
            SqlConnection con = HbrDBHelper.GetConnection();

            SqlCommand addCmd = new SqlCommand();
            addCmd.Connection = con;
            addCmd.CommandText = "insert into Book (ISBN, Price, Title) " +
                                 "values (@bookID, @bookPrice, @bookTitle)";
            addCmd.Parameters.AddWithValue("@bookID", b.ISBN);
            addCmd.Parameters.AddWithValue("@bookPrice", b.Price);
            addCmd.Parameters.AddWithValue("@bookTitle", b.Title);

            try
            {
                con.Open();
                int rows = addCmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    throw new Exception("No book was added");
                }
            }
            finally
            {
                con.Dispose();
            }
        }
    }
}
