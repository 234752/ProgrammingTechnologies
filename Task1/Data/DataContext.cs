namespace Data
{
    internal class DataContext
    {
        internal List<Customer> _customers;
        internal List<StorageEntry> _storageState; //diamonds in storage; each object represents single diamond and has to reference a catalog entry
        internal List<Event> _events;    //events that change storageState
        internal Dictionary<int, Diamond> _catalog;  //list of unique diamonds, will be referenced in events and storage

        internal DataContext()
        {
            _customers = new List<Customer>();
            _storageState = new List<StorageEntry>();
            _events = new List<Event>();
            _catalog = new Dictionary<int, Diamond>();
        }
        internal void InitializeCatalog() //possible DI, with empty or full initializer
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
    }
}
