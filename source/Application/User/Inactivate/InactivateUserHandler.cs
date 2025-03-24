using System.Threading.Tasks;
using Architecture.Database.User;

namespace Architecture.Application.User.Inactivate;

public sealed record InactivateUserHandler
(
    IUserRepository userRepository,
    IUnitOfWork unitOfWork
)
: IHandler<InactivateUserRequest>
{
    public async Task<Result> HandleAsync(InactivateUserRequest request)
    {
        var user = new Domain.User(request.Id);

        user.Inactivate();

        await userRepository.UpdatePartialAsync(new { user.Id, user.Status });

        await unitOfWork.SaveChangesAsync();

        return new Result(NoContent);
    }
}
