using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.API;


namespace UnitTests.Logic
{
    [TestClass]
    public class LogicUnitTests
    {
        [TestMethod]
        public void TestDelivery()
        {
            MockedDataLayerForTesting fakeDataLayer = new MockedDataLayerForTesting();
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer(fakeDataLayer);
            testedLogicLayer.RegisterDelivery("12/12/2020", 1, 3);
            Assert.AreEqual(fakeDataLayer.AddStorageEntryC, 3);
            Assert.AreEqual(fakeDataLayer.AddDeliveryEventC, 3);
        }

        [TestMethod]
        public void TestPurchase()
        {
            MockedDataLayerForTesting fakeDataLayer = new MockedDataLayerForTesting();
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer(fakeDataLayer);
            testedLogicLayer.RegisterSale("12/12/2020", 2, 0);
            Assert.AreEqual(fakeDataLayer.RemoveStorageEntryC, 1);
            Assert.AreEqual(fakeDataLayer.AddSoldEventC, 1);
        }
        
        [TestMethod]
        public void TestRevenue()
        {
            MockedDataLayerForTesting fakeDataLayer = new MockedDataLayerForTesting();
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer(fakeDataLayer);
            testedLogicLayer.RegisterDelivery("12/12/2020", 0, 3);

            testedLogicLayer.AddCustomer(0, "BOB");
            Assert.IsTrue(testedLogicLayer.RegisterSale("12/12/2020", 0, 0));
            testedLogicLayer.RegisterSale("12/12/2020", 0, 0);
            testedLogicLayer.RegisterSale("12/12/2020", 0, 0);
            Assert.AreEqual(testedLogicLayer.CountRevenueFromSales(), 7);
            Assert.AreEqual(fakeDataLayer.GetPriceOfCatalogItemC, 7);
            Assert.AreEqual(fakeDataLayer.GetSoldCountC, 7);
        }

        [TestMethod]
        public void TestRemoveAddCustomer()
        {
            MockedDataLayerForTesting fakeDataLayer = new MockedDataLayerForTesting();
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer(fakeDataLayer);
            testedLogicLayer.RegisterDelivery("12/12/2020", 0, 3);

            testedLogicLayer.AddCustomer(0, "BOB");
            testedLogicLayer.AddCustomer(1, "BOB2");
            Assert.IsFalse(testedLogicLayer.RemoveCustomer(3));
            Assert.IsTrue(testedLogicLayer.RemoveCustomer(1));
        }
    }
}
