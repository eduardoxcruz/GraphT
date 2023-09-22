using DTOs.CreateIsolatedTask;

namespace Controllers.CreateIsolatedTask;

public class CreateIsolatedTaskController : ICreateIsolatedTaskController
{
    public ValueTask<CreateIsolatedTaskOutputDto> CreateIsolatedTask(CreateIsolatedTaskInputDto dto)
    {
        throw new NotImplementedException();
    }
}