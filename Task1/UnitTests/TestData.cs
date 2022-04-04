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
            testedCollection.Add(new Customer(12, "Bob"));
            Assert.IsTrue(testedCollection.Count == 1);
        }
    }
}