using System.Collections.Generic;
using System.Threading.Tasks;
using Architecture.Database.User;

namespace Architecture.Application.User.List;

public sealed record ListUserHandler(IUserRepository userRepository) : IHandler<ListUserRequest, IEnumerable<UserModel>>
{
    public async Task<Result<IEnumerable<UserModel>>> HandleAsync(ListUserRequest request)
    {
        var users = await userRepository.ListModelAsync();

        return new Result<IEnumerable<UserModel>>(users is null ? NotFound : OK, (IEnumerable<UserModel>)users);
    }
}
