namespace Architecture.Application.Example.Grid;

public sealed class GridExampleRequestValidator : AbstractValidator<GridExampleRequest>
{
    public GridExampleRequestValidator() => RuleFor(request => request).Grid();
}
