namespace Data
{
    internal class EventDiamondDelivery : Event
    {
        internal EventDiamondDelivery(string date, StorageEntry entry)
        {
            Date = date;
            Entry = entry;
        }
        internal override string GetEventType()
        {
            return "Delivery";
        }
    }
}
