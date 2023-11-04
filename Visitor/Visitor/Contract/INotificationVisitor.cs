namespace Visitor.Visitor.Contract
{
    public interface INotificationVisitor
    {
        void Visit(SmsMessage message);
        void Visit(EmailMessage message);
    }
}
