using System.Threading.Tasks;
using Architecture.Database.Example;

namespace Architecture.Application.Example.Delete;

public sealed record DeleteExampleHandler
(
    IExampleRepository exampleRepository,
    IUnitOfWork unitOfWork
)
: IHandler<DeleteExampleRequest>
{
    public async Task<Result> HandleAsync(DeleteExampleRequest request)
    {
        await exampleRepository.DeleteAsync(request.Id);

        await unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
