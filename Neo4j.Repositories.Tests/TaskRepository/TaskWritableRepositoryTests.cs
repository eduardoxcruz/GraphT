namespace Neo4j.Repositories.Tests.TaskRepository;

public class TaskWritableRepositoryTests
{
    [Fact]
    public async void Create_ShouldCreateTaskAndReturnId()
    {
        // Arrange
        IGraphClient graphClient = Substitute.For<IGraphClient>();
        TaskWritableRepository repository = new(graphClient);
        TodoTask task = new("Test task", true, false, Status.ReadyToStart);

        // Act
        var taskId = await repository.Create(task);

        // Assert
        await graphClient.Cypher
            .Received(1)
            .Create("(todoTask:TodoTask {todoTask})")
            .WithParam("todoTask", task)
            .ExecuteWithoutResultsAsync();
        Assert.Equal(task.Id, taskId);
    }
    
    [Fact]
    public async void Create_ShouldThrowExceptionIfGraphClientFails()
    {
        // Arrange
        IGraphClient graphClient = Substitute.For<IGraphClient>();
        TaskWritableRepository repository = new(graphClient);
        TodoTask task = new("Test task", true, false, Status.ReadyToStart);

        // Act
        graphClient.Cypher
            .Create(Arg.Any<string>())
            .ExecuteWithoutResultsAsync()
            .Returns(_ => throw new Exception("Something wrong."));

        //Assert
        Exception exception = await Assert.ThrowsAsync<Exception>(() => graphClient.Cypher
            .Create(Arg.Any<string>())
            .ExecuteWithoutResultsAsync());
        Assert.Equal("Something wrong.", exception.Message);
    }
}