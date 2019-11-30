using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hut8BookRegistration
{
    /// <summary>
    /// Represents a single book registration entry/record
    /// </summary>
    public class Registration
    {
        /// <summary>
        /// No Arg Constructor
        /// </summary>
        public Registration()
        {

        }

        /// <summary>
        /// Create a Registraion with the following parameters
        /// </summary>
        /// <param name="bookID"></param>
        /// <param name="CID"></param>
        /// <param name="rDate"></param>
        public Registration(string bookID, int CID, DateTime rDate)
        {
            ISBN = bookID;
            CustomerId = CID;
            RegDate = rDate;
        }

        #region Registration Properties
        /// <summary>
        /// International Standard Book Number
        /// </summary>
        public string ISBN { get; set; }

        /// <summary>
        /// Customer's unique identification number CID.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Registration Date
        /// </summary>
        public DateTime RegDate { get; set; }

        #endregion

        /// <summary>
        /// Override inherited ToString() to provide specific information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ISBN: {ISBN}, CID: {CustomerId}, Date: {RegDate}";
        }
    }
}