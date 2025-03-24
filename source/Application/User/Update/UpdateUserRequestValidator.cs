namespace Architecture.Application.User.Update;

public sealed class UpdateUserRequestValidator : AbstractValidator<UpdateUserRequest>
{
    public UpdateUserRequestValidator()
    {
        RuleFor(request => request.Id).Id();
        RuleFor(request => request.Name).Name();
        RuleFor(request => request.Email).Email();
    }
}
