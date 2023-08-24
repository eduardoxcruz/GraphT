using Model.ValueObjects;

namespace Model.Aggregates;

public class TaskAggregate
{
    public bool IsFun { get; private set; }
    public bool IsProductive { get; private set; }
    public Priority Priority { get; private set; }
    public Status Status { get; private set; }
}