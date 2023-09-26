using Common.Interfaces;
using Common.Repositories.TaskRepository;

using DTOs.CreateIsolatedTask;

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
        TodoTask task;
        CreateIsolatedTaskOutputDto outDto;
        string? taskId;

        task = new TodoTask(inputDto.Name, inputDto.IsFun, inputDto.IsProductive, inputDto.Status);
        taskId = await _taskRepository.Create(task);
        outDto = new CreateIsolatedTaskOutputDto(taskId);
        await _outputPort.Handle(outDto);
    }
}