using CQRSMediator.Mediator;
using CQRSMediator.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediator.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private readonly ICqrsMediator _mediator;

        public ProductsController(ICqrsMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("with-mediator")]
        public async Task<IActionResult> GetAllWithMediator()
        {
            var query = new GetAllProductsQuery();

            var result = await _mediator.Handler(query);

            return Ok(result);
        }

        [HttpGet("{id}/with-mediator")]
        public async Task<IActionResult> GetByIdWithMediator(Guid id)
        {
            var query = new GetProductByIdQuery(id);

            var result = await _mediator.Handler(query);

            return Ok(result);

        }
    }
}
