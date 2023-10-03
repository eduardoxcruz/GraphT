using Model.Entities;

namespace Common.Repositories.TaskRepository;

public interface ITaskWritableRepository
{
    ValueTask<string?> Create(TodoTask todoTask);

    ValueTask<string?> Update(TodoTask todoTask);
}