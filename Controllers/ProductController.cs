using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutomationBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<string> { "Product 1", "Product 2", "Product 3" };
            return Ok(products);
        }
    }
}