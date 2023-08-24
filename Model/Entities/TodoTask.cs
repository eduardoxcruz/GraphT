namespace Model.Entities;

public class TodoTask
{
    public string Id { get; private set; }
    public string Name { get; set; }

    public TodoTask(string name)
    {
        Name = name;
        Id = DateTime.Now.Ticks + "-" + Name;
    }
}