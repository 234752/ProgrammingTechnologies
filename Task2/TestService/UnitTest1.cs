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
            dataLayer.AddCustomer(1, "Piotr", "Makin").Returns(true);
            Assert.IsTrue(custService.AddCustomer(1, "Piotr", "Makin"));
            dataLayer.AddCustomer(1, "Piotr", "Makin").Returns(false);
            Assert.IsFalse(custService.AddCustomer(1, "Piotr", "Makin"));

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