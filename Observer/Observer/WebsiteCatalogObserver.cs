namespace Observer.Observer
{
    public class WebsiteCatalogObserver : IDealsObserver
    {
        public void Update(IDealsSubject subject)
        {
            Console.WriteLine("Updating website catalog design.");
        }
    }
}
