using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Api.ControllersV1
{
    // Version of controller
    [ApiVersion("1.0")]  
    [Route("api/[controller]")]
    public class GreetingController : Controller
    {
        // GET api/greeting
        [HttpGet]
        public string GetGreeting() => "Hello says v1.0";
    }
}

namespace Api.ControllersV2
{
    // Version of controller
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [Route("api/[controller]")]
    public class GreetingController : Controller
    {
        // GET api/greeting
        [HttpGet]
        public string GetGreeting() => "Hello says v2.0 and v3.0!";

        // GET api/greeting/george
        [HttpGet("{name}")]
        public string GetPersonalGreeting(string name) => $"Hello {name}!";
    }

}
