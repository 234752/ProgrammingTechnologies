using Data;

namespace UnitTests
{
    internal class FixtureDataLayerForTesting : DataLayerAbstractAPI
    {
        public override void AddCatalogEntry(int catalogNumber, float carat, float price, int quality, int shape)
        {
            throw new System.NotImplementedException();
        }

        public override void AddCustomer(int id, string name)
        {
            throw new System.NotImplementedException();
        }

        public override void AddDeliveryEvent(string date, int entryIndex)
        {
            throw new System.NotImplementedException();
        }

        public override void AddSoldEvent(string date, int entryIndex, int customerIndex)
        {
            throw new System.NotImplementedException();
        }

        public override void AddStorageEntry(int catalogNumberOfNewItem)
        {
            throw new System.NotImplementedException();
        }

        public override int GetAmountOfAllItems()
        {
            throw new System.NotImplementedException();
        }

        public override int GetAmountOfCatalogItem(int catalogNumberOfItem)
        {
            throw new System.NotImplementedException();
        }

        public override int GetCustomerCount()
        {
            throw new System.NotImplementedException();
        }

        public override int GetDeliveryCount(int catalogNumberOfItem)
        {
            throw new System.NotImplementedException();
        }

        public override int GetEventCount()
        {
            throw new System.NotImplementedException();
        }

        public override int GetSoldCount(int catalogNumberOfItem)
        {
            throw new System.NotImplementedException();
        }

        public override void InitializeDataContext()
        {
            throw new System.NotImplementedException();
        }

        public override bool RemoveCatalogEntry(int catalogEntryIndex)
        {
            throw new System.NotImplementedException();
        }

        public override bool RemoveCustomer(int id)
        {
            throw new System.NotImplementedException();
        }

        public override bool RemoveEvent(int eventIndex)
        {
            throw new System.NotImplementedException();
        }

        public override bool RemoveStorageEntry(int entryIndex)
        {
            throw new System.NotImplementedException();
        }
    }
}
