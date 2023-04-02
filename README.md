# Library_management (WPF project)
Library management
Introduction
The project of this semester's advanced programming course is library management software. This software generally includes three sections: manager, employee, and member, each of which has its own access and facilities. In this project, the goal is to review and use the topics you learn in the advanced programming course. In addition, you are supposed to use Git, XAML, SQL, etc. functionally.
Mandatory items
It is necessary to observe and use the following items correctly in carrying out the project

XAML
Your project is a WPF application project. In WPF projects, the front end is designed by XAML. A workshop will also be held for you to learn the basics of XAML.

database
You need a database to store the information of different parts of this project, we suggest using the SQL Server database, and a workshop will be held for you to learn the basic concepts of SQL. In all three cases above, according to your needs, you can use Google and YouTube for more extensive learning. Also, the time of the workshops will be coordinated with you on the lesson channel.
Exception Handling
In all parts of this project, you must have managed the exceptions of the program correctly so that you do not encounter an unhandled exception anywhere.

UML
Before starting the back part, you need to draw the appropriate UML.
Comments
Considering the need to present the project and the increase of codes at the end of the project, be sure to put appropriate comments in the project so that you do not encounter any problems when reviewing the project. Also, when you do group work, you need to have appropriate comments in the code for the convenience of other team members so that there is no ambiguity in the code for your teammates.

User types
In this project we have three types of users, manager, employee and member. To use the library, members of the library must first become a member of the library and pay the membership fee, then they can use the facilities of the program by entering the program. We have only one manager that is defined by default. Employees are added by the administrator and can use the program's facilities by logging into the program.

