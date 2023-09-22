using Common.Repositories.TaskRepository;

using Model.Aggregates;
using Model.Entities;

namespace Neo4j.Repositories.TaskRepository;

public class TaskWritableRepository : ITaskWritableRepository
{
    public void Create(TodoTask task)
    {
        throw new NotImplementedException();
    }

    public void Create(TaskAggregate task)
    {
        throw new NotImplementedException();
    }
}