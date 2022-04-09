namespace Data
{
    public abstract class DataLayerAbstractAPI
    {
        public abstract void InitializeDataContext();

        public static DataLayerAbstractAPI CreateMyDataLayer()
        {
            return new MyDataLayer();
        }

        public abstract void addCustomer(int id, string name);
        public abstract int getCustomerCount();
        public abstract bool removeCustomer(int id);
        public abstract void addStorageEntry(int catalogNumberOfNewItem);
        public abstract bool removeStorageEntry(int entryIndex);
        public abstract void addDeliveryEvent(string date, int entryIndex);
        public abstract void addSoldEvent(string date, int entryIndex, int customerIndex);
        public abstract bool removeEvent(int eventIndex); //will event history ever be deleted?
        public abstract void addCatalogEntry(int catalogNumber, float carat, float price, int quality, int shape);
        public abstract bool removeCatalogEntry(int catalogEntryIndex);


        private class MyDataLayer : DataLayerAbstractAPI
        {
            public DataContext DataContext { get; set; }
            public override void InitializeDataContext()
            {
                DataContext = new DataContext();
            }
            //CUSTOMER
            public override void addCustomer(int id, string name)
            {
                DataContext._customers.Add(new Customer(id, name));
            }
            public override int getCustomerCount()
            {
                return DataContext._customers.Count;
            }
            public override bool removeCustomer(int customerIndex)
            {
                return DataContext._customers.Remove(DataContext._customers.ElementAt(customerIndex));
            }
            //STORAGE
            public override void addStorageEntry(int catalogNumberOfNewItem)
            {
                DataContext._storageState.Add(new StorageEntry(catalogNumberOfNewItem));
            }
            public override bool removeStorageEntry(int storageEntryIndex)
            {
                return DataContext._storageState.Remove(DataContext._storageState.ElementAt(storageEntryIndex));
            }
            //EVENTS
            public override void addDeliveryEvent(string date, int entryIndex)
            {
                DataContext._events.Add(new EventDiamondDelivery(date, DataContext._storageState.ElementAt(entryIndex)));
            }
            public override void addSoldEvent(string date, int entryIndex, int customerIndex)
            {
                DataContext._events.Add(new EventDiamondSold(date, DataContext._storageState.ElementAt(entryIndex), DataContext._customers.ElementAt(customerIndex)));
            }
            public override bool removeEvent(int eventIndex)
            {
                return DataContext._events.Remove(DataContext._events.ElementAt(eventIndex));
            }
            //CATALOG
            public override void addCatalogEntry(int catalogNumber, float carat, float price, int quality, int shape)
            {
                DataContext._catalog.Add(catalogNumber, new Diamond(carat, price, (QualityValue)quality, (ShapeValue)shape));
            }
            public override bool removeCatalogEntry(int catalogEntryIndex)
            {
                return DataContext._storageState.Remove(DataContext._storageState.ElementAt(catalogEntryIndex));
            }

        }
    }
}