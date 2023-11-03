using Microsoft.AspNetCore.Mvc;

namespace State.Controllers
{
	[ApiController]
	[Route("api/orders")]
	public class OrdersController : ControllerBase
	{
		[HttpPost("state")]
		public IActionResult OrderState(OrderInputModel model)
		{

		}
	}
}
