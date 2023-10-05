﻿using Model.ValueObjects;

namespace Model.Entities;

public class TodoTask
{
    public string Id { get; private set; }
    public string Name { get; set; }
    public bool IsFun { get; set; }
    public bool IsProductive { get; set; }
    public DateTime? StartTime { get; set; }
    public DateTime? FinishTime { get; set; }
    public DateTime? LimitDate { get; set; }
    public Priority Priority { get; set; }
    public Status Status { get; set; }

    public TodoTask(string name, bool isFun, bool isProductive, Status status)
    {
        Name = name;
        Id = Guid.NewGuid().ToString();
        IsFun = isFun;
        IsProductive = isProductive;
        Priority = Priority.FromValues(IsFun, IsProductive);
        Status = status;
    }
}