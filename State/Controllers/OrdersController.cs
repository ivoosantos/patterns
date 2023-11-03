using Microsoft.AspNetCore.Mvc;
using State.States;
using static Models.OrderModel;

namespace State.Controllers
{
	[ApiController]
	[Route("api/orders")]
	public class OrdersController : ControllerBase
	{
		[HttpPost("state")]
		public IActionResult OrderState(OrderInputModel model)
		{
			var items = model.Items.Select(i => i.ProductId).ToList();

			var context = new OrderStateContext(new OrderStartedState(items));

			context.Handle();

			context.Add(Guid.NewGuid());

			context.Handle();
			context.Handle();
			context.Handle();

			return Ok(context);
		}
	}
}
