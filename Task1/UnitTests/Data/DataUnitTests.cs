using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.API;

namespace UnitTests.Data
{
    [TestClass]
    public class DataUnitTests
    {
        /*
        [TestMethod]
        public void AddRemoveCustomer()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeCatalog();
            testedDataLayer.AddCustomer(0, "Bob");
            testedDataLayer.AddCustomer(123, "Average Diamond Enjoyer");
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 2);
            Assert.IsTrue(testedDataLayer.RemoveCustomer(1));
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 1);
            Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => testedDataLayer.RemoveCustomer(1));
        }

        [TestMethod]
        public void StorageSummary()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeCatalog();
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(2);
            testedDataLayer.AddStorageEntry(2);
            testedDataLayer.AddStorageEntry(3);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(2), 2);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(3), 1);
            Assert.IsTrue(testedDataLayer.RemoveStorageEntry(0));
        }

        [TestMethod]
        public void EventsSummary()
            {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeCatalog();
            testedDataLayer.AddStorageEntry(0);
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(2);
            testedDataLayer.AddStorageEntry(3);
            testedDataLayer.AddDeliveryEvent("09/04/2022", 0);
            testedDataLayer.AddDeliveryEvent("11/04/2022", 1);
            testedDataLayer.AddCustomer(0, "Paul");
            testedDataLayer.AddSoldEvent("10/04/2022", 3, 0);
            testedDataLayer.AddSoldEvent("11/04/2022", 2, 0);
            Assert.AreEqual(testedDataLayer.GetEventCount(), 4);
            Assert.AreEqual(testedDataLayer.GetDeliveryCount(1), 1);
            Assert.AreEqual(testedDataLayer.GetDeliveryCount(3), 0);
            Assert.AreEqual(testedDataLayer.GetSoldCount(3), 1);
            Assert.AreEqual(testedDataLayer.GetSoldCount(0), 0);
            Assert.IsTrue(testedDataLayer.RemoveEvent(1));

        }

        [TestMethod]
        public void CatalogSummary()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeCatalog();
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddCatalogEntry(8,2F,3898.99F,1,1);
            Assert.AreEqual(testedDataLayer.GetCatalogSize(), 8);
            Assert.IsTrue(testedDataLayer.RemoveCatalogEntry(0));
        }

        [TestMethod]
        public void TestEmptyGenerator()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeEmpty();
            testedDataLayer.AddCatalogEntry(0, 2F, 3898.99F, 1, 1);
            Assert.IsFalse(testedDataLayer.RemoveCatalogEntry(1));
            Assert.IsTrue(testedDataLayer.RemoveCatalogEntry(0));
        }

        [TestMethod]
        public void TestCatalogAndCustomerGenerator()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeCatalogAndCustomers();
            Assert.ThrowsException<System.ArgumentException>(() => testedDataLayer.AddCatalogEntry(0, 2F, 3898.99F, 1, 1));
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 3);
            Assert.AreEqual(testedDataLayer.GetCatalogSize(), 7);
            Assert.IsTrue(testedDataLayer.RemoveCatalogEntry(6));
            Assert.AreEqual(testedDataLayer.GetCatalogSize(), 6);
            testedDataLayer.AddCatalogEntry(6, 1F, 2999.99F, 2,3);
            Assert.AreEqual(testedDataLayer.GetCatalogSize(), 7);
        }
        */
        [TestMethod]
        public void TestEmptyDataLayer()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeCatalog();

            //customers
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 0);
            testedDataLayer.AddCustomer(4, "bob2");
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 1);

            //catalog
            testedDataLayer.AddCatalogEntry(0, 2F, 3898.99F, 1, 1);
            Assert.AreEqual(1, testedDataLayer.GetCatalogSize());
            Assert.IsFalse(testedDataLayer.RemoveCatalogEntry(1));
            Assert.IsTrue(testedDataLayer.RemoveCatalogEntry(0));
            testedDataLayer.AddCatalogEntry(0, 2F, 3898.99F, 1, 1);
            testedDataLayer.AddCatalogEntry(1, 2F, 3898.99F, 1, 1);

            //storage
            testedDataLayer.AddStorageEntry(0);
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(0), 1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 3);
            Assert.IsTrue(testedDataLayer.RemoveStorageEntry(0));
        }
        [TestMethod]
        public void TestDataLayerWithCatalogGenerator()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer(new CatalogGenerator());
            testedDataLayer.InitializeCatalog();

            //customers
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 0);
            testedDataLayer.AddCustomer(4, "bob2");
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 1);

            //catalog
            Assert.ThrowsException<System.ArgumentException>(() => testedDataLayer.AddCatalogEntry(0, 2F, 3898.99F, 1, 1));
            Assert.AreEqual(testedDataLayer.GetCatalogSize(), 5);
            Assert.IsTrue(testedDataLayer.RemoveCatalogEntry(1));
            Assert.AreEqual(testedDataLayer.GetCatalogSize(), 4);
            testedDataLayer.AddCatalogEntry(1, 2F, 3898.99F, 1, 1);
            Assert.AreEqual(testedDataLayer.GetCatalogSize(), 5);

            //storage
            testedDataLayer.AddStorageEntry(0);
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(0), 1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 3);
            Assert.IsTrue(testedDataLayer.RemoveStorageEntry(0));
        }
        [TestMethod]
        public void TestCatalogAndCustomerGenerator()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer(new CatalogAndCustomersGenerator());
            testedDataLayer.InitializeCatalog();

            //customers
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 3);
            testedDataLayer.AddCustomer(4, "bob2");
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 4);

            //catalog
            Assert.ThrowsException<System.ArgumentException>(() => testedDataLayer.AddCatalogEntry(0, 2F, 3898.99F, 1, 1));
            Assert.AreEqual(testedDataLayer.GetCatalogSize(), 5);
            Assert.IsTrue(testedDataLayer.RemoveCatalogEntry(1));
            Assert.AreEqual(testedDataLayer.GetCatalogSize(), 4);
            testedDataLayer.AddCatalogEntry(1, 1F, 2999.99F, 2, 3);
            Assert.AreEqual(testedDataLayer.GetCatalogSize(), 5);

            //storage
            testedDataLayer.AddStorageEntry(0);
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(0), 1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 3);
            Assert.IsTrue(testedDataLayer.RemoveStorageEntry(0));
        }

    }
}