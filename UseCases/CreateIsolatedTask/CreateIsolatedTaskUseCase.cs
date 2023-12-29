using Common.Repositories.TaskRepository;

using DTOs.CreateIsolatedTask;

using Model.Entities;

using UseCasesPorts.CreateIsolatedTask;

namespace UseCases.CreateIsolatedTask;

public class CreateIsolatedTaskUseCase : ICreateIsolatedTaskInputPort
{
    private readonly ICreateIsolatedTaskOutputPort _outputPort;
    private readonly ITaskWritableRepository _taskRepository;

    public CreateIsolatedTaskUseCase(
        ICreateIsolatedTaskOutputPort outputPort, 
        ITaskWritableRepository taskRepository)
    {
        _outputPort = outputPort;
        _taskRepository = taskRepository;
    }

    public async ValueTask Handle(CreateIsolatedTaskInputDto inputDto)
    {
        TodoTask task;
        CreateIsolatedTaskOutputDto outDto;
        string? taskId;

        task = new TodoTask(inputDto.Name, inputDto.IsFun, inputDto.IsProductive, inputDto.Status, inputDto.Complexity);
        taskId = await _taskRepository.Create(task);
        outDto = new CreateIsolatedTaskOutputDto(taskId);
        await _outputPort.Handle(outDto);
    }
}