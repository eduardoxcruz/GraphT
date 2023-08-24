namespace Common.Interfaces;

public interface IPort
{
    ValueTask Handle();
}