using static Models.OrderModel;

namespace Strategy.Strategies
{
	public interface IPaymentContext
	{
		object Process(OrderInputModel model);
		IPaymentContext SetStrategy(IPaymentStrategy strategy);
	}
}
