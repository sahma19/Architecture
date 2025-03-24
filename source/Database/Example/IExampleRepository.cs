using System.Collections.Generic;
using System.Threading.Tasks;

namespace Architecture.Database.Example;

public interface IExampleRepository : IRepository<Domain.Example>
{
    Task<ExampleModel> GetModelAsync(long id);

    Task<Grid<ExampleModel>> GridAsync(GridParameters parameters);

    Task<IEnumerable<ExampleModel>> ListModelAsync();
}
