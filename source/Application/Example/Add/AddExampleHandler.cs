using System.Threading.Tasks;
using Architecture.Database.Example;

namespace Architecture.Application.Example.Add;

public sealed record AddExampleHandler
(
    IExampleRepository exampleRepository,
    IUnitOfWork unitOfWork
)
: IHandler<AddExampleRequest, long>
{
    public async Task<Result<long>> HandleAsync(AddExampleRequest request)
    {
        var entity = new Domain.Example(request.Name);

        await exampleRepository.AddAsync(entity);

        await unitOfWork.SaveChangesAsync();

        return new Result<long>(Created, entity.Id);
    }
}
