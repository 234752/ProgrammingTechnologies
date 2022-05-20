namespace Data
{
    internal abstract class Event
    {
        public int Id;
        public string Date;
        public bool IsDelivery;
        public int CatalogId;
        internal abstract string GetEventType();
        internal int GetCatalogNumberOfEntry()
        {
            return Entry.GetCatalogNumber();
        }

    }
}