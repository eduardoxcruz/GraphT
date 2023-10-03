namespace Common.Interfaces;

public interface IPort<T>
{
    ValueTask Handle(T dto);
}