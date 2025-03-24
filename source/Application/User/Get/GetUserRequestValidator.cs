namespace Architecture.Application.User.Get;

public sealed class GetUserRequestValidator : AbstractValidator<GetUserRequest>
{
    public GetUserRequestValidator() => RuleFor(request => request.Id).Id();
}
