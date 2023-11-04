﻿using Visitor.Visitor.Contract;

namespace Visitor.Visitor
{
	public class NotificationVisitor : INotificationVisitor
	{
		public void Visit(SmsMessage message)
		{
			Console.WriteLine("Sms Message!");
		}

		public void Visit(EmailMessage message)
		{
			Console.WriteLine("Email Message!");
		}
	}
}
