using DTOs.CreateIsolatedTask;

using UseCasesPorts.CreateIsolatedTask;

namespace Controllers.CreateIsolatedTask;

public class CreateIsolatedTaskController : ICreateIsolatedTaskController
{
    private readonly ICreateIsolatedTaskInputPort _inputPort;
    private readonly ICreateIsolatedTaskOutputPort _outputPort;

    public CreateIsolatedTaskController(ICreateIsolatedTaskInputPort inputPort, ICreateIsolatedTaskOutputPort outputPort)
    {
        _inputPort = inputPort;
        _outputPort = outputPort;
    }

    public ValueTask<CreateIsolatedTaskOutputDto> CreateIsolatedTask(CreateIsolatedTaskInputDto dto)
    {
        throw new NotImplementedException();
    }
}