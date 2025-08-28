using Action_Filters.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Action_Filters.Controllers;

[ApiController]
[Route("api/products")]
// [TrackActionTimeFilterV2]  // Controller level Registration
public class ProductController() : ControllerBase
{

    [HttpGet]
    [TrackActionTimeFilterV3]
    public IActionResult Get()
    {
        return Ok(new[] { "Keyboard [$52.99]", "Mouse, [$34.99]" });
    }
}

