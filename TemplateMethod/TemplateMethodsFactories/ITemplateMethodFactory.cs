using TemplateMethod.TemplateMethods;
using static Models.OrderModel;

namespace TemplateMethod.TemplateMethodsFactories
{
	public interface ITemplateMethodFactory
	{
		WarehouseTemplateMethod GetModel(OrderInputModel inputModel);
	}
}
