public class Warehouse
{
    public List<IProduct> Products { get; private set; }

    public Warehouse()
    {
        Products = new List<IProduct>();
    }

    public void AddProduct(IProduct product)
    {
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }

        Products.Add(product);
    }

    public void RemoveProduct(IProduct product)
    {
        if (product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }

        Products.Remove(product);
    }
}