# CPW116 Fall 2019 (dot)NET Final Project ***Hut8BookRegistration.sln***
Due Date: Dec 10, 2019<br><br>

**Instructions:** You are tasked with creating an application for customers to register books.<br><br>

**Operation**<br>
* The user selects a Customer name and Book title from the combo boxes, enters a date in the
text box, and clicks the Register Book button to add a new row to the Registrations table.<br>
*  After the user registers a product or clicks the Cancel button to cancel the add operation, the
Add Registration form is cleared.<br><br>

The GetAllBooks method in the BookDB class should return a List<Book> object that can be bound to the
Books combo box on the main form, the GetAllCustomers method in the CustomerDB class should
return a List<Customer> object that can be bound to the Customer combo box, and the RegisterBook
method in the BookRegistrationDB class should accept a Registration object and return a Boolean value
that indicates if the operation was successful. Use the value that’s returned by the RegisterBook method
to display a message indicating the result of the operation.<br><br>

Once you have those steps completed you will need to add a couple additional things.
• Add a new form to add a customer to the database
• Add a button on the main form to open the add customer form
• Add a new method in the CustomerDB class to insert a customer into the database
• Add a new form to add a Book to the database
• Add a button on the main form to open the add book form
• Add a method in the BookDB class to insert a product into the database
• Refresh the customer/book lists when a new item is added to the database







