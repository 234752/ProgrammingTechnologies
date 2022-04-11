using Data;

namespace UnitTests
{
    internal class FixtureDataLayerForTesting : DataLayerAbstractAPI
    {
        internal int AddCatalogEntryC;
        internal int AddCustomerC;
        internal int AddDeliveryEventC;
        internal int AddSoldEventC;
        internal int AddStorageEntryC;
        internal int GetAmountOfAllItemsC;
        internal int GetAmountOfCatalogItemC;
        internal int GetCustomerCountC;
        internal int GetDeliveryCountC;
        internal int GetEventCountC;
        internal int GetSoldCountC;
        internal int InitializeDataContextC;
        internal int RemoveCatalogEntryC;
        internal int RemoveCustomerC;
        internal int RemoveEventC;
        internal int RemoveStorageEntryC;
        internal int GetStorageIndexOfCatalogItemC;
        internal int GetDiamondInfoC;

        public override void AddCatalogEntry(int catalogNumber, float carat, float price, int quality, int shape)
        {
            AddCatalogEntryC++;
        }

        public override void AddCustomer(int id, string name)
        {
            AddCustomerC++;
        }

        public override void AddDeliveryEvent(string date, int entryIndex)
        {
            AddDeliveryEventC++;
        }

        public override void AddSoldEvent(string date, int entryIndex, int customerIndex)
        {
            AddSoldEventC++;
        }

        public override void AddStorageEntry(int catalogNumberOfNewItem)
        {
            AddStorageEntryC++;
        }

        public override int GetAmountOfAllItems()
        {
            GetAmountOfAllItemsC++;
            return 1;
        }

        public override int GetAmountOfCatalogItem(int catalogNumberOfItem)
        {
            GetAmountOfCatalogItemC++;
            return 1;
        }

        public override int GetCustomerCount()
        {
            GetCustomerCountC++;
            return 1;
        }

        public override int GetDeliveryCount(int catalogNumberOfItem)
        {
            GetDeliveryCountC++;
            return 1;
        }

        public override string GetDiamondInfo(int catalogNumber)
        {
            GetDiamondInfoC++;
            return "1";
        }

        public override int GetEventCount()
        {
            GetEventCountC++;
            return 1;
        }

        public override int GetSoldCount(int catalogNumberOfItem)
        {
            GetSoldCountC++;
            return 1;
        }

        public override int GetStorageIndexOfCatalogItem(int catalogNumberOfDesiredItem)
        {
            GetStorageIndexOfCatalogItemC++;
            return 1;
        }

        public override void InitializeDataContext()
        {
            InitializeDataContextC++;
        }

        public override bool RemoveCatalogEntry(int catalogEntryIndex)
        {
            RemoveCatalogEntryC++;
            return true;
        }

        public override bool RemoveCustomer(int id)
        {
            RemoveCustomerC++;
            return true;
        }

        public override bool RemoveEvent(int eventIndex)
        {
            RemoveEventC++;
            return true;
        }

        public override bool RemoveStorageEntry(int entryIndex)
        {
            RemoveStorageEntryC++;
            return true;
        }
    }
}
