using System.Threading.Tasks;
using Architecture.Database.Auth;
using Architecture.Database.User;

namespace Architecture.Application.User.Delete;

public sealed record DeleteUserHandler
(
    IAuthRepository authRepository,
    IUserRepository userRepository,
    IUnitOfWork unitOfWork
)
: IHandler<DeleteUserRequest>
{
    public async Task<Result> HandleAsync(DeleteUserRequest request)
    {
        await authRepository.DeleteByUserIdAsync(request.Id);

        await userRepository.DeleteAsync(request.Id);

        await unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
