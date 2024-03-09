using Delivery.Item.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Delivery.Item.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetProductController : ControllerBase
    {
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetProductModel), 200)]
        public IActionResult GetProductById()
        {
            return Ok();
        }
    }
}
