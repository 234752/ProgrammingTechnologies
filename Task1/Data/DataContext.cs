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
        internal void InitializeCatalog() //possible DI, with empty or full initializer
        {
            Diamond first = new Diamond(1F, 2999.99F, QualityValue.Good, ShapeValue.Oval);
            Diamond second = new Diamond(1F, 3999.99F, QualityValue.Good, ShapeValue.Round);
            Diamond third = new Diamond(2F, 4999.99F, QualityValue.VeryGood, ShapeValue.Pear);
            Diamond fourth = new Diamond(2F, 6999.99F, QualityValue.Excellent, ShapeValue.Cushion);
            Diamond fifth = new Diamond(3F, 1999.99F, QualityValue.Good, ShapeValue.Oval);
            Diamond sixth = new Diamond(3F, 5999.99F, QualityValue.VeryGood, ShapeValue.Pear);
            Diamond seventh = new Diamond(4F, 7999.99F, QualityValue.Excellent, ShapeValue.Cushion);
            Catalog.Add(1, first);
            Catalog.Add(2, second);
            Catalog.Add(3, third);
            Catalog.Add(4, fourth);
            Catalog.Add(5, fifth);
            Catalog.Add(6, sixth);
            Catalog.Add(7, seventh);
        }

        // returns value if exists
        public string GetDiamond (int key) => Catalog[key].ToString();
            

    }
}
