namespace Visitor.Visitor.Contract
{
	public interface IMarketingMessage
	{
		void Accept(INotificationVisitor visitor);
		string From { get; }
		string To { get; }
		string Content { get; }
	}
}
