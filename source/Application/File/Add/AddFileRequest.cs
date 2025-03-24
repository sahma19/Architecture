using System.Collections.Generic;

namespace Architecture.Application.File.Add;

public sealed record AddFileRequest(IList<BinaryFile> Files);
