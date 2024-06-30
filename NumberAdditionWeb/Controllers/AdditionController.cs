using Microsoft.AspNetCore.Mvc;

namespace NumberAdditionWeb.Controllers;

[ApiController]
[Route("[controller]")]
public class AdditionController : ControllerBase
{
    [HttpGet("{a}/{b}")]
    public ActionResult<double> Add(double a, double b)
    {
        return a + b;
    }
}