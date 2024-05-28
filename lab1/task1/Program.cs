class Program
{
    static void Main(string[] args)
    {
        // Створюємо нові продукти
        IProduct product1 = new Product("Product1", "kg", 100, 50, DateTime.Now);
        IProduct product2 = new Product("Product2", "kg", 200, 30, DateTime.Now);

        // Створюємо новий склад
        Warehouse warehouse = new Warehouse();

        // Додаємо продукти на склад
        warehouse.AddProduct(product1);
        warehouse.AddProduct(product2);

        // Створюємо звіти
        IReport incomingGoodsReport = new IncomingGoodsReport(warehouse);
        IReport outgoingGoodsReport = new OutgoingGoodsReport(warehouse);
        IReport inventoryReport = new InventoryReport(warehouse);

        // Створюємо сервіс звітності
        Reporting reporting = new Reporting();

        // Додаємо звіти до сервісу звітності
        reporting.AddReport(incomingGoodsReport);
        reporting.AddReport(outgoingGoodsReport);
        reporting.AddReport(inventoryReport);

        // Генеруємо звіти
        reporting.GenerateReports();

        Console.ReadKey();
    }
}