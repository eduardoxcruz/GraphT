using Model.ValueObjects;

namespace DTOs.CreateIsolatedTask;

public class CreateIsolatedTaskInputDto
{
    public string Name { get; set; }
    public bool IsFun { get; set; }
    public bool IsProductive { get; set; }
    public Status Status { get;  set; }
    public Complexity? Complexity { get; set; }
}