using System.Threading.Tasks;

namespace Architecture.Database.Auth;

public sealed class AuthRepository(Context.Context context) : EFRepository<Domain.Auth>(context), IAuthRepository
{
    public Task DeleteByUserIdAsync(long userId) => DeleteAsync(entity => entity.User.Id == userId);

    public Task<Domain.Auth> GetByLoginAsync(string login) => Queryable.SingleOrDefaultAsync(entity => entity.Login == login);
}
