namespace Data
{
    public abstract class DataLayerAbstractAPI
    {
        public abstract void InitializeDataContext();

        public static DataLayerAbstractAPI CreateMyDataLayer()
        {
            return new MyDataLayer();
        }
        //CUSTOMER
        public abstract void addCustomer(int id, string name);
        public abstract int getCustomerCount();
        public abstract bool removeCustomer(int id);
        //STORAGE
        public abstract void addStorageEntry(int catalogNumberOfNewItem);
        public abstract bool removeStorageEntry(int entryIndex);
        //EVENTS
        public abstract void addDeliveryEvent(string date, int entryIndex);
        public abstract void addSoldEvent(string date, int entryIndex, int customerIndex);
        public abstract bool removeEvent(int eventIndex); //will event history ever be deleted?
        //CATALOG
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
                DataContext.Customers.Add(new Customer(id, name));
            }
            public override int getCustomerCount()
            {
                return DataContext.Customers.Count;
            }
            public override bool removeCustomer(int customerIndex)
            {
                return DataContext.Customers.Remove(DataContext.Customers.ElementAt(customerIndex));
            }
            //STORAGE
            public override void addStorageEntry(int catalogNumberOfNewItem)
            {
                DataContext.StorageState.Add(new StorageEntry(catalogNumberOfNewItem));
            }
            public override bool removeStorageEntry(int storageEntryIndex)
            {
                return DataContext.StorageState.Remove(DataContext.StorageState.ElementAt(storageEntryIndex));
            }
            //EVENTS
            public override void addDeliveryEvent(string date, int entryIndex)
            {
                DataContext.Events.Add(new EventDiamondDelivery(date, DataContext.StorageState.ElementAt(entryIndex)));
            }
            public override void addSoldEvent(string date, int entryIndex, int customerIndex)
            {
                DataContext.Events.Add(new EventDiamondSold(date, DataContext.StorageState.ElementAt(entryIndex), DataContext.Customers.ElementAt(customerIndex)));
            }
            public override bool removeEvent(int eventIndex)
            {
                return DataContext.Events.Remove(DataContext.Events.ElementAt(eventIndex));
            }
            //CATALOG
            public override void addCatalogEntry(int catalogNumber, float carat, float price, int quality, int shape)
            {
                DataContext.Catalog.Add(catalogNumber, new Diamond(carat, price, (QualityValue)quality, (ShapeValue)shape));
            }
            public override bool removeCatalogEntry(int catalogEntryIndex)
            {
                return DataContext.StorageState.Remove(DataContext.StorageState.ElementAt(catalogEntryIndex));
            }

        }
    }
}