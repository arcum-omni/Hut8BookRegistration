using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hut8BookRegistration
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            PopulateCustomerCbo();
            PopulateBookCbo();
        }

        private void PopulateCustomerCbo()
        {
            List<Customer> allCustomers = CustomerDB.GetAllCustomers();

            allCustomersCbo.Items.Clear();

            foreach (Customer c in allCustomers)
            {
                allCustomersCbo.Items.Add(c);
            }
        }

        private void PopulateBookCbo()
        {
            List<Book> allBooks = BookDB.GetAllBooks();

            allBooksCbo.Items.Clear();

            foreach (Book b in allBooks)
            {
                allBooksCbo.Items.Add(b);
            }
        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            // programatically create a new form
            addCustomerFrm addCustomer = new addCustomerFrm();
            DialogResult result = addCustomer.ShowDialog();

            // After AddBookFrm is closed
            if (result == DialogResult.OK)
            {
                PopulateCustomerCbo();
            }
            else
            {
                MessageBox.Show("Are you sure you want to exit without adding a customer?");
            }
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            // programatically create a new form
            AddBookFrm addBook = new AddBookFrm();
            DialogResult result = addBook.ShowDialog();

            // After AddBookFrm is closed
            if (result == DialogResult.OK)
            {
                PopulateBookCbo();
            }
            else
            {
                MessageBox.Show("Are you sure you want to exit without adding a book?");
            }
        }

        private void registerBookBtn_Click(object sender, EventArgs e)
        {
            if (allBooksCbo.SelectedIndex < 0 || allCustomersCbo.SelectedIndex < 0 || regDateDtp.Checked == false)
            {
                string errString = "You must select a ";
                if (allBooksCbo.SelectedIndex < 0)
                {
                    errString += "Book ";
                }
                if (allCustomersCbo.SelectedIndex < 0)
                {
                    errString += "Customer ";
                }

                MessageBox.Show(errString);
            }
            else
            {
                Book selectedBook = (Book)allBooksCbo.SelectedItem;
                Customer selectedCustomer = (Customer)allCustomersCbo.SelectedItem;
                Registration regEntry = new Registration();
            
                regEntry.CustomerId = selectedCustomer.CustomerId;
                regEntry.ISBN = selectedBook.ISBN;
                regEntry.RegDate = regDateDtp.Value;

                if (BookRegistrationDB.RegisterBook(regEntry))
                {
                    MessageBox.Show("Book Registration Complete");
                }
                else
                {
                    if (allBooksCbo.SelectedIndex < 0 || allCustomersCbo.SelectedIndex < 0 || regDateDtp.Checked == false)
                    {
                        MessageBox.Show("Database Connection Error, please try again later.");
                    }
                }
            }

            allBooksCbo.Text = string.Empty;
            allCustomersCbo.Text = string.Empty;
        }
    }
}
