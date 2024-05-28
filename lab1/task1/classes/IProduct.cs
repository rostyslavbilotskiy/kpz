public interface IProduct
{
    string Name { get; set; }
    string UnitOfMeasure { get; set; }
    decimal PricePerUnit { get; set; }
    int Quantity { get; set; }
    DateTime LastDeliveryDate { get; set; }
}