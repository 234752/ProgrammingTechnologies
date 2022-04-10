namespace Data
{
    internal class EventDiamondSold : Event
    {
        private Customer _customer; 

        internal EventDiamondSold(string date, StorageEntry entry, Customer customer)
        {
            DateTime = date;
            Entry = entry;
            _customer = customer;
        }
        internal override string GetEventType()
        {
            return "sold";
        }
    }
}
