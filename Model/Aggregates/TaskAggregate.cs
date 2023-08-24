using Model.ValueObjects;

namespace Model.Aggregates;

public class TaskAggregate
{
    public Priority Priority { get; private set; }
}