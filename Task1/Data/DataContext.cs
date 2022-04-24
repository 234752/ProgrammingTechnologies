namespace Data
{
    internal class DataContext
    {
        internal List<Customer> Customers;
        internal List<StorageEntry> StorageState; //diamonds in storage; each object represents single diamond and has to reference a catalog entry
        internal List<Event> Events;    //events that change storageState
        internal Dictionary<int, Diamond> Catalog;  //list of unique diamonds, will be referenced in events and storage

        internal DataContext()
        {
            Customers = new List<Customer>();
            StorageState = new List<StorageEntry>();
            Events = new List<Event>();
            Catalog = new Dictionary<int, Diamond>();
        }
    }
}
