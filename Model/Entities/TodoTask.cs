using Model.ValueObjects;

namespace Model.Entities;

public class TodoTask
{
    public string Id { get; private set; }
    public string Name { get; set; }
    public bool IsFun { get; private set; }
    public bool IsProductive { get; private set; }
    public Priority Priority { get; private set; }
    public Status Status { get; private set; }

    public TodoTask(string name, bool isFun, bool isProductive, Status status)
    {
        Name = name;
        Id = DateTime.Now.Ticks + "-" + Name;
        IsFun = isFun;
        IsProductive = isProductive;
        Priority = Priority.FromValues(IsFun, IsProductive);
        Status = status;
    }
}