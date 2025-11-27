using System;
using System.Collections.Generic;

class Sale
{
    public DateTime date;
    public string item;
    public int quantity;
    public decimal pricePerItem;

    public decimal Total()
    {
        return quantity * pricePerItem;
    }
}

class Program
{
    static List<Sale> sales = new List<Sale>(); // dynamic list, unlimited entries

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Sales & Revenue Tracker ---");
            Console.WriteLine("1. Add Sale");
            Console.WriteLine("2. View All Sales");
            Console.WriteLine("3. Daily Summary");
            Console.WriteLine("4. Monthly Summary");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1") AddSale();
            else if (choice == "2") ViewSales();
            else if (choice == "3") DailySummary();
            else if (choice == "4") MonthlySummary();
            else if (choice == "5") break;
            else Console.WriteLine("Invalid option!");
        }
    }

    static void AddSale()
    {
        Sale s = new Sale();

        Console.Write("Enter Item Name: ");
        s.item = Console.ReadLine();

        Console.Write("Enter Quantity Sold: ");
        s.quantity = int.Parse(Console.ReadLine());

        Console.Write("Enter Price per Item: ");
        s.pricePerItem = decimal.Parse(Console.ReadLine());

        s.date = DateTime.Now;

        sales.Add(s);

        Console.WriteLine("Sale Added Successfully!");
    }

    static void ViewSales()
    {
        Console.WriteLine("\n--- All Sales ---");
        foreach (Sale s in sales)
        {
            Console.WriteLine($"{s.date.ToShortDateString()} | {s.item} | Qty: {s.quantity} | Price: {s.pricePerItem:C} | Total: {s.Total():C}");
        }
    }

    static void DailySummary()
    {
        Console.Write("\nEnter date (yyyy-mm-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        int totalSales = 0;
        decimal totalRevenue = 0;

        foreach (Sale s in sales)
        {
            if (s.date.Date == date.Date)
            {
                totalSales++;
                totalRevenue += s.Total();
            }
        }

        Console.WriteLine($"\n--- Daily Summary for {date.ToShortDateString()} ---");
        Console.WriteLine($"Total Sales: {totalSales}");
        Console.WriteLine($"Total Revenue: {totalRevenue:C}");
    }

    static void MonthlySummary()
    {
        Console.Write("\nEnter month and year (MM-yyyy): ");
        string input = Console.ReadLine();
        DateTime month = DateTime.ParseExact(input, "MM-yyyy", null);

        int totalSales = 0;
        decimal totalRevenue = 0;

        foreach (Sale s in sales)
        {
            if (s.date.Month == month.Month && s.date.Year == month.Year)
            {
                totalSales++;
                totalRevenue += s.Total();
            }
        }

        Console.WriteLine($"\n--- Monthly Summary for {month:MMMM yyyy} ---");
        Console.WriteLine($"Total Sales: {totalSales}");
        Console.WriteLine($"Total Revenue: {totalRevenue:C}");
    }
}
