using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;


namespace UnitTests
{
    [TestClass]
    public class LogicUnitTests
    {
        [TestMethod]
        public void TestDelivery()
        {
            FixtureDataLayerForTesting fakeDataLayer = new FixtureDataLayerForTesting();
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer(fakeDataLayer);
            testedLogicLayer.RegisterDelivery("12-12-2020", 1, 3);
            Assert.AreEqual(fakeDataLayer.AddStorageEntryC, 3);
            Assert.AreEqual(fakeDataLayer.AddDeliveryEventC, 3);
        }

        [TestMethod]
        public void TestPurchase()
        {
            FixtureDataLayerForTesting fakeDataLayer = new FixtureDataLayerForTesting();
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer(fakeDataLayer);
            testedLogicLayer.RegisterSale("12-12-2020", 2, 0);
            Assert.AreEqual(fakeDataLayer.RemoveStorageEntryC, 1);
            Assert.AreEqual(fakeDataLayer.AddSoldEventC, 1);
        }
    }
}
