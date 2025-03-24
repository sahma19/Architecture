namespace Architecture.Application.Example.Get;

public sealed class GetExampleRequestValidator : AbstractValidator<GetExampleRequest>
{
    public GetExampleRequestValidator() => RuleFor(request => request.Id).Id();
}
