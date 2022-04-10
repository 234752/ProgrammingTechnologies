using System.Linq;

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
        public abstract void AddCustomer(int id, string name);
        public abstract int GetCustomerCount();
        public abstract bool RemoveCustomer(int id);
        //STORAGE
        public abstract void AddStorageEntry(int catalogNumberOfNewItem);
        public abstract int GetAmountOfCatalogItem(int catalogNumberOfItem);
        public abstract int GetAmountOfAllItems();
        public abstract bool RemoveStorageEntry(int entryIndex);
        public abstract int GetStorageIndexOfCatalogItem(int catalogNumberOfDesiredItem);
        //EVENTS
        public abstract void AddDeliveryEvent(string date, int entryIndex);
        public abstract void AddSoldEvent(string date, int entryIndex, int customerIndex);
        public abstract bool RemoveEvent(int eventIndex); //will event history ever be deleted?
        public abstract int GetEventCount();
        public abstract int GetDeliveryCount(int catalogNumberOfItem);
        public abstract int GetSoldCount(int catalogNumberOfItem);
        //CATALOG
        public abstract void AddCatalogEntry(int catalogNumber, float carat, float price, int quality, int shape);
        public abstract bool RemoveCatalogEntry(int catalogEntryIndex);
        public abstract void GetDiamondPrice(int catalogNumber);

        private class MyDataLayer : DataLayerAbstractAPI
        {
            public DataContext DataContext { get; set; }
            public override void InitializeDataContext()
            {
                DataContext = new DataContext();
                DataContext.InitializeCatalog();
            }
            //CUSTOMER
            public override void AddCustomer(int id, string name)
            {
                DataContext.Customers.Add(new Customer(id, name));
            }
            public override int GetCustomerCount()
            {
                return DataContext.Customers.Count;
            }
            public override bool RemoveCustomer(int customerIndex)
            {
                return DataContext.Customers.Remove(DataContext.Customers.ElementAt(customerIndex));
            }
            //STORAGE
            public override void AddStorageEntry(int catalogNumberOfNewItem)
            {
                DataContext.StorageState.Add(new StorageEntry(catalogNumberOfNewItem));
            }
            public override int GetAmountOfCatalogItem(int catalogNumberOfItem)
            {
                return DataContext.StorageState.Count(entry => entry.GetCatalogNumber() == catalogNumberOfItem);
            }
            public override int GetAmountOfAllItems()
            {
                return DataContext.StorageState.Count();
            }
            public override bool RemoveStorageEntry(int storageEntryIndex)
            {
                return DataContext.StorageState.Remove(DataContext.StorageState.ElementAt(storageEntryIndex));
            }
            public override int GetStorageIndexOfCatalogItem(int catalogNumberOfDesiredItem)
            {
                return DataContext.StorageState.IndexOf(DataContext.StorageState.Last(entry => entry.GetCatalogNumber() == catalogNumberOfDesiredItem));
            }
            //EVENTS
            public override void AddDeliveryEvent(string date, int entryIndex)
            {
                DataContext.Events.Add(new EventDiamondDelivery(date, DataContext.StorageState.ElementAt(entryIndex)));
            }
            public override void AddSoldEvent(string date, int entryIndex, int customerIndex)
            {
                DataContext.Events.Add(new EventDiamondSold(date, DataContext.StorageState.ElementAt(entryIndex), DataContext.Customers.ElementAt(customerIndex)));
            }
            public override bool RemoveEvent(int eventIndex)
            {
                return DataContext.Events.Remove(DataContext.Events.ElementAt(eventIndex));
            }
            public override int GetEventCount()
            {
                return DataContext.Events.Count;
            }
            public override int GetDeliveryCount(int catalogNumberOfItem)
            {
                return DataContext.Events.Count(ev => ev.GetEventType()=="Delivery" && ev.GetCatalogNumberOfEntry()==catalogNumberOfItem);
            }
            public override int GetSoldCount(int catalogNumberOfItem)
            {
                return DataContext.Events.Count(ev => ev.GetEventType() == "Sold" && ev.GetCatalogNumberOfEntry() == catalogNumberOfItem);
            }
            //CATALOG
            public override void AddCatalogEntry(int catalogNumber, float carat, float price, int quality, int shape)
            {
                DataContext.Catalog.Add(catalogNumber, new Diamond(carat, price, (QualityValue)quality, (ShapeValue)shape));
            }
            public override bool RemoveCatalogEntry(int catalogEntryIndex)
            {
                return DataContext.StorageState.Remove(DataContext.StorageState.ElementAt(catalogEntryIndex));
            }
            public override void GetDiamondPrice(int catalogNumber)
            {
                
            }
        }
    }
}