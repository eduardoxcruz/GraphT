using Model.Aggregates;
using Model.Entities;

namespace Common.Repositories.TaskRepository;

public interface ITaskWritableRepository
{
    ValueTask<string> Create(TodoTask task);
    
    void Create(TaskAggregate task);
}