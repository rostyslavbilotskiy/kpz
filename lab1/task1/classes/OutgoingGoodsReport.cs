public class OutgoingGoodsReport : IReport
{
    private Warehouse warehouse;

    public OutgoingGoodsReport(Warehouse warehouse)
    {
        this.warehouse = warehouse;
    }

    public void GenerateReport()
    {
        Console.WriteLine("Outgoing Goods Report:");
        foreach (var product in warehouse.Products)
        {
            Console.WriteLine($"Product: {product.Name}, Quantity: {product.Quantity}, Last Delivery Date: {product.LastDeliveryDate}");
        }
    }
}