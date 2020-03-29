using Microsoft.AspNetCore.Mvc;
using Modrx.Repository.Interface;

namespace Modrx.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DealersController : ControllerBase
    {
        private readonly IDealerRepository _dealerRepository;

        public DealersController(IDealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            string search = HttpContext.Request.Query["search"];

            if (string.IsNullOrWhiteSpace(search))
            {
                var dealers = _dealerRepository.GetAllDealers();
                return Ok(dealers);
            }
            else
            {
                var dealers = _dealerRepository.SearchDealers(search);
                return Ok(dealers);
            }
        }
    }
}