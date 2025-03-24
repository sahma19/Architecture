namespace Architecture.Application.Example.Delete;

public sealed class DeleteExampleRequestValidator : AbstractValidator<DeleteExampleRequest>
{
    public DeleteExampleRequestValidator() => RuleFor(request => request.Id).Id();
}
