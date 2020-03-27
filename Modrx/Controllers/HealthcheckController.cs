using System;
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
            return Ok(new { timestamp = DateTime.Now.ToString("o") });
        }
    }
}
