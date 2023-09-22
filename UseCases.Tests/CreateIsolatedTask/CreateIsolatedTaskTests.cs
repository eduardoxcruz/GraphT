using Common.Interfaces;
using Common.Repositories.TaskRepository;

using DTOs.CreateIsolatedTask;

using Model.Entities;
using Model.ValueObjects;

using NSubstitute;

using UseCases.CreateIsolatedTask;

using UseCasesPorts.CreateIsolatedTask;

namespace UseCases.Tests.CreateIsolatedTask;

public class CreateIsolatedTaskTests
{
    [Fact]
    public async void Handle_ShouldCreateNewTaskAndCallOutputPort()
    {
        // Arrange
        CreateIsolatedTaskInputDto inputDto = new()
        {
            Name = "Test task", 
            IsFun = true, 
            IsProductive = false, 
            Status = Status.InProgress
        };
        ICreateIsolatedTaskOutputPort? outputPort = Substitute.For<ICreateIsolatedTaskOutputPort>();
        ITaskWritableRepository? taskRepository = Substitute.For<ITaskWritableRepository>();
        IUnitOfWork? unitOfWork = Substitute.For<IUnitOfWork>();
        CreateIsolatedTaskUseCase useCase = new(outputPort, taskRepository, unitOfWork);

        // Act
        await useCase.Handle(inputDto);

        // Assert
        TodoTask expectedTask = new(inputDto.Name, inputDto.IsFun, inputDto.IsProductive, inputDto.Status);
        taskRepository.Received(1).Create(Arg.Is<TodoTask>(todoTask => 
            todoTask.Name.Equals(expectedTask.Name) &&
            todoTask.IsFun == expectedTask.IsFun &&
            todoTask.IsProductive == expectedTask.IsProductive &&
            todoTask.Status.Equals(expectedTask.Status) &&
            todoTask.Priority.Equals(expectedTask.Priority)
            ));
        await unitOfWork.Received(1).SaveChanges();
        await outputPort.Received(1).Handle(Arg.Is<CreateIsolatedTaskOutputDto>(o => !String.IsNullOrEmpty(o.TaskId)));
    }
}