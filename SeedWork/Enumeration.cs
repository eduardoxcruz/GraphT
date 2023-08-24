namespace SeedWork;

public abstract class Enumeration : IComparable
{
    public string Name { get; private set; }

    public int Id { get; private set; }
    
    protected Enumeration(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }

    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
}