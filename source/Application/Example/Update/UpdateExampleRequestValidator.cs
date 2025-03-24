namespace Architecture.Application.Example.Update;

public sealed class UpdateExampleRequestValidator : AbstractValidator<UpdateExampleRequest>
{
    public UpdateExampleRequestValidator()
    {
        RuleFor(request => request.Id).Id();
        RuleFor(request => request.Name).Name();
    }
}
