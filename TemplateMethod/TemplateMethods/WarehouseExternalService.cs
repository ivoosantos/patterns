﻿using static Models.OrderModel;

namespace TemplateMethod.TemplateMethods
{
	public class WarehouseExternalService : WarehouseTemplateMethod
	{
		public WarehouseExternalService(OrderInputModel model) : base(model)
		{
		}

		public override void Notify()
		{
			Console.WriteLine("Notifying other components through REST APIs");
		}

		public override void SeparateStockQuantities()
		{
			Console.WriteLine("Separating external stock quantities.");
		}
	}
}
