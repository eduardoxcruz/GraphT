using Model.Aggregates;

namespace Repositories.TaskRepository;

public interface ITaskWritableRepository
{
    void Create(TaskAggregate task);
}