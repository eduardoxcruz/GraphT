namespace Neo4j.Repositories.Tests.TaskRepository;

public class TaskWritableRepositoryTests
{
    [Fact]
    public async void Create_ShouldCreateTaskAndReturnIdWhitBoltGraphClient()
    {
        // Arrange
        IGraphClient graphClient = new BoltGraphClient("neo4j://localhost:7687", "neo4j", "pass1234");
        await graphClient.ConnectAsync();
        TaskWritableRepository repository = new(graphClient);
        TodoTask task = new("TodoTask", true, false, Status.ReadyToStart, Complexity.Low);

        // Act
        var taskId = await repository.Create(task);

        Assert.Equal(task.Id, taskId);
        Assert.NotNull(task.Id);
        Assert.NotEmpty(task.Id);
    }
    
    [Fact]
    public async void Create_ShouldThrowExceptionIfGraphClientFails()
    {
        // Arrange
        IGraphClient graphClient = Substitute.For<IGraphClient>();
        TaskWritableRepository repository = new(graphClient);
        TodoTask task = new("Test task", true, false, Status.ReadyToStart, Complexity.High);

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