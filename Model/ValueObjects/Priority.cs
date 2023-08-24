using SeedWork;

namespace Model.ValueObjects;

public class Priority : Enumeration
{
    public static Priority Purposeful = new(1, nameof(Purposeful));
    public static Priority Necessary = new(2, nameof(Necessary));
    public static Priority Entertaining = new(3, nameof(Entertaining));
    public static Priority Superfluous = new(4, nameof(Superfluous));
    
    public Priority(int id, string name) : base(id, name)
    {
    }
    
    public static Priority FromValues(bool isFun, bool isProductive)
    {
        switch (isFun)
        {
            case true when isProductive:
                return Purposeful;
            case false when isProductive:
                return Necessary;
            case true when !isProductive:
                return Entertaining;
            default:
                return Superfluous;
        }
    }
}