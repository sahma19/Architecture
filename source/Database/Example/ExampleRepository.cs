using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Database.Example;

public sealed class ExampleRepository(Context.Context context) : EFRepository<Domain.Example>(context), IExampleRepository
{
    public static Expression<Func<Domain.Example, ExampleModel>> Model => entity => new ExampleModel { Id = entity.Id, Name = entity.Name };

    public Task<ExampleModel> GetModelAsync(long id) => Queryable.Where(entity => entity.Id == id).Select(Model).SingleOrDefaultAsync();

    public Task<Grid<ExampleModel>> GridAsync(GridParameters parameters) => Queryable.Select(Model).GridAsync(parameters);

    public async Task<IEnumerable<ExampleModel>> ListModelAsync() => await Queryable.Select(Model).ToListAsync();
}
