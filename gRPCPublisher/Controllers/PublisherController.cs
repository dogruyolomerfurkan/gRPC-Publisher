using Microsoft.AspNetCore.Mvc;

namespace gRPCPublisher.Controllers
{
    [Route("grpcpublisher/[controller]")]
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