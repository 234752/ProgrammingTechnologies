using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class IntegrationTests
    {
        [TestMethod]
        public void TestDeliveryAndSale()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeCatalog();
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer(testedDataLayer);
            testedLogicLayer.RegisterDelivery("12/12/2020", 1, 3);
            testedLogicLayer.RegisterDelivery("13/12/2020", 3, 2);
            Assert.AreEqual(testedDataLayer.GetAmountOfAllItems(), 5);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 3);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(3), 2);
            Assert.IsTrue(testedLogicLayer.AddCustomer(1, "BOB"));
            testedLogicLayer.RegisterSale("14/12/2020", 3, 0);
            Assert.AreEqual(testedDataLayer.GetAmountOfAllItems(), 4);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 3);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(3), 1);
        }
        [TestMethod]
        public void TestRevenue()
        {
            DataLayerAbstractAPI testedDataLayer = DataLayerAbstractAPI.CreateMyDataLayer();
            testedDataLayer.InitializeCatalog();
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer(testedDataLayer);
            testedLogicLayer.RegisterDelivery("12/12/2020", 0, 3);

            testedLogicLayer.AddCustomer(0, "BOB");
            testedLogicLayer.RegisterSale("12/12/2020", 0, 0);
            testedLogicLayer.RegisterSale("13/12/2020", 0, 0);
            testedLogicLayer.RegisterSale("14/12/2020", 0, 0);
            Assert.AreEqual(testedLogicLayer.CountRevenueFromSales(), 2999.99F * 3);
        }
    }
}
