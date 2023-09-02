using Common.Interfaces;
using Common.Repositories.TaskRepository;

using DTOs.CreateIsolatedTask;

using UseCasesPorts.CreateIsolatedTask;

namespace UseCases.CreateIsolatedTask;

public class CreateIsolatedTaskUseCase : ICreateIsolatedTaskInputPort
{
    private readonly ICreateIsolatedTaskOutputPort _outputPort;
    private readonly ITaskWritableRepository _taskRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateIsolatedTaskUseCase(
        ICreateIsolatedTaskOutputPort outputPort, 
        ITaskWritableRepository taskRepository,
        IUnitOfWork unitOfWork)
    {
        _outputPort = outputPort;
        _taskRepository = taskRepository;
        _unitOfWork = unitOfWork;
    }

    public ValueTask Handle(CreateIsolatedTaskInputDto dto)
    {
        throw new NotImplementedException();
    }
}