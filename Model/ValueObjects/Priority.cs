using SeedWork;

namespace Model.ValueObjects;

public class Priority : Enumeration
{
    public Priority(int id, string name) : base(id, name)
    {
    }
}