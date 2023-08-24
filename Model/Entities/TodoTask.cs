﻿namespace Model.Entities;

public class TodoTask
{
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsFun { get; private set; }
    public bool IsProductive { get; private set; }
    public float Progress { get; set; }

    public TodoTask(long id, string name, bool isFun, bool isProductive, float progress)
    {
        Id = id;
        Name = name;
        IsFun = isFun;
        IsProductive = isProductive;
        Progress = progress;
    }
}