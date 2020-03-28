using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Modrx.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthcheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (string.IsNullOrWhiteSpace(environment))
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, "Environment not set.");
            }

            return Ok(new { timestamp = DateTime.Now.ToString("o"), environment = environment });
        }
    }
}
