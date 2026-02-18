using Microsoft.AspNetCore.Mvc;
using ResultPatternApp.AppResults;

namespace ResultPatternApp.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public abstract class AbstractApiController : ControllerBase
{
    protected IActionResult ProcessResult(IAppResult result) 
        => StatusCode((int)result.StatusCode, result);
}