Library administrator accesses
This type of user enters with a username (in this text, the username is the same as the user's name) and the default password, and after logging in, he can perform the following actions:

1 - Adding an employee to the library
2- Removing the employee from the library
3 - Depositing employees' salaries
4- Adding a new book to the library inventory
5-Seeing the list of library books
6-Seeing the balance of the library's money bank
7-Increasing the balance of the library's money bank

Library staff access
Employees are registered in the system by the administrator, and after being registered, they can log in with their username and password. This type of user can perform the following actions:

1 - Viewing the list of books
2-Seeing the list of borrowed books
3-Seeing the list of available books (empty)
4-Seeing the list of library members
5-Seeing the list of late members in returning the book
6-Seeing the list of members who are late in paying the monthly membership fee
7-Seeing the status of a specific user
8-Seeing personal wallet balance
9- Change some personal information

Member Access
After registering and entering the software, library members can perform the following actions:

1 - Viewing the list of books
2 - Borrowing a new book
3- Returning the borrowed book
4- Paying the fine for the delay in returning the book
5-Paying the monthly membership fee
6-Seeing personal wallet balance
7- Increasing personal wallet balance
8- Change some personal information

Elgin page
This page is the default page of the software and contains two text blocks for username and password. There is also a button to login and a button to be redirected to the registration page. After entering the username and password, if the username does not exist or the password is incorrect, a suitable message should be printed. If the username and password are correct, according to the user's access type, the corresponding panel will be displayed.

Membership page
This page, if opened through the Elgin page, is for library member membership, and if opened through the admin panel, it is for adding a new employee. This page contains the following textblocks:
• name
• email
• phone number
• password
There is also a space to display photos and a button to select photos. This page includes a button to return to the Elgin page and a button to redirect to the payment page. If the return button is clicked, the user will be redirected to the login page, if the payment button is clicked, first the above fields must be checked according to the following conditions, and if the values are correct, the user will be redirected to the payment page, and if the payment is successful, it will be registered in the library. become
• No user should be registered in the system with this name, email or phone number;
• Name, email, phone number and password must be validated by the appropriate regexes described below;

Payment page
This page contains the amount of the fee to be paid, one or more textblocks for entering the card number, one textblock for entering the CVV, and two other textblocks for entering the month and year of the card's expiration date. After entering the information and pressing the payment button, the input values should be validated by appropriate functions or regex.
Regex regex or regular expressions (regular expressions) are usually used to validate inputs, if you don't have any information about this, ask Google for help.
• The name of your template must be the correct string, at least 3 and at most 32 English letters;
• Your template e-mail must be valid e-mails in the format c.b@a (here a contains a maximum of 32 letters, numbers, – or _. b contains a maximum of 8 letters or numbers. c contains a maximum of 3 letters );
• Your template phone number must contain exactly 11 digits and start with 09;
• Your template password must be at least 8 and at most 32 characters and include at least one capital letter;
• The CVV of your template should be such that it contains only 3 or 4 digits;
Card number validation function This validation is not done by regex and you have to write a suitable function for it. The card number must have 16 digits, to verify the card number, use the Luhn algorithm, which is the most famous algorithm in this field, this algorithm is as follows:
Consider card number 6463114641847518.
First step: From the right side, double the even numbers;

Second step: If doubling one of the numbers results in a two-digit number, add the digits of that two-digit number together to get a one-digit number. For example, in the example above, the number 14 is made by doubling the number 7. is a two-digit number, by adding its digits (5 = 4 + 1), you get the number five, which is a one-digit number, and replace it with 14;

Third step: calculate the sum of all the figures;
8 + 1 + 5 + 7 + 4 + 8 + 1 + 4 + 6 + 4 + 1 + 1 + 3 + 6 + 4 + 6 = 70
Step 4: If the sum of digits is a multiple of 10, the card number is valid, otherwise it is not valid.
Validation of the expiration date of the card with which the user intends to make a purchase must have at least 3 months of validity, you should do this by comparing the expiration date of the card and the date of the system.

Admin panel
The administrator can enter his panel with the username admin and password AdminLib123. After entering his panel, he will see different sections, which by clicking on them, he can use the facilities of that section, the sections of the admin panel are as follows:
• Employees
In this section, there is a list of all employees, there is a button to add a new employee, which directs the manager to the page of adding an employee, the sub-sections of removing employees and depositing employee salaries are also part of this section and are explained below. .
• Books
In this section there is a list of all the books, there is a button to add a new book, which will lead the administrator to the page of adding a book.
• Money Bank
This section contains the entire balance of the library's money bank, there is also a box and a button that the manager will be directed to the payment page by entering the desired amount and pressing the payment button, and the balance of the library's bank will increase if the payment is successful.

Remove the employee
This part will be displayed in the employees section and at the bottom of the list of employees, and there is a delete button next to each of the items in the list of employees. By pressing that button, the manager will get a message asking if he is sure to delete the corresponding employee, then if the manager is sure of the operation of the corresponding employee, he will be deleted.
Payment of employee salaries
This section will also be displayed in the employees section and at the bottom of the list of employees and includes the payment button. By pressing this button, the manager will be asked to confirm the operation password, then if the bank balance is sufficient and the password is correct, the salaries of all employees will be credited to their account, otherwise, an appropriate error message should be displayed.
Add new book
This page contains boxes for book name, author name, book genre and book edition number. After entering the information by the administrator, if there is a book with this exact name, one will be added to the number of that book in the list of books, and otherwise, a new book with this specification will be added to the list of library books. .

Employee panel
Employees can log in with their username and password, set by the administrator. After entering their panel, employees will see different sections that can be used by clicking on them. The sections of the employee panel are as follows:
• Books
In this section there is a list and three buttons, the buttons of this section are all books, books in the hands of members and books in the library. By clicking on each of these buttons, the related information should be displayed in the list of this section. By default, the information related to the books in the hands of the members (on loan) should be displayed in this list.
• parts
In this section there is a list and three buttons, the buttons in this section are total members, overdue members in returning books and overdue members in paying monthly subscription. By pressing each of these buttons, the related information should be displayed in the list of this section. By default, information about members who are late in returning books should be displayed in this list. At the bottom of the list, there is a box and a button that the employee can view the information about that member by entering the member's name and pressing the display button.
• wallet
In this section, the balance of the employee's wallet will be displayed to him.
• Edit information
By clicking on this tab, the employee enters a page where he can view and edit his personal information.

Member information page
This page includes the member's photo, member's name, member's email, member's phone number, member's registration date, subscription renewal date, amount of remaining days of the subscription, currently borrowed books and the date of returning the books. If the user's monthly subscription is over and has not yet been renewed, the number of days past the subscription renewal date will be displayed in red. The same thing is repeated for the delay in the book. On this page, the employee can only view this information and is not allowed to change it. There is a textblock and a button in this section, where the employee can remove the user from the system by entering his password and pressing the button, after removing the user from the system, the books borrowed by that member must be returned to the list of empty books. The library will return.
Edit information
On this page, there are textblocks for name, email and phone number, there is also a place for a photo and a photo selection button where the user can edit everything except the name, to edit the information, a password is required. Enter the password in the corresponding field. If the password is correct, edit the information. Obviously, the input values must be validated before editing.

Member panel
Members can log in with the username and password they entered during registration. Members can use the facilities of their panel after entering their panel. The members panel has different sections. These sections are as follows.
• Books
In this section there is a list, in which all the books that can be borrowed are displayed. The sub-sections of book search and book borrowing are also part of this section.
• My books
This section contains a list that displays the books that the user has currently borrowed. There is also a book return sub-section in this section.
• Subscription
In this section, the number of days remaining in the user's subscription is written in green, there is a button that can be renewed if the balance of the user's wallet is sufficient, and if the user's credit is insufficient, a message will be displayed. Display an error that shows the amount of money that the user needs to pay. Also, if the user's subscription date has passed, the number of days that have been delayed in paying the subscription should be written in red.
• wallet
In this section, the balance of the user's wallet is written, and there will be a textblock for the amount and the increase balance button, which will direct the user to the payment page by pressing the increase balance button.
• Edit personal information
This section is exactly like the section for editing personal information of employees.

book search
This section is located next to the list of books. It contains two checkboxes (one for searching with the book name and the other for searching with the author's name), a textblock and a button that the user can choose in which cases he wants to search and then enter the search term and press the search button. See the desired item in the list.If no data is found according to these items, an appropriate error message will be displayed to the user.
Borrowing books
In this section, there is a textblock in which the user enters the name of the desired book, and after pressing the borrow button, if it meets the conditions for borrowing, the book will be added to the user's list of books.
Terms of borrowing books
The number of books currently borrowed by the user should be less than 5.
None of the borrowed books have been delayed.
Also, at least one week of subscription is left.

return the book
This section contains a box-combo and a button from which the user selects the name of the book that he wants to return, and after pressing the return button, if the book has no delay in returning or the balance of the user's account for Giving a late fine is enough, the book will be removed from his book list. In case of insufficient balance, an error message should be shown to the user and the amount to increase the balance of the wallet should be specified.
Bonus section
The bonus part of this project is the possibility of chatting between employees and members, and in the best case, it adds 5% to your project score.
Personal chat page
Add a button to send a message on the page related to displaying member information in the employee panel, by clicking this button, the employee will be directed to the chat page with this member and can start chatting with the member. There will also be a chat section in the member panel, which will be directed to the chat related page by clicking on it, and if an employee has started a chat with him, it will be possible for that user to continue chatting with that employee. Obviously, the chats should be stored in the database so that they can be accessed in subsequent logins.

