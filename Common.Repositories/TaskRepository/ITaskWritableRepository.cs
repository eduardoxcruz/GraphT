using Model.Aggregates;

namespace Common.Repositories.TaskRepository;

public interface ITaskWritableRepository
{
    void Create(TaskAggregate task);
}