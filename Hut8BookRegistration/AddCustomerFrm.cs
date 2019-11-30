using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hut8BookRegistration
{
    public partial class addCustomerFrm : Form
    {
        public addCustomerFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the newly added customer
        /// </summary>
        public Customer NewCustomer { get; set; }

        /// <summary>
        /// Add New Customer to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCustomerBtn_Click(object sender, EventArgs e)
        {
            // ToDo:  Add data validation, temporarily assume data valid

            Customer c = new Customer()
            {
                Title = titleTxt.Text,
                FirstName = firstNameTxt.Text,
                LastName = lastNameTxt.Text,
                DateOfBirth = Convert.ToDateTime(dobTxt.Value)
            };

            NewCustomer = c;

            try
            {
                CustomerDB.Add(c);
                DialogResult = DialogResult.OK;
            }
            catch (SqlException)
            {
                MessageBox.Show("We are experiencing server connection issues.\n" +
                                "Please try again later.");
                throw;
            }
        }

    }
}
