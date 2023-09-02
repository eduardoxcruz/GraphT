using Common.Repositories.TaskRepository;

using DTOs.CreateIsolatedTask;

using UseCasesPorts.CreateIsolatedTask;

namespace UseCases.CreateIsolatedTask;

public class CreateIsolatedTaskUseCase : ICreateIsolatedTaskInputPort
{
    private readonly ICreateIsolatedTaskOutputPort _outputPort;
    private readonly ITaskWritableRepository _taskRepository;

    public CreateIsolatedTaskUseCase(ICreateIsolatedTaskOutputPort outputPort, ITaskWritableRepository taskRepository)
    {
        _outputPort = outputPort;
        _taskRepository = taskRepository;
    }

    public ValueTask Handle(CreateIsolatedTaskInputDto dto)
    {
        throw new NotImplementedException();
    }
}