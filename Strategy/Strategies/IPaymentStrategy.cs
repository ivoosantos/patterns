using static Models.OrderModel;

namespace Strategy.Strategies
{
	public interface IPaymentStrategy
	{
		object Process(OrderInputModel model);
	}
}
