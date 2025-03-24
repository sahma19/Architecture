using System.Threading.Tasks;

namespace Architecture.Database.Auth;

public interface IAuthRepository : IRepository<Domain.Auth>
{
    Task DeleteByUserIdAsync(long userId);

    Task<Domain.Auth> GetByLoginAsync(string login);
}
