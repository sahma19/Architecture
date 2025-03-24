using System.Collections.Generic;
using System.Threading.Tasks;
using Architecture.Database.Example;

namespace Architecture.Application.Example.List;

public sealed record ListExampleHandler(IExampleRepository exampleRepository) : IHandler<ListExampleRequest, IEnumerable<ExampleModel>>
{
    public async Task<Result<IEnumerable<ExampleModel>>> HandleAsync(ListExampleRequest request)
    {
        var list = await exampleRepository.ListModelAsync();

        return new Result<IEnumerable<ExampleModel>>(list is null ? NotFound : OK, (IEnumerable<ExampleModel>)list);
    }
}
