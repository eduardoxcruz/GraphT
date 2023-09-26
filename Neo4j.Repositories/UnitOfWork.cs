using Neo4jClient;

namespace Neo4j.Repositories;

public class UnitOfWork
{
    private readonly IGraphClient _graphClient;

    public UnitOfWork(IGraphClient graphClient)
    {
        _graphClient = graphClient;
    }
}