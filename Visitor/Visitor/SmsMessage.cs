﻿using Visitor.Visitor.Contract;

namespace Visitor.Visitor
{
	public class SmsMessage : IMarketingMessage
	{
		public SmsMessage(string from, string to, string content)
		{
			From = from;
			To = to;
			Content = content;
		}

		public string From { get; private set; }

		public string To { get; private set; }

		public string Content { get; private set; }

		public void Accept(INotificationVisitor visitor)
		{
			visitor.Visit(this);
		}
	}
}
