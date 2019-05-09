﻿using Microsoft.AspNetCore.Mvc;

namespace WebApi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Test2Controller : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "response from webapi2";
        }
    }
}