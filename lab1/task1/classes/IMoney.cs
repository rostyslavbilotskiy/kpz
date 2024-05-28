public interface IMoney
{
    int WholePart { get; set; }
    int FractionalPart { get; set; }
    void Display();
}