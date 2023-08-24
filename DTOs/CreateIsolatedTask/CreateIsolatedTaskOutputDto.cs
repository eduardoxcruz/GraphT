namespace DTOs.CreateIsolatedTask;

public class CreateIsolatedTaskOutputDto
{
    public string TaskId { get; set; }

    public CreateIsolatedTaskOutputDto(string taskId)
    {
        TaskId = taskId;
    }
}