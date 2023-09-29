using Common.Repositories.TaskRepository;

using DTOs.CreateIsolatedTask;

using Model.Entities;
using Model.ValueObjects;

using NSubstitute;

using UseCases.CreateIsolatedTask;

using UseCasesPorts.CreateIsolatedTask;

namespace UseCases.Tests.CreateIsolatedTask;

public class CreateIsolatedTaskUseCaseTests
{
    [Fact]
    public async void Handle_ShouldCreateTaskAndCallOutputPort()
    {
        // Arrange
        ICreateIsolatedTaskOutputPort outputPort = Substitute.For<ICreateIsolatedTaskOutputPort>();
        ITaskWritableRepository taskRepository = Substitute.For<ITaskWritableRepository>();
        CreateIsolatedTaskUseCase useCase = new(outputPort, taskRepository);
        CreateIsolatedTaskInputDto inputDto = new()
        {
            Name = "Test task", 
            IsFun = true, 
            IsProductive = false, 
            Status = Status.ReadyToStart
        };

        // Act
        taskRepository
            .Create(Arg.Any<TodoTask>())
            .Returns("New Task Id");
        await useCase.Handle(inputDto);

        // Assert
        await taskRepository.Received(1).Create(Arg.Is<TodoTask>(todoTask => 
                todoTask.Name == inputDto.Name && 
                todoTask.IsFun == inputDto.IsFun && 
                todoTask.IsProductive == inputDto.IsProductive && 
                todoTask.Status.Equals(inputDto.Status)));
        await outputPort.Received(1).Handle(Arg.Is<CreateIsolatedTaskOutputDto>(outputDto => 
            outputDto.TaskId!.Equals("New Task Id")));
    }
}