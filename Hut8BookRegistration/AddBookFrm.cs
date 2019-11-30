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
    public partial class AddBookFrm : Form
    {
        public AddBookFrm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get the newly added book
        /// </summary>
        public Book NewBook { get; set; }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            // ToDo:  Add data validation, temporarily assume data valid

            Book b = new Book()
            {
                ISBN = isbnTxt.Text,
                Price = Convert.ToDecimal(priceTxt.Text),
                Title = bookTitleTxt.Text
            };

            NewBook = b;

            try
            {
                BookDB.Add(b);
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
