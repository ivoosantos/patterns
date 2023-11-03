namespace State
{
	public class Order
	{
		public Order(List<Guid> items)
		{
			Status = OrderStatus.Starterd;
			Items = items;
		}
	}
}
