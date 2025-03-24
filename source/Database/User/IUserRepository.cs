using System.Collections.Generic;
using System.Threading.Tasks;

namespace Architecture.Database.User;

public interface IUserRepository : IRepository<Domain.User>
{
    Task<UserModel> GetModelAsync(long id);

    Task<Grid<UserModel>> GridAsync(GridParameters parameters);

    Task<IEnumerable<UserModel>> ListModelAsync();
}
