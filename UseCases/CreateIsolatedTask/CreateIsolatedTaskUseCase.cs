using Common.Repositories.TaskRepository;

using UseCasesPorts.CreateIsolatedTask;

namespace UseCases.CreateIsolatedTask;

public class CreateIsolatedTaskUseCase
{
    private readonly ICreateIsolatedTaskOutputPort _outputPort;
    private readonly ITaskWritableRepository _taskRepository;

    public CreateIsolatedTaskUseCase(ICreateIsolatedTaskOutputPort outputPort, ITaskWritableRepository taskRepository)
    {
        _outputPort = outputPort;
        _taskRepository = taskRepository;
    }
}