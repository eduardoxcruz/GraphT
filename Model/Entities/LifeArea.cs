namespace Model.Entities;

public class LifeArea
{
    public string Name { get; set; }
    public List<TodoTask> TodoTasks { get; set; }

    public LifeArea(string name)
    {
        Name = name;
        TodoTasks = new List<TodoTask>();
    }
}