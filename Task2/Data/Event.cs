namespace Data
{
    internal abstract class Event
    {
        protected string Date;
        protected StorageEntry Entry;
        internal abstract string GetEventType();
        internal int GetCatalogNumberOfEntry()
        {
            return Entry.GetCatalogNumber();
        }

    }
}