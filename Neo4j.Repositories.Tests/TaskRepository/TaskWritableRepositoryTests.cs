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
}