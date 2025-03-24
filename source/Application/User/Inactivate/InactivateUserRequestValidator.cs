namespace Architecture.Application.User.Inactivate;

public sealed class InactivateUserRequestValidator : AbstractValidator<InactivateUserRequest>
{
    public InactivateUserRequestValidator() => RuleFor(request => request.Id).Id();
}
