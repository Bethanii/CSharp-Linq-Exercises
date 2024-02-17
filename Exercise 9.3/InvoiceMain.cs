using System;
using System.Linq;

class InvoiceMain
{
    static void Main()
    {
        var invoices = new[] {

            new Invoice(83, "Electric sander", 7, 57.98m),
            new Invoice(24, "Power saw", 18, 99.99m),
            new Invoice(7, "Sledge hammer", 11, 21.50m),
            new Invoice(77, "Hammer", 76, 11.99m),
            new Invoice(39, "Lawn mower", 3, 79.50m),
            new Invoice(68, "Screwdriver", 106, 6.99m),
            new Invoice(5, "Jig saw", 21, 11.00m),
            new Invoice(5, "Wrench", 34, 7.50m)};

        // Display all invoices
        Console.WriteLine("All Invoices:");
        foreach (var element in invoices)
        {
            Console.WriteLine(element);
        }

        // Order the Invoices by part description
        var descriptionSorted =
            from i in invoices
            orderby i.PartDescription
            select i;

        // Display Invoices sorted by part description
        Console.WriteLine("\nInvoices sorted by part description: ");
        foreach (var element in descriptionSorted)
        {
            Console.WriteLine(element.PartDescription);
        }

        // Use LINQ to sort invoices by price
        var priceSorted =
            from i in invoices
            orderby i.Price
            select i;

        // Display Invoices sorted by price
        Console.WriteLine("\nInvoices sorted by price:");
        foreach (var invoice in priceSorted)
        {
            Console.WriteLine($"Price: {invoice.Price:C}");
        }

        // Use LINQ to select PartDescription and Quantity and sort by Quantity
        var partDescAndQtySortedByQty =
            from i in invoices
            orderby i.Quantity
            select new { i.PartDescription, i.Quantity };

        // Display PartDescription and Quantity sorted by Quantity
        Console.WriteLine("\nPart Description and Quantity sorted by Quantity:");
        foreach (var item in partDescAndQtySortedByQty)
        {
            Console.WriteLine($"Part Description: {item.PartDescription}, Quantity: {item.Quantity}");
        }

        // Use LINQ to select PartDescription and Invoice Total and sort by Invoice Total
        var invoiceTotalSorted =
            from i in invoices
            let total = i.Quantity * i.Price 
            orderby total
            select new { i.PartDescription, i.InvoiceTotal };

        // Display PartDescription and Invoice Total sorted by Invoice Total
        Console.WriteLine("\nPart Description and Value of Invoice sorted by Invoice Total:");
        foreach (var item in invoiceTotalSorted)
        {
            Console.WriteLine($"Part Description: {item.PartDescription}, Invoice Total: {item.InvoiceTotal:C}");
        }

        // Filter a range of invoices using && in a LINQ query
        var between200And500 =
            from i in invoices
            where (i.InvoiceTotal >= 200m) && (i.InvoiceTotal <= 500m)
            select i;

        // Display Invoices between $200 and $500 per month
        Console.WriteLine("\nInvoices between " +
            $"{200m:C}-{500m:C} :");
        foreach (var element in between200And500)
        {
            Console.WriteLine($"Part Number: {element.PartNumber}, Invoice Total: {element.InvoiceTotal:C}");
        }
    }
}