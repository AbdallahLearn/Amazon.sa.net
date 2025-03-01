# ASP.NET Core MVC Store Application

## Overview
This is a web-based store management system built with ASP.NET Core MVC. It allows users to browse products, place orders, and view their order history. The application follows the MVC architecture, implements model validation, and uses routing to manage user interactions efficiently.

## Features

### **Product Management**
- Supports different product categories (Electronics, Clothing).
- Displays a product list with detailed information.
- Implements discount logic based on product category.

### **Order Management**
- Allows users to place orders via an intuitive web interface.
- Stores and displays order history per user.
- Ensures stock availability before processing orders.

### **Exception Handling**
- Implements model validation to prevent invalid inputs.
- Ensures robust error handling for a smooth user experience.

## Technologies Used
- ASP.NET Core MVC (using .NET Core 8 or 9)
- C#
- Entity Framework Core (for data management)
- Razor Views
- Bootstrap (for UI enhancements)

## Project Setup
### 1. Clone the Repository
```sh
git clone https://github.com/your-repo-name/StoreApp.git
cd StoreApp
```

### 2. Build and Run the Application
```sh
dotnet build
dotnet run
```

### 3. Access the Application
- Open a web browser and navigate to `http://localhost:5000` (or your assigned port).

## MVC Implementation
### **Models**
Defines models for:
- `User`
- `Product`
- `Order`
- `OrderDetails`

### **Views**
- **Product List View**: Displays all available products.
- **Order Form**: Allows users to place orders.
- **Order History View**: Shows past orders per user.

### **Controllers**
- Handles data retrieval and user interactions.
- Uses attribute-based routing to manage requests.

## Routing & User Input Handling
### **Endpoints Implemented:**
- `GET /Products` → Fetch and display all products.
- `GET /Orders/{userId}` → Retrieve and display user order history.

### **Model Validation:**
- Ensures correct data submission.
- Prevents negative order quantities or invalid inputs.

## Bonus Features (Optional)
- **Session Management**: Keeps users logged in across visits.
- **Bootstrap Integration**: Enhances the UI for better user experience.

## Future Enhancements
- Implement a database (SQL Server or PostgreSQL) for persistent storage.
- Add authentication and authorization for user management.
- Integrate API endpoints for external interactions.

## Author
**Abdullah Al-Juhani**

