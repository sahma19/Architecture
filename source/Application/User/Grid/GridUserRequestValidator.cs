namespace Architecture.Application.User.Grid;

public sealed class GridUserRequestValidator : AbstractValidator<GridUserRequest>
{
    public GridUserRequestValidator() => RuleFor(request => request).Grid();
}
