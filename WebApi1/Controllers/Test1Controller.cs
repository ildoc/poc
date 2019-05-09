using Microsoft.AspNetCore.Mvc;

namespace WebApi1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Test1Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "response from webapi1";
        }
    }
}
