using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace UnitTests
{
    [TestClass]
    public class TestData
    {
        [TestMethod]
        public void AddRemoveCustomer()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeDataContext();
            testedDataLayer.addCustomer(0, "Bob");
            testedDataLayer.addCustomer(123, "Average Diamond Enjoyer");
            Assert.AreEqual(testedDataLayer.getCustomerCount(), 2);
            Assert.IsTrue(testedDataLayer.removeCustomer(1));
            Assert.AreEqual(testedDataLayer.getCustomerCount(), 1);
            try
            {
                testedDataLayer.removeCustomer(1);
                Assert.Fail("Exception was expected");
            }
            catch (System.Exception ex) { }

        }

        [TestMethod]
        public void StorageSummary()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeDataContext();
            testedDataLayer.addStorageEntry(1);
            testedDataLayer.addStorageEntry(2);
            testedDataLayer.addStorageEntry(2);
            testedDataLayer.addStorageEntry(3);
            Assert.AreEqual(testedDataLayer.getAmountOfCatalogItem(1), 1);
            Assert.AreEqual(testedDataLayer.getAmountOfCatalogItem(2), 2);
            Assert.AreEqual(testedDataLayer.getAmountOfCatalogItem(3), 1);
        }

        [TestMethod]
        public void EventsSummary()
            {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeDataContext();
            testedDataLayer.addStorageEntry(1);
            testedDataLayer.addDeliveryEvent("09.04.22", 0);
            testedDataLayer.addCustomer(0, "Paul");
            testedDataLayer.addSoldEvent("10.04.22",0,0);
            testedDataLayer.addDeliveryEvent("11.04.22", 0);
            testedDataLayer.addSoldEvent("11.04.22", 0, 0);
            testedDataLayer.removeEvent(1);
            Assert.AreEqual(testedDataLayer.getEventCount(), 3);

        }

        [TestMethod]
        public void CatalogSummary()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeDataContext();
            testedDataLayer.addStorageEntry(1);
            //testedDataLayer.addCatalogEntry(1,2F,3898.99F,1,1);
            //testedDataLayer.removeCatalogEntry(1);

    }


    }
}