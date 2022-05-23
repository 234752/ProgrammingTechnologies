using Data;
using Service;
using Service.API;
using Service.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Collections.Generic;

namespace TestService
{
    [TestClass]
    public class TestServices
    {

        private readonly AbstractDataAPI dataLayer = Substitute.For<AbstractDataAPI>();

        [TestMethod]
        public void TestCustomers()
        {
            CustomerService custService = new CustomerService(dataLayer);
            dataLayer.AddCustomer(1, "Piotr", "Makin").Returns(true);
            Assert.IsTrue(custService.AddCustomer(1, "Piotr", "Makin"));
            dataLayer.AddCustomer(1, "Piotr", "Makin").Returns(false);
            Assert.IsFalse(custService.AddCustomer(1, "Piotr", "Makin"));
            dataLayer.UpdateCustomer(1, "Kamil", "Makin").Returns(true);
            Assert.IsTrue(custService.UpdateCustomer(1, "Kamil", "Makin"));
            dataLayer.DeleteCustomer(1).Returns(true);
            Assert.IsTrue(custService.DeleteCustomer(1));

        }
        public void TestDiamonds()
        {
            DiamondService diamService = new DiamondService(dataLayer);
            dataLayer.AddDiamond(1, 13.37M, "Highest Quality", "Very Big Diamond").Returns(true);
            Assert.IsTrue(diamService.AddDiamond(1, 13.37M, "Highest Quality", "Very Big Diamond"));
            dataLayer.AddDiamond(1, 13.37M, "Highest Quality", "Very Big Diamond").Returns(false);
            Assert.IsFalse(diamService.AddDiamond(1, 13.37M, "Highest Quality", "Very Big Diamond"));
            dataLayer.UpdateDiamond(1, 15.37M, "Highest Quality", "Very Big Diamond").Returns(true);
            Assert.IsTrue(diamService.UpdateDiamond(1, 15.37M, "Highest Quality", "Very Big Diamond"));
            dataLayer.DeleteDiamond(1).Returns(true);
            Assert.IsTrue(diamService.DeleteDiamond(1));
        }
        public void TestEvents()
        {
            EventService evService = new EventService(dataLayer);
            dataLayer.AddEvent(3, "20/05/2022", "true", 1,1).Returns(true);
            Assert.IsTrue(evService.AddEvent(3, "20/05/2022", "true", 1, 1));
            dataLayer.AddEvent(3, "20/05/2022", "true", 1, 1).Returns(false);
            Assert.IsFalse(evService.AddEvent(3, "20/05/2022", "true", 1, 1));
            dataLayer.UpdateEvent(3, "22/05/2022", "false", 1, 1).Returns(true);
            Assert.IsTrue(evService.UpdateEvent(3, "22/05/2022", "false", 1, 1));
            dataLayer.DeleteEvent(1).Returns(true);
            Assert.IsTrue(evService.DeleteEvent(1));
        }
    }
}