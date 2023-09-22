using Common.Interfaces;
using Common.Repositories.TaskRepository;

using DTOs.CreateIsolatedTask;

using Model.Aggregates;
using Model.Entities;

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

    public async ValueTask Handle(CreateIsolatedTaskInputDto inputDto)
    {
        TodoTask task = new(inputDto.Name, inputDto.IsFun, inputDto.IsProductive, inputDto.Status);
        CreateIsolatedTaskOutputDto outDto = new(task);
        _taskRepository.Create(task);
        await _unitOfWork.SaveChanges();
        await _outputPort.Handle(outDto);
    }
}