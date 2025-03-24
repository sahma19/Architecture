namespace Architecture.Application.User.Delete;

public sealed class DeleteUserRequestValidator : AbstractValidator<DeleteUserRequest>
{
    public DeleteUserRequestValidator() => RuleFor(request => request.Id).Id();
}
