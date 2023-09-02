using Model.Entities;

namespace DTOs.CreateIsolatedTask;

public class CreateIsolatedTaskOutputDto
{
    public string TaskId { get; set; }

    public CreateIsolatedTaskOutputDto(TodoTask task)
    {
        TaskId = task.Id;
    }
}