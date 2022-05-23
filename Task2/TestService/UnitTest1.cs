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
        public void AddCustomers()
        {
            CustomerService custService = new CustomerService(dataLayer);

        }
    }
}