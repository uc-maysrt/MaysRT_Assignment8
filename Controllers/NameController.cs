using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class NameController : ControllerBase
{
    [HttpGet]
    public IActionResult GetName()
    {
        var myName = new { name = "Robert Mays" };
        return new JsonResult(myName);
    }
}