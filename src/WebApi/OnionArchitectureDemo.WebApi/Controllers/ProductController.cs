using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureDemo.Application.Interfaces.Repository;

namespace OnionArchitectureDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public readonly IProductRepository ProductRepository { get; set; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

        }
    }
}
