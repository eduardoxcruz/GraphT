using Common.Interfaces;

using DTOs.CreateIsolatedTask;

using UseCasesPorts.CreateIsolatedTask;

namespace Presenters.CreateIsolatedTask;

public class CreateIsolatedTaskPresenter : IPresenter<CreateIsolatedTaskOutputDto>, ICreateIsolatedTaskOutputPort
{
    public CreateIsolatedTaskOutputDto Content { get; private set;  }
    
    public ValueTask Handle(CreateIsolatedTaskOutputDto dto)
    {
        Content = dto;
        return ValueTask.CompletedTask;
    }
}