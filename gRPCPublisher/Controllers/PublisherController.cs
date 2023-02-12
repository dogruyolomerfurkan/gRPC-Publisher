using Microsoft.AspNetCore.Mvc;

namespace gRPCPublisher.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello Publisher");
        }
    }
}
