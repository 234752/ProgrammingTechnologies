using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace UnitTests
{
    [TestClass]
    public class DataUnitTests
    {
        [TestMethod]
        public void AddRemoveCustomer()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeDataContext();
            testedDataLayer.AddCustomer(0, "Bob");
            testedDataLayer.AddCustomer(123, "Average Diamond Enjoyer");
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 2);
            Assert.IsTrue(testedDataLayer.RemoveCustomer(1));
            Assert.AreEqual(testedDataLayer.GetCustomerCount(), 1);
            try
            {
                testedDataLayer.RemoveCustomer(1);
                Assert.Fail("Exception was expected");
            }
            catch (System.Exception ex) { }

        }

        [TestMethod]
        public void StorageSummary()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeDataContext();
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(2);
            testedDataLayer.AddStorageEntry(2);
            testedDataLayer.AddStorageEntry(3);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(2), 2);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(3), 1);
        }

        [TestMethod]
        public void EventsSummary()
            {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeDataContext();
            testedDataLayer.AddStorageEntry(0);
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddStorageEntry(2);
            testedDataLayer.AddStorageEntry(3);
            testedDataLayer.AddDeliveryEvent("09.04.22", 0);
            testedDataLayer.AddDeliveryEvent("11.04.22", 1);
            testedDataLayer.AddCustomer(0, "Paul");
            testedDataLayer.AddSoldEvent("10.04.22", 3, 0);
            testedDataLayer.AddSoldEvent("11.04.22", 2, 0);
            //testedDataLayer.RemoveEvent(1);
            Assert.AreEqual(testedDataLayer.GetEventCount(), 4);
            //Assert.AreEqual(testedDataLayer.GetDeliveryCount(1), 1);
            Assert.AreEqual(testedDataLayer.GetDeliveryCount(3), 0);
            //Assert.AreEqual(testedDataLayer.GetSoldCount(3), 1);
            Assert.AreEqual(testedDataLayer.GetSoldCount(0), 0);

        }

        [TestMethod]
        public void CatalogSummary()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeDataContext();
            testedDataLayer.AddStorageEntry(1);
            testedDataLayer.AddCatalogEntry(8,2F,3898.99F,1,1);
            Assert.IsTrue(testedDataLayer.RemoveCatalogEntry(0));

        }


    }
}