using Model.ValueObjects;

namespace Model.Entities;

public class TodoTask
{
    public string Id { get; private set; }
    public string Name { get; set; }
    public bool IsFun { get; set; }
    public bool IsProductive { get; set; }
    public float Progress { get; set; }
    public DatetimeInfo DatetimeInfo { get; set; }
    public Priority Priority { get; set; }
    public Status Status { get; set; }
    public Complexity Complexity { get; set; }
    public List<TodoTask> Upstream { get; set; }
    public List<TodoTask> Downstream { get; set; }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public TodoTask(string name, bool isFun, bool isProductive, Status status, Complexity? complexity = null)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    {
        Name = name;
        Id = Guid.NewGuid().ToString();
        IsFun = isFun;
        IsProductive = isProductive;
        Status = status;
        Complexity = complexity ?? Complexity.Indefinite;

        InitializePriority();
        InitializeDatetimeInfo();
        InitializeDependencies();
        InitializeProgress();
    }

    private void InitializePriority()
    {
        Priority = Priority.FromValues(IsFun, IsProductive);
    }

    private void InitializeDatetimeInfo()
    {
        DatetimeInfo = new DatetimeInfo();
    }

    private void InitializeDependencies()
    {
        Upstream = new List<TodoTask>();
        Downstream = new List<TodoTask>();
    }

    private void InitializeProgress()
    {
        if (Status.Equals(Status.Backlog) || Status.Equals(Status.ReadyToStart))
        {
            Progress = 0;
        }
    }
}