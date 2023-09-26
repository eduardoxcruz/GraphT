using Common.Repositories.TaskRepository;

using Model.Aggregates;
using Model.Entities;

using Neo4jClient;

namespace Neo4j.Repositories.TaskRepository;

public class TaskWritableRepository : ITaskWritableRepository
{
    private readonly IGraphClient _graphClient;

    public TaskWritableRepository(IGraphClient graphClient)
    {
        _graphClient = graphClient;
    }

    public async ValueTask<string?> Create(TodoTask task)
    {
        string? taskId;

        try
        {
            await _graphClient.Cypher
                .Create("(todoTask:TodoTask {todoTask})")
                .WithParam("todoTask", task)
                .ExecuteWithoutResultsAsync();
            taskId = task.Id;
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }

        return taskId;
    }

    public void Create(TaskAggregate task)
    {
        throw new NotImplementedException();
    }
}