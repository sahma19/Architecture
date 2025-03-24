using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Architecture.Database.User;

public sealed class UserRepository(Context.Context context) : EFRepository<Domain.User>(context), IUserRepository
{
    public static Expression<Func<Domain.User, UserModel>> Model => entity => new UserModel
    {
        Id = entity.Id,
        Name = entity.Name,
        Email = entity.Email
    };

    public Task<UserModel> GetModelAsync(long id) => Queryable.Where(entity => entity.Id == id).Select(Model).SingleOrDefaultAsync();

    public Task<Grid<UserModel>> GridAsync(GridParameters parameters) => Queryable.Select(Model).GridAsync(parameters);

    public async Task<IEnumerable<UserModel>> ListModelAsync() => await Queryable.Select(Model).ToListAsync();
}
