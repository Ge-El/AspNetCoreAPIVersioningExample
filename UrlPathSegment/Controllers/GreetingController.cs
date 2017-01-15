using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Api.ControllersV1
{
    // Version of controller
    [ApiVersion("1.0")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class GreetingController : Controller
    {
        // GET api/hello
        [HttpGet]
        public string GetGreeting() => "Hello says v1.0";
    }
}

namespace Api.ControllersV2
{
    // Version of controller
    [ApiVersion("2.0")]
    [ApiVersion("3.0")]
    [Route("api/{version:apiVersion}/[controller]")]
    public class GreetingController : Controller
    {
        // GET api/2.0/greeting
        // GET api/3.0/greeting
        [HttpGet]
        public string GetGreeting() => "Hello says v2.0 and v3.0!";

        // GET api/2.0/greeting/George
        // GET api/3.0/greeting/George
        [HttpGet("{name}")]
        public string GetPersonalGreeting(string name) => $"Hello {name}!";
    }
}
