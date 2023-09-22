using Common.Interfaces;

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

    public async ValueTask<CreateIsolatedTaskOutputDto> CreateIsolatedTask(CreateIsolatedTaskInputDto dto)
    {
        await _inputPort.Handle(dto);
        return ((IPresenter<CreateIsolatedTaskOutputDto>)_outputPort).Content;
    }
}