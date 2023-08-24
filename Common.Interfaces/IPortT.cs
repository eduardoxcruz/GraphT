namespace Common.Interfaces;

public interface IPortT<T>
{
    ValueTask Handle(T dto);
}