using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class TestData
    {
        [TestMethod]
        public void AddRemoveCustomer()
        {
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer(null);
            testedLogicLayer.addCustomer(1, "Bob");
            Assert.AreEqual(1, testedLogicLayer.getCustomerCount());
            testedLogicLayer.addCustomer(2, "Bob2");
            Assert.AreEqual(2, testedLogicLayer.getCustomerCount());
            Assert.IsTrue(testedLogicLayer.removeCustomer(0));
            Assert.AreEqual(1, testedLogicLayer.getCustomerCount());
        }
    }
}