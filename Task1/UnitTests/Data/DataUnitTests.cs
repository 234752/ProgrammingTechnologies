using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.API;

namespace UnitTests.Data
{
    [TestClass]
    public class DataUnitTests
    {
        [TestMethod]
        public void TestEmptyDataLayer()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeCatalog();

            //customers
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 0);
            testedDataLayer.AddCustomer(4, "bob2");
            testedDataLayer.AddCustomer(4, "bob3");
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 2);

            //catalog
            testedDataLayer.AddCatalogEntry(0, 2F, 3898.99F, 1, 1);
            Assert.AreEqual(1, testedDataLayer.GetCatalogSize());
            Assert.IsFalse(testedDataLayer.RemoveCatalogEntry(1));
            Assert.IsTrue(testedDataLayer.RemoveCatalogEntry(0));

            //storage
            testedDataLayer.AddCatalogEntry(0, 2F, 3898.99F, 1, 1);
            testedDataLayer.AddCatalogEntry(1, 2F, 3898.99F, 1, 1);

            testedDataLayer.AddStorageEntry(0);
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(2);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(0), 1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 2);
            Assert.IsTrue(testedDataLayer.RemoveStorageEntry(0));

            //events
            testedDataLayer.AddDeliveryEvent("09/04/2022", 0);
            testedDataLayer.AddDeliveryEvent("11/04/2022", 1);
            testedDataLayer.AddCustomer(0, "Paul");
            testedDataLayer.AddSoldEvent("10/04/2022", 1, 0);
            testedDataLayer.AddSoldEvent("11/04/2022", 2, 0);
            Assert.AreEqual(testedDataLayer.GetEventCount(), 4);
            Assert.AreEqual(testedDataLayer.GetDeliveryCount(1), 2);
            Assert.AreEqual(testedDataLayer.GetSoldCount(1), 1);
            Assert.AreEqual(testedDataLayer.GetSoldCount(2), 1);
            Assert.IsTrue(testedDataLayer.RemoveEvent(1));
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
            testedDataLayer.AddStorageEntry(2);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(0), 1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 2);
            Assert.IsTrue(testedDataLayer.RemoveStorageEntry(0));

            //events
            testedDataLayer.AddDeliveryEvent("09/04/2022", 0);
            testedDataLayer.AddDeliveryEvent("11/04/2022", 1);
            testedDataLayer.AddCustomer(0, "Paul");
            testedDataLayer.AddSoldEvent("10/04/2022", 1, 0);
            testedDataLayer.AddSoldEvent("11/04/2022", 2, 0);
            Assert.AreEqual(testedDataLayer.GetEventCount(), 4);
            Assert.AreEqual(testedDataLayer.GetDeliveryCount(1), 2);
            Assert.AreEqual(testedDataLayer.GetSoldCount(1), 1);
            Assert.AreEqual(testedDataLayer.GetSoldCount(2), 1);
            Assert.IsTrue(testedDataLayer.RemoveEvent(1));
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
            testedDataLayer.AddStorageEntry(2);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(0), 1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 2);
            Assert.IsTrue(testedDataLayer.RemoveStorageEntry(0));

            //events
            testedDataLayer.AddDeliveryEvent("09/04/2022", 0);
            testedDataLayer.AddDeliveryEvent("11/04/2022", 1);
            testedDataLayer.AddCustomer(0, "Paul");
            testedDataLayer.AddSoldEvent("10/04/2022", 1, 0);
            testedDataLayer.AddSoldEvent("11/04/2022", 2, 0);
            Assert.AreEqual(testedDataLayer.GetEventCount(), 4);
            Assert.AreEqual(testedDataLayer.GetDeliveryCount(1), 2);
            Assert.AreEqual(testedDataLayer.GetSoldCount(1), 1);
            Assert.AreEqual(testedDataLayer.GetSoldCount(2), 1);
            Assert.IsTrue(testedDataLayer.RemoveEvent(1));
        }

    }
}