using Model.Aggregates;
using Model.Entities;

namespace Common.Repositories.TaskRepository;

public interface ITaskWritableRepository
{
    void Create(TodoTask task);
    
    void Create(TaskAggregate task);
}