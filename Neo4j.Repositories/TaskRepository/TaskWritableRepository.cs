using Common.Repositories.TaskRepository;

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

    public async ValueTask<string?> Create(TodoTask todoTask)
    {
        string? taskId;

        try
        {
            await _graphClient.Cypher
                // Buscar o crear el nodo de Priority con el nombre dado
                .Merge("(priority:Priority {Name: $priorityName})")
                // Buscar o crear el nodo de Status con el nombre dado
                .Merge("(status:Status {Name: $statusName})")
                // Crear el nodo de TodoTask con las propiedades dadas
                .Create("(todoTask:TodoTask $todoTask)")
                // Relacionar el nodo de TodoTask con el nodo de Priority
                .Create("(todoTask)-[:HAS_PRIORITY]->(priority)")
                // Relacionar el nodo de TodoTask con el nodo de Status
                .Create("(todoTask)-[:HAS_STATUS]->(status)")
                // Pasar los parámetros necesarios
                .WithParams(new Dictionary<string, object>
                {
                    { "todoTask", new {
                        todoTask.Id,
                        todoTask.Name,
                        todoTask.IsFun,
                        todoTask.IsProductive,
                        } 
                    },
                    { "priorityName", todoTask.Priority.Name },
                    { "statusName", todoTask.Status.Name }
                })
                .ExecuteWithoutResultsAsync();
            taskId = todoTask.Id;
        }
        catch (Exception exception)
        {
            throw new Exception(exception.Message);
        }

        return taskId;
    }
}