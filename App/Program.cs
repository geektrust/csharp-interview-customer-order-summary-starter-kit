using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public string CustomerName { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }
}

public class CustomerSummary
{
    public string CustomerName { get; set; }
    public int OrderCount { get; set; }
    public decimal TotalAmount { get; set; }
}

public class OrderAnalyzer
{
    public List<CustomerSummary> GetCustomerSummaries(List<Order> orders)
    {
        // Your code here
        return new List<CustomerSummary>();
    }
}

public class Program
{
    // Scratch pad - use this to try out your code with `dotnet run --project App`.
    public static void Main(string[] args)
    {
    }
}
