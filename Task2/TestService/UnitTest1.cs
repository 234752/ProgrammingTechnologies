using Data;
using Service;
using Service.API;
using Service.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Collections.Generic;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {

        private readonly IDataAPI dataLayer = Substitute.For<IDataAPI>();

        [TestMethod]
        public void TestCustomers()
        {
            CustomerService custService = new CustomerService(dataLayer);
            Assert.IsTrue(custService.AddCustomer(1, "Piotr", "Makin"));
            Assert.AreEqual(custService.GetCustomer(1).Name,"Piotr");
            Assert.IsTrue(custService.UpdateCustomer(1, "Kamil", "Makin"));
            Assert.AreEqual(custService.GetCustomer(1).Name, "Kamil");
            Assert.IsTrue(custService.DeleteCustomer(1));

        }
        public void TestDiamonds()
        {
            DiamondService diamService = new DiamondService(dataLayer);
           

        }
        public void TestEvents()
        {
            EventService evService = new EventService(dataLayer);
            
        }
    }
}