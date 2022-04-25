using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data.API;
using Logic.API;

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
            testedLogicLayer.AddCatalogEntry(1, 1F, 1999.99F, 2, 2);
            testedLogicLayer.AddCatalogEntry(3, 1F, 3999.99F, 1, 1);
            testedLogicLayer.AddCatalogEntry(4, 1F, 3999.99F, 1, 1);
            testedLogicLayer.RegisterDelivery("12/12/2020", 1, 3);
            testedLogicLayer.RegisterDelivery("13/12/2020", 3, 2);
            Assert.AreEqual(testedDataLayer.GetAmountOfAllItems(), 5);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 3);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(3), 2);
            Assert.IsTrue(testedLogicLayer.AddCustomer(0, "BOB"));
            testedLogicLayer.RegisterSale("14/12/2020", 3, 0);
            Assert.AreEqual(testedDataLayer.GetAmountOfAllItems(), 4);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(1), 3);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(3), 1);
            Assert.AreEqual(testedDataLayer.GetAmountOfCatalogItem(4), 0);
        }
        [TestMethod]
        public void TestRevenue()
        {
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer();
            testedLogicLayer.AddCatalogEntry(0, 1F, 1999.99F, 2, 2);
            testedLogicLayer.AddCatalogEntry(1, 1F, 3999.99F, 1, 1);
            testedLogicLayer.RegisterDelivery("12/12/2020", 0, 3);
            testedLogicLayer.RegisterDelivery("14/12/2020", 1, 1);

            testedLogicLayer.AddCustomer(0, "BOB");
            testedLogicLayer.AddCustomer(1, "BOB1");
            testedLogicLayer.AddCustomer(2, "BOB2");
            Assert.IsTrue(testedLogicLayer.RegisterSale("12/12/2020", 0, 0));
            Assert.IsTrue(testedLogicLayer.RegisterSale("13/12/2020", 0, 1));
            Assert.IsTrue(testedLogicLayer.RegisterSale("14/12/2020", 0, 2));
            Assert.AreEqual(testedLogicLayer.CountRevenueFromSales(), 1999.99F * 3);
            testedLogicLayer.RegisterSale("15/12/2020", 1, 2);
            Assert.AreEqual(testedLogicLayer.CountRevenueFromSales(), 1999.99F * 3 + 3999.99F);
        }
    }
}
