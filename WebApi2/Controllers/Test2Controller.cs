using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebApi2.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class Test2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return JsonConvert.SerializeObject("response from webapi2");
        }
    }
}