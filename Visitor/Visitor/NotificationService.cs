using Visitor.Visitor.Contract;

namespace Visitor.Visitor
{
	public class NotificationService
	{
		public void Notify(List<IMarketingMessage> messages)
		{
			var visitor = new NotificationVisitor();

			foreach (var message in messages)
			{
				message.Accept(visitor);
			}
		}
	}
}
