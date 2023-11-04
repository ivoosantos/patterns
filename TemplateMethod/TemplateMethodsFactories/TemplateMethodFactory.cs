using Models;
using System.Reflection;
using TemplateMethod.TemplateMethods;
using static Models.OrderModel;

namespace TemplateMethod.TemplateMethodsFactories
{
	public class TemplateMethodFactory : ITemplateMethodFactory
	{
		public WarehouseTemplateMethod GetModel(OrderInputModel inputModel)
		{
			WarehouseTemplateMethod templateMethod;

			if (inputModel.IsExternal)
			{
				templateMethod = new WarehouseExternalService(inputModel);
			}
			else
			{
				templateMethod = new WarehouseInternalService(inputModel);
			}

			return templateMethod;
		}
	}
}
