using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace UnitTests
{
    [TestClass]
    public class TestData
    {
        [TestMethod]
        public void AddCustomer()
        {
            Customers testedCollection = new Customers();
            Assert.IsTrue(testedCollection.Count == 0);
        }
    }
}