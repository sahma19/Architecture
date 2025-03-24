namespace Architecture.Application.Example.Add;

public sealed class AddExampleRequestValidator : AbstractValidator<AddExampleRequest>
{
    public AddExampleRequestValidator() => RuleFor(request => request.Name).Name();
}
