using Model.Entities;
using Model.ValueObjects;

namespace Model.Aggregates;

public class TaskAggregate : TodoTask
{
    public bool IsFun { get; private set; }
    public bool IsProductive { get; private set; }
    public Priority Priority { get; private set; }
    public Status Status { get; private set; }

    public TaskAggregate(long id, string name, bool isFun, bool isProductive, Status status) : base(id, name)
    {
        IsFun = isFun;
        IsProductive = isProductive;
        Priority = Priority.FromValues(IsFun, IsProductive);
        Status = status;
    }
}