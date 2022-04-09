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
        public abstract void addDeliveryEvent(string date, int entryIndex);
        public abstract void addSoldEvent(string date, int entryIndex, int customerIndex);
        public abstract void addCatalogEntry(int catalogNumber, float carat, float price, int quality, int shape);


        private class MyDataLayer : DataLayerAbstractAPI
        {
            public DataContext DataContext { get; set; }
            public override void InitializeDataContext()
            {
                DataContext = new DataContext();
            }
            public override void addCustomer(int id, string name)
            {
                DataContext.addCustomer(id, name);
            }
            public override int getCustomerCount()
            {
                return DataContext.getCustomerCount();
            }
            public override bool removeCustomer(int customerIndex)
            {
                return DataContext.removeCustomer(customerIndex);
            }
            public override void addStorageEntry(int catalogNumberOfNewItem)
            {
                DataContext.addStorageEntry(catalogNumberOfNewItem);
            }
            public override void addDeliveryEvent(string date, int entryIndex)
            {
                DataContext.addDeliveryEvent(date, entryIndex);
            }
            public override void addSoldEvent(string date, int entryIndex, int customerIndex)
            {
                DataContext.addSoldEvent(date, entryIndex, customerIndex);
            }
            public override void addCatalogEntry(int catalogNumber, float carat, float price, int quality, int shape)
            {
                DataContext.addCatalogEntry(catalogNumber, carat, price, quality, shape);
            }

        }
    }
}