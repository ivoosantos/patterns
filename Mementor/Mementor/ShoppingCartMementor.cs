namespace Mementor.Mementor
{
    public interface IShoppingCartMemento
    {
        Guid CustomerId { get; }
        List<KeyValuePair<Guid, int>> Items { get; }
        DateTime SaveAt { get; }
    }
    public class ShoppingCartMemento : IShoppingCartMemento
    {
        public ShoppingCartMemento(Guid customerId, List<KeyValuePair<Guid, int>> items)
        {
            CustomerId = customerId;
            Items = items;
            SaveAt = DateTime.Now;
        }
        public Guid CustomerId { get; private set; }

        public List<KeyValuePair<Guid, int>> Items { get; private set; }

        public DateTime SaveAt {
            get; private set;
        }
    }
}
