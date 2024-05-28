public class InventoryReport : IReport
{
    private Warehouse warehouse;

    public InventoryReport(Warehouse warehouse)
    {
        this.warehouse = warehouse;
    }

    public void GenerateReport()
    {
        Console.WriteLine("Inventory Report:");
        foreach (var product in warehouse.Products)
        {
            Console.WriteLine($"Product: {product.Name}, Quantity: {product.Quantity}");
        }
    }
}