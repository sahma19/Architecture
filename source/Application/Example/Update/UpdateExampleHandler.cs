using System.Threading.Tasks;
using Architecture.Database.Example;

namespace Architecture.Application.Example.Update;

public sealed record UpdateExampleHandler
(
    IExampleRepository exampleRepository,
    IUnitOfWork unitOfWork
)
: IHandler<UpdateExampleRequest>
{
    public async Task<Result> HandleAsync(UpdateExampleRequest request)
    {
        var entity = new Domain.Example(request.Id, request.Name);

        await exampleRepository.UpdateAsync(entity);

        await unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
