namespace Data
{
    internal class EventDiamondDelivery : Event
    {
        internal EventDiamondDelivery(string date, StorageEntry entry)
        {
            DateTime = date;
            Entry = entry;
        }
    }
}
