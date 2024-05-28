public class IncomingGoodsReport : IReport
{
    private Warehouse warehouse;

    public IncomingGoodsReport(Warehouse warehouse)
    {
        this.warehouse = warehouse;
    }

    public void GenerateReport()
    {
        Console.WriteLine("Incoming Goods Report:");
        foreach (var product in warehouse.Products)
        {
            Console.WriteLine($"Product: {product.Name}, Quantity: {product.Quantity}, Last Delivery Date: {product.LastDeliveryDate}");
        }
    }
}