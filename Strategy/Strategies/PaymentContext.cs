using Models;
using static Models.OrderModel;

namespace Strategy.Strategies
{
	public class PaymentContext : IPaymentContext
	{
		private IPaymentStrategy _strategy;
		public object Process(OrderInputModel model)
		{
			var result = _strategy.Process(model);

			return result;
		}

		public IPaymentContext SetStrategy(IPaymentStrategy strategy)
		{
			_strategy = strategy;

			return this;
		}
	}
}
