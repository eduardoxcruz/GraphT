﻿using Model.ValueObjects;

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
    public List<TodoTask> Upstream { get; set; }
    public List<TodoTask> Downstream { get; set; }

    public TodoTask(string name, bool isFun, bool isProductive, Status status)
    {
        Name = name;
        Id = Guid.NewGuid().ToString();
        IsFun = isFun;
        IsProductive = isProductive;
        Priority = Priority.FromValues(IsFun, IsProductive);
        Status = status;
        DatetimeInfo = new DatetimeInfo();
        Upstream = new List<TodoTask>();
        Downstream = new List<TodoTask>();
    }
}