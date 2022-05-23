using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestData
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void TestConnection()
        {
            AbstractDataAPI dataLayer = AbstractDataAPI.CreateLayer("Data Source=LAPTOP-6CIA6OPN;Initial Catalog=DiamondShop;Integrated Security=True");
            dataLayer.AddCustomer(0, "bob", "surname");
            Assert.AreEqual(dataLayer.GetCustomer(0).Name, "bob");

            dataLayer.AddDiamond(0, 102.20M, "Very Good","Diam");
            Assert.AreEqual(dataLayer.GetDiamond(0).Price, 201.2M);

            dataLayer.AddEvent(0, "20/05/2022", "True", 0, 0);
            Assert.AreEqual(dataLayer.GetEvent(0).Date, "20/05/2022");
        }

        [TestMethod]
        public void TestRemove()
        {
            AbstractDataAPI dataLayer = AbstractDataAPI.CreateLayer("Data Source=LAPTOP-6CIA6OPN;Initial Catalog=DiamondShop;Integrated Security=True");
            dataLayer.AddCustomer(0, "bob", "surname");
            Assert.AreEqual(dataLayer.GetCustomer(0).Name, "bob");

            dataLayer.DeleteCustomer(0);
            Assert.AreEqual(dataLayer.GetCustomer(0), null);

        }


    }
}
