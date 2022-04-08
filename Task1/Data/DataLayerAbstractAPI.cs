namespace Data
{
    public abstract class DataLayerAbstractAPI
    {
        public abstract void InitializeDataContext();

        public static DataLayerAbstractAPI CreateMyDataLayer()
        {
            return new MyDataLayer();
        }

        public abstract void addCustomer(Customer customer);
        public abstract void addStorageEntry(StorageEntry storageEntry);
        public abstract void addEvent(Event addedEvent);
        public abstract void addCatalogEntry(int catalogNumber, Diamond diamond);


        private class MyDataLayer : DataLayerAbstractAPI
        {
            public override void addCatalogEntry(int catalogNumber, Diamond diamond)
            {
                throw new NotImplementedException();
            }

            public override void addCustomer(Customer customer)
            {
                throw new NotImplementedException();
            }

            public override void addEvent(Event addedEvent)
            {
                throw new NotImplementedException();
            }

            public override void addStorageEntry(StorageEntry storageEntry)
            {
                throw new NotImplementedException();
            }

            public override void InitializeDataContext()
            {
                DataContext myData = new DataContext();
            }

        }
    }
}