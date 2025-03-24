using System.Collections.Generic;
using Architecture.Application.User.Add;
using Architecture.Application.User.Delete;
using Architecture.Application.User.Get;
using Architecture.Application.User.Grid;
using Architecture.Application.User.Inactivate;
using Architecture.Application.User.List;
using Architecture.Application.User.Update;

namespace Architecture.Web.Controllers;

[ApiController]
[Route("api/users")]
public sealed class UserController : BaseController
{
    [HttpPost]
    public IActionResult Add(AddUserRequest request) => Mediator.HandleAsync<AddUserRequest, long>(request).ApiResult();

    [HttpDelete("{id:long}")]
    public IActionResult Delete(long id) => Mediator.HandleAsync(new DeleteUserRequest(id)).ApiResult();

    [HttpGet("{id:long}")]
    public IActionResult Get(long id) => Mediator.HandleAsync<GetUserRequest, UserModel>(new GetUserRequest(id)).ApiResult();

    [HttpGet("grid")]
    public IActionResult Grid([FromQuery] GridUserRequest request) => Mediator.HandleAsync<GridUserRequest, Grid<UserModel>>(request).ApiResult();

    [HttpPatch("{id:long}/inactivate")]
    public IActionResult Inactivate(long id) => Mediator.HandleAsync(new InactivateUserRequest(id)).ApiResult();

    [HttpGet]
    public IActionResult List() => Mediator.HandleAsync<ListUserRequest, IEnumerable<UserModel>>(new ListUserRequest()).ApiResult();

    [HttpPut("{id:long}")]
    public IActionResult Update(long id, UpdateUserRequest request) => Mediator.HandleAsync(request with { Id = id }).ApiResult();
}
