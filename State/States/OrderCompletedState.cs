﻿namespace State.States
{
	public class OrderCompletedState : OrderStateBase, IOrderState
	{
		public OrderCompletedState(List<Guid> items) : base(items)
		{
		}

		public void Add(Guid item)
		{
			throw new InvalidOperationException("Invalid operation...");
		}

		public void Handle()
		{
			Console.WriteLine("No more states.");
		}
	}
}
