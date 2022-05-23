using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Presentation.ViewModels;
using Presentation.Models.ModelsAPI;

namespace TestPresentation
{
    [TestClass]
    public class TestViewModel
    {
        [TestMethod]
        public void DataGenerationMethod1()
        {
            IDataModel dataModelMock = new MockDataModel1();

            //customer
            CustomerListViewModel clvm = new CustomerListViewModel(dataModelMock);
            Assert.AreEqual(clvm.Customers[0].Id, 102);
            Assert.AreEqual(clvm.Customers.Count, 3);

            //diamond
            DiamondListViewModel dlvm = new DiamondListViewModel(dataModelMock);
            Assert.AreEqual(dlvm.Diamonds[0].Price, 10.2M);
            Assert.AreEqual(dlvm.Diamonds.Count, 3);

            //event
            EventListViewModel elvm = new EventListViewModel(dataModelMock);
            Assert.AreEqual(elvm.Events[0].Date, "01/01/2000");
            Assert.AreEqual(elvm.Events.Count, 3);
        }

        [TestMethod]
        public void DataGenerationMethod2()
        {
            IDataModel dataModelMock = new MockDataModel2();

            //customer
            CustomerListViewModel clvm = new CustomerListViewModel(dataModelMock);
            Assert.AreEqual(clvm.Customers[0].Id, 102);
            Assert.AreEqual(clvm.Customers.Count, 1);

            //diamond
            DiamondListViewModel dlvm = new DiamondListViewModel(dataModelMock);
            Assert.AreEqual(dlvm.Diamonds[0].Price, 10.2M);
            Assert.AreEqual(dlvm.Diamonds.Count, 1);

            //event
            EventListViewModel elvm = new EventListViewModel(dataModelMock);
            Assert.AreEqual(elvm.Events[0].Date, "01/01/2000");
            Assert.AreEqual(elvm.Events.Count, 1);
        }
    }
}
