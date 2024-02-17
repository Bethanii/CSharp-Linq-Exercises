class Invoice
{
    public int PartNumber { get; }
    public string PartDescription { get; }
    public int Quantity { get; }
    public decimal Price { get; }

    public Invoice(int partNumber, string partDescription,
       int quantity, decimal price)
    {
        PartNumber = partNumber;
        PartDescription = partDescription;
        Quantity = quantity;
        Price = price;
    }

    public decimal InvoiceTotal
    {
        get
        {
            return Quantity * Price;
        }
    }

    public override string ToString() =>
       $"Part Number: {PartNumber}, Description: {PartDescription}, Quantity: {Quantity}, Price: {Price:C}";
}