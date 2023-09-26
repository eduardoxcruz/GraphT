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

    public ValueTask<string> Create(TodoTask task)
    {
        throw new NotImplementedException();
    }

    public void Create(TaskAggregate task)
    {
        throw new NotImplementedException();
    }
}