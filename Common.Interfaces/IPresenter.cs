namespace Common.Interfaces;

public interface IPresenter<out T>
{
    public T Content { get; }
}