using static Models.OrderModel;

namespace Strategy.Strategies
{
	public class CreditCardStrategy : IPaymentStrategy
	{
		public object Process(OrderInputModel model)
		{
			return "Transação aprovada!";
		}
	}
}
