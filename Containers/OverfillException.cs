namespace Tutorial3.Containers;

public class OverfillException : Exception
{
    public OverfillException() : base()
    {
        Console.WriteLine("Overfill exception");
    }
}