namespace Architecture.Application.Auth;

public sealed class AuthRequestValidator : AbstractValidator<AuthRequest>
{
    public AuthRequestValidator()
    {
        RuleFor(request => request.Login).Login();
        RuleFor(request => request.Password).Password();
    }
}
