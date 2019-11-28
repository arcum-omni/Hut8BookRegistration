using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hut8BookRegistration
{
    /// <summary>
    /// Represents a single customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// No Arg Constructor
        /// </summary>
        public Customer()
        {

        }

        /// <summary>
        /// Create a customer with the following parameters
        /// </summary>
        /// <param name="CID"></param>
        /// <param name="DoB"></param>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="honorificTitle"></param>
        public Customer(int CID, DateTime DoB, string fName, string lName, string honorificTitle)
        {
            CustomerId = CID;
            DateOfBirth = DoB;
            FirstName = fName;
            LastName = lName;
            Title = honorificTitle;
        }

        #region Customer Properties
        /// <summary>
        /// Customer's unique identification number CID.
        /// </summary>
        public int CustomerId { get; set; }

        /// <summary>
        /// Date Customer was born, time is ignored.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// The Customer's legal first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The Customer's legal last name, family name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The Customer's honorific title: Mr(adult male) Mstr(juvenile male) Miss(unmarried female) Mrs(married female) Ms(unknown marital)
        /// </summary>
        public string Title { get; set; }
        #endregion

        /// <summary>
        /// Override inherited ToString() to provide specific information
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{LastName}, {FirstName}, {DateOfBirth.ToShortDateString()}";
        }
    }
}
