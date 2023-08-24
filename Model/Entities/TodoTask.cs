namespace Model.Entities;

public class TodoTask
{
    public long Id { get; set; }
    public string Name { get; set; }

    public TodoTask(long id, string name, bool isFun, bool isProductive)
    {
        Id = id;
        Name = name;
    }
}