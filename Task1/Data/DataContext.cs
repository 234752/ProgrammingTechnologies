namespace Data
{
    internal class DataContext
    {
        private List<Customer> _customers;
        private List<StorageState> _storageState; //diamonds in storage; each object represents single diamond and has to reference a catalog entry
        private List<Event> _events;    //events that change storageState
        private Dictionary<int, Diamond> _catalog;  //list of unique diamonds, will be referenced in events and storage
    }
}
