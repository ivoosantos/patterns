using Models;

namespace Strategy.Strategies
{
	public class PaymentSlipStrategy : IPaymentStrategy
	{
		public object Process(OrderModel.OrderInputModel model)
		{
			return "Dados do Boleto: xyz...";
		}
	}
}
