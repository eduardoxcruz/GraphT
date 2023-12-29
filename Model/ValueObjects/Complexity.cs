using SeedWork;

namespace Model.ValueObjects;

public class Complexity : Enumeration
{
    public static Complexity Low = new(1, nameof(Low));
    public static Complexity Indefinite = new(2, nameof(Indefinite));
    public static Complexity High = new(3, nameof(High));
    
    public Complexity(int id, string name) : base(id, name) { }
}