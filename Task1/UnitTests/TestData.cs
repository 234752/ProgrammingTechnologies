using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;
using Logic;

namespace UnitTests
{
    [TestClass]
    public class TestData
    {
        [TestMethod]
        public void AddCustomer()
        {
            LogicLayerAbstractAPI testedLogicLayer = LogicLayerAbstractAPI.CreateMyLogicLayer(null);
            testedLogicLayer.addCustomer(1, "Bob");
            
        }
    }
}