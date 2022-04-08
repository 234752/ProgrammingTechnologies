namespace Data
{
    internal class DataContext
    {
        private List<Customer> _customers;
        private List<StorageEntry> _storageState; //diamonds in storage; each object represents single diamond and has to reference a catalog entry
        private List<Event> _events;    //events that change storageState
        private Dictionary<int, Diamond> _catalog;  //list of unique diamonds, will be referenced in events and storage

        internal DataContext()
        {
            _customers = new List<Customer>();
            _storageState = new List<StorageEntry>();
            _events = new List<Event>();
            _catalog = new Dictionary<int, Diamond>();
        }
        internal void InitializeCatalog()
        {
            Diamond first = new Diamond(1F, 2999.99F, QualityValue.Good, ShapeValue.Oval);
            Diamond second = new Diamond(1F, 3999.99F, QualityValue.Good, ShapeValue.Round);
            Diamond third = new Diamond(2F, 4999.99F, QualityValue.VeryGood, ShapeValue.Pear);
            Diamond fourth = new Diamond(2F, 6999.99F, QualityValue.Excellent, ShapeValue.Cushion);
            Diamond fifth = new Diamond(3F, 1999.99F, QualityValue.Good, ShapeValue.Oval);
            Diamond sixth = new Diamond(3F, 5999.99F, QualityValue.VeryGood, ShapeValue.Pear);
            Diamond seventh = new Diamond(4F, 7999.99F, QualityValue.Excellent, ShapeValue.Cushion);
            _catalog.Add(1, first);
            _catalog.Add(2, second);
            _catalog.Add(3, third);
            _catalog.Add(4, fourth);
            _catalog.Add(5, fifth);
            _catalog.Add(6, sixth);
            _catalog.Add(7, seventh);
        }
        internal void addCustomer(int id, string name)
        {
            _customers.Add(new Customer(id, name));
        }
        internal void addStorageEntry(int catalogNumberOfNewItem)
        {
            _storageState.Add(new StorageEntry(catalogNumberOfNewItem));
        }
        internal void addDeliveryEvent(string date, int entryIndex)
        {
            _events.Add(new EventDiamondDelivery(date, _storageState.ElementAt(entryIndex)));
        }
        internal void addSoldEvent(string date, int entryIndex, int customerIndex)
        {
            _events.Add(new EventDiamondSold(date, _storageState.ElementAt(entryIndex), _customers.ElementAt(customerIndex)));
        }
        internal void addCatalogEntry(int catalogNumber, float carat, float price, int quality, int shape)
        {
            _catalog.Add(catalogNumber, new Diamond(carat, price, (QualityValue)quality, (ShapeValue)shape));
        }
        internal bool removeCustomer(int customerIndex)
        {
            return _customers.Remove(_customers.ElementAt(customerIndex));
        }
        internal bool removeStorageEntry(int storageEntryIndex)
        {
            return _storageState.Remove(_storageState.ElementAt(storageEntryIndex));
        }
        internal bool removeEvent(int eventIndex)
        {
            return _events.Remove(_events.ElementAt(eventIndex));
        }
        internal bool removeCatalogEntry(int entryIndex)
        {
            return _storageState.Remove(_storageState.ElementAt(entryIndex));
        }
    }
}
