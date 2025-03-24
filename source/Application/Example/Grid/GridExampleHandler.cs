using System.Threading.Tasks;
using Architecture.Database.Example;

namespace Architecture.Application.Example.Grid;

public sealed record GridExampleHandler(IExampleRepository exampleRepository) : IHandler<GridExampleRequest, Grid<ExampleModel>>
{
    public async Task<Result<Grid<ExampleModel>>> HandleAsync(GridExampleRequest request)
    {
        var grid = await exampleRepository.GridAsync(request);

        return new Result<Grid<ExampleModel>>(grid is null ? NotFound : OK, (Grid<ExampleModel>)grid);
    }
}
