namespace Common.Interfaces;

public interface IUnitOfWork
{
    ValueTask<int> SaveChanges();
}