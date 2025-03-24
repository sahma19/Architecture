using Microsoft.Extensions.DependencyInjection;

namespace Architecture.Web.Controllers;

[ApiController]
public abstract class BaseController : ControllerBase
{
    protected IMediator Mediator => HttpContext.RequestServices.GetRequiredService<IMediator>();
}
