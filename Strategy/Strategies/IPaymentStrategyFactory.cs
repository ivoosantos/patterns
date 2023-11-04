using Models.Enums;

namespace Strategy.Strategies
{
	public interface IPaymentStrategyFactory
	{
		IPaymentStrategy GetStrategy(PaymentMethod paymentMethod);
	}
}
