using Microsoft.AspNetCore.Mvc;
using Strategy.Strategies;
using static Models.OrderModel;

namespace Strategy.Controllers
{
	[ApiController]
	[Route("api/orders")]
	public class OrdersController : ControllerBase
	{
		[HttpPost("payment-using-strategy")]
		public IActionResult ProcessPaymentWithStrategy(OrderInputModel model, [FromServices] IPaymentContext context, [FromServices] IPaymentStrategyFactory factory)
		{
			IPaymentStrategy strategy = factory.GetStrategy(model.PaymentInfo.PaymentMethod);

			var result = context
				.SetStrategy(strategy)
				.Process(model);

			return Ok(result);
		}
	}
}
