using Microsoft.AspNetCore.Mvc;
using Observer.Observer;

namespace Observer.Controllers
{

    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet("deals")]
        public IActionResult Deals([FromServices]IEnumerable<IDealsObserver> observers, [FromServices]IDealsSubject subject)
        {
            foreach (var observer in observers)
            {
                subject.Attach(observer);
            }

            subject.SetDeals(new List<string> { "Xbox SX - R$4.500", "Xbox SS - R$2.100" });

            //return NoContent();
            return Ok(subject);
        }
    }
}
