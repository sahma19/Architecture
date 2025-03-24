using System.Collections.Generic;
using System.Threading.Tasks;

namespace Architecture.Application.File.Add;

public sealed record AddFileHandler : IHandler<AddFileRequest, IEnumerable<BinaryFile>>
{
    public async Task<Result<IEnumerable<BinaryFile>>> HandleAsync(AddFileRequest request)
    {
        var files = await request.Files.SaveAsync("Files");

        return new Result<IEnumerable<BinaryFile>>(Created, files);
    }
}
