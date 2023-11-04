using Microsoft.AspNetCore.Mvc;
using TemplateMethod.TemplateMethods;
using TemplateMethod.TemplateMethodsFactories;
using static Models.OrderModel;

namespace TemplateMethod.Controllers
{
	[ApiController]
	[Route("api/orders")]
	public class OrdersController : ControllerBase
	{
		[HttpPost("template-method")]
		public IActionResult OrderTemplate(OrderInputModel model)
		{
			//WarehouseTemplateMethod templateMethod;

			//if (model.IsExternal)
			//{
			//	templateMethod = new WarehouseExternalService(model);
			//}
			//else
			//{
			//	templateMethod = new WarehouseInternalService(model);
			//}

			TemplateMethodFactory templateMethod = new TemplateMethodFactory();
			templateMethod
				.GetModel(model)
				.ExtractOrderData();
			templateMethod
				.GetModel(model)
				.SeparateStockQuantities();
			templateMethod
				.GetModel(model)
				.Notify();

			//templateMethod.ExtractOrderData();
			//templateMethod.SeparateStockQuantities();
			//templateMethod.Notify();

			return Ok(templateMethod);
		}
	}
}
