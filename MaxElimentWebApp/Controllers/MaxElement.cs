using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MaxElimentWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaxElement : ControllerBase
    {
        [HttpGet(Name = "getMaxElementNumber")]

        public IActionResult getMaxElementNumber([FromQuery] int Number1, [FromQuery] int Number2)
        {
            return Ok("MaxElement Number1:" + Number1 + "and Number2:" + Number2);
        }
    }
}
