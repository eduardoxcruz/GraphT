using DTOs.CreateIsolatedTask;

namespace Controllers.CreateIsolatedTask;

public interface ICreateIsolatedTaskController
{
    ValueTask<CreateIsolatedTaskOutputDto> CreateIsolatedTask(CreateIsolatedTaskInputDto dto);
}