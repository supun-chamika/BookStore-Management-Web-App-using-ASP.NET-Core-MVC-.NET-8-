---

# Bookstore Management Web Application using ASP.NET Core MVC (.NET 8)

Welcome to the Bookstore Management Web Application! This project aims to provide an efficient and user-friendly platform for managing books and categories within a bookstore. Whether you're an admin overseeing book details or a customer exploring available titles, this application has you covered. Below, you'll find an introduction to the key features, technologies, and methodologies utilized in this project.

![image](https://github.com/supun-chamika/BookStore-Management-Web-App-using-ASP.NET-Core-MVC-.NET-8-/assets/101165810/2fe2db42-725b-4b1f-913a-97a7be9c678b)

## Features

1. **Customer View:**
   - Customers can explore book details available in the store.
   - Browse through categories and discover their favorite reads.
   - Ability to register, log in, and view their account details.

2. **Admin View:**
   - Admins have full control over book management:
     - Add new books to the inventory.
     - Delete books that are no longer available.
     - Update book information as needed.
   - Manage book categories efficiently.

3. **User Authentication:**
   - User login and registration pages ensure secure access.
   - Users can view their personal details on the user details page.

## Technologies and Methodologies

Here's a breakdown of the technologies and methodologies used in this project:

1. **ASP.NET Core MVC (.NET 8):**
   - The foundation of our web application, providing a robust framework for building dynamic web pages.

2. **Entity Framework Core (EF Core):**
   - Used as an Object-Relational Mapping (ORM) tool to interact with the database.
   - Enables seamless communication between the application and SQL Server.

3. **SQL Server:**
   - Our chosen database management system for storing book details and user data.

4. **Multi-tier Architecture:**
   - Organizes the application into logical layers (presentation, business logic, data access) for better maintainability and scalability.

5. **Repository Pattern:**
   - Provides a clean and consistent interface for data access.
   - Separates data access logic from business logic.

6. **Unit of Work Pattern:**
   - Manages transactions and context sharing across multiple database operations.

7. **Areas:**
   - Partitions the ASP.NET Core Web app into smaller functional groups (e.g., admin, customer).

8.  **Scaffolded Identity:**
    - Automatically generates code for user authentication and authorization features.

9. **Server-side Validation:**
    - Utilizes Tag Helpers and data annotations to validate user input.

10. **Client-side Validation:**
    - Implements jQuery validation for real-time feedback.

11. **View Models:**
    - Connects the Category and Product (Book) models for efficient data representation.

12. **Partial Views:**
    - Reusable components that enhance code modularity and maintainability.
 
14. **Bootstrap for Styling:**
    - Ensures a responsive and visually appealing user interface.

14. **TempData for Alert Management:**
    - Provides notifications and alerts to users during their interactions with the application.

15. **Toastr for Notifications:**
    - Enhances user experience with customizable notifications.

## Getting Started

1. Clone this repository to your local machine.
2. Set up your SQL Server database and connection string.
3. Build and run the application.
4. Explore the features and start managing your bookstore efficiently!

Feel free to contribute, report issues, or suggest improvements. Happy coding! 📚🌟

---

Feel free to customize this introduction further to match your project's specifics. Good luck with your Bookstore Management Web Application! 🚀
