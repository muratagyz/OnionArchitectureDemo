using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnionArchitectureDemo.Application.Features.Commands.CreateProduct;
using OnionArchitectureDemo.Application.Features.Queries.GetAllProducts;

namespace OnionArchitectureDemo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var query = new GetAllProductsQuery();
            return Ok(_mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateProductCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
