public class Product : IProduct
{
    public string Name { get; set; }
    public string UnitOfMeasure { get; set; }
    public decimal PricePerUnit { get; set; }
    public int Quantity { get; set; }
    public DateTime LastDeliveryDate { get; set; }

    public Product(string name, string unitOfMeasure, decimal pricePerUnit, int quantity, DateTime lastDeliveryDate)
    {
        Name = name;
        UnitOfMeasure = unitOfMeasure;
        PricePerUnit = pricePerUnit;
        Quantity = quantity;
        LastDeliveryDate = lastDeliveryDate;
    }
}