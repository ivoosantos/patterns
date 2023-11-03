namespace Observer.Observer
{
    public class MarketingCampaignObserver : IDealsObserver
    {
        public void Update(IDealsSubject subject)
        {
            Console.WriteLine("Sending an email to subscribed users.");
        }
    }
}
