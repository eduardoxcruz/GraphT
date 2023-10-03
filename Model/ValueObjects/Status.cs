using SeedWork;

namespace Model.ValueObjects;

public class Status : Enumeration
{
    public static Status Completed = new(1, nameof(Completed));
    public static Status Droped = new(2, nameof(Droped));
    public static Status Paused = new(3, nameof(Paused));
    public static Status InProgress = new(4, nameof(InProgress));
    public static Status ReadyToStart = new(5, nameof(ReadyToStart));
    public static Status Backlog = new(6, nameof(Backlog));
    
    public Status(int id, string name) : base(id, name) { }
}