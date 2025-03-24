using System;
using System.Collections.Generic;
using Architecture.Application.File.Add;
using Architecture.Application.File.Get;

namespace Architecture.Web.Controllers;

[ApiController]
[Route("api/files")]
public sealed class FileController : BaseController
{
    [DisableRequestSizeLimit]
    [HttpPost]
    public IActionResult Add() => Mediator.HandleAsync<AddFileRequest, IEnumerable<BinaryFile>>(new AddFileRequest(Request.Files())).ApiResult();

    [HttpGet("{id:guid}")]
    public IActionResult Get(Guid id) => Mediator.HandleAsync<GetFileRequest, BinaryFile>(new GetFileRequest(id)).ApiResult();
}
