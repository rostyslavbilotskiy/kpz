public class Money : IMoney
{
    public int WholePart { get; set; }
    public int FractionalPart { get; set; }

    public Money(int wholePart, int fractionalPart)
    {
        WholePart = wholePart;
        FractionalPart = fractionalPart;
    }

    public void Display()
    {
        Console.WriteLine($"Whole Part: {WholePart}, Fractional Part: {FractionalPart}");
    }
}
