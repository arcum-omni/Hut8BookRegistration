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
    }
}
