using Common.Interfaces;

using DTOs.CreateIsolatedTask;

namespace Presenters.CreateIsolatedTask;

public class CreateIsolatedTaskPresenter : IPresenter<CreateIsolatedTaskOutputDto>
{
    public CreateIsolatedTaskOutputDto Content { get; }
}