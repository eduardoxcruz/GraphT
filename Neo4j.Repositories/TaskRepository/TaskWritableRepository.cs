using Common.Repositories.TaskRepository;

using Model.Entities;

using Neo4jClient;
using Neo4jClient.Cypher;

namespace Neo4j.Repositories.TaskRepository;

public class TaskWritableRepository : ITaskWritableRepository
{
    private readonly IGraphClient _graphClient;

    public TaskWritableRepository(IGraphClient graphClient)
    {
        _graphClient = graphClient;
    }

    public async ValueTask<string?> Create(TodoTask todoTask)
    {
        string? taskId;

        try
        {
            ICypherFluentQuery? fluentQuery = _graphClient.Cypher
                .Create("(todoTask:TodoTask $todoTask)")
                .WithParam("todoTask", todoTask);
            string? queryText = fluentQuery.Query.QueryText;
            IDictionary<string, object>? queryParameters = fluentQuery.Query.QueryParameters;
            string? debugQueryText = fluentQuery.Query.DebugQueryText;
            await fluentQuery.ExecuteWithoutResultsAsync();
            taskId = todoTask.Id;
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }

        return taskId;
    }
}