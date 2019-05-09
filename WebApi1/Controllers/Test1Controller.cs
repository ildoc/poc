using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApi1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Test1Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return JsonConvert.SerializeObject("response from webapi1");
        }
    }
}
