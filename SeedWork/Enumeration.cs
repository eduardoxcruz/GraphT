namespace SeedWork;

public abstract class Enumeration : IComparable
{
    public string Name { get; private set; }

    public int Id { get; private set; }
    
    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}