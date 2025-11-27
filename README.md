# Sales-Revenue-Tracker-C-
Sales & Revenue Tracker

A simple C# console application to track sales, revenue, and profits for small businesses.
This version uses a dynamic list, so it can handle unlimited sales entries.

Features ✅

Add Sale: Enter item name, quantity sold, and price per item.

View All Sales: Displays all sales records with total amount.

Daily Summary: Shows total sales and revenue for a specific date.

Monthly Summary: Shows total sales and revenue for a specific month.

Dynamic Storage: Uses List<Sale> to store an unlimited number of sales.

Simple Console Interface: Easy-to-use menu-driven program.

How to Run 💻

Clone the repository or download the source code.

Open the project in Visual Studio or any C# IDE.

Build and run the program.

Use the menu options to add sales, view records, or generate summaries.

Example Usage 📊
--- Sales & Revenue Tracker ---
1. Add Sale
2. View All Sales
3. Daily Summary
4. Monthly Summary
5. Exit
Choose an option: 1
Enter Item Name: Pen
Enter Quantity Sold: 10
Enter Price per Item: 5
Sale Added Successfully!

Choose an option: 2

--- All Sales ---
27/11/2025 | Pen | Qty: 10 | Price: $5.00 | Total: $50.00

Choose an option: 3
Enter date (yyyy-mm-dd): 2025-11-27

--- Daily Summary for 27/11/2025 ---
Total Sales: 1
Total Revenue: $50.00

Project Structure 📁
SalesRevenueTracker/
├── Program.cs       # Main program file
└── README.md        # Project documentation

Notes ✨
Uses List<Sale> to store sales dynamically (no fixed limit).
Beginner-friendly console program for learning C# basics, loops, arrays, and lists.
Can be extended to save data to a file for persistent storage.
