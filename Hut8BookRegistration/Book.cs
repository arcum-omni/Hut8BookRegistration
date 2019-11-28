using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hut8BookRegistration
{
    /// <summary>
    /// Represents a single book
    /// </summary>
    public class Book
    {
        /// <summary>
        /// No Arg Constructor
        /// </summary>
        public Book()
        {

        }

        /// <summary>
        /// Create a book with the following parameters
        /// </summary>
        /// <param name="bookID"></param>
        /// <param name="bookPrice"></param>
        /// <param name="bookTitle"></param>
        public Book(string bookID, decimal bookPrice, string bookTitle)
        {
            ISBN = bookID;
            Price = bookPrice;
            Title = bookTitle;
        }
        
        #region Book Properties
        /// <summary>
        /// International Standard Book Number
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Retain Price of the Book
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Title of the Book
        /// </summary>
        public string Title { get; set; }
        #endregion
        
        /// <summary>
        /// Override inherited ToString() to provide specific information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            CultureInfo ci = new CultureInfo("en-us");
            return $"{Title}, {ISBN}, {Price.ToString("C", ci)}";
        }
    }
}
