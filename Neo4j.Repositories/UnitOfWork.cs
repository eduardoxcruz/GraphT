using Common.Interfaces;

using Neo4jClient;

namespace Neo4j.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly IGraphClient _graphClient;

    public UnitOfWork(IGraphClient graphClient)
    {
        _graphClient = graphClient;
    }

    public ValueTask<int> SaveChanges()
    {
        throw new NotImplementedException();
    }
}