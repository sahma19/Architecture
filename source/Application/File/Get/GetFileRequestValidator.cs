namespace Architecture.Application.File.Get;

public sealed class GetFileRequestValidator : AbstractValidator<GetFileRequest>
{
    public GetFileRequestValidator() => RuleFor(request => request.Id).Guid();
}
