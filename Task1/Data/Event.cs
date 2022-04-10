namespace Data
{
    internal abstract class Event //this class must be abstract
    {
        protected string DateTime;
        protected StorageEntry Entry;
        internal abstract string GetEventType();
        internal int GetCatalogNumberOfEntry()
        {
            return Entry.GetCatalogNumber();
        }

    }
}