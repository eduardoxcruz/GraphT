using SeedWork;

namespace Model.ValueObjects;

public class Status : Enumeration
{
    public Status(int id, string name) : base(id, name) { }
}