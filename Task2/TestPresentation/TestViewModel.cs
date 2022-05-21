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
            IDataModel dataModelMock = new MockDataModel();
            MockData.GenerateDataMethod1(dataModelMock);
            CustomerListViewModel clvm = new CustomerListViewModel(dataModelMock);

            Assert.AreEqual(clvm.Customers[0].FirstName, "First Name");
            Assert.AreEqual(clvm.Customers[0].ToString(), "Customer Mock");
            
        }

        [TestMethod]
        public void DataGenerationMethod2()
        {
            IDataModel dataModelMock = new MockDataModel();
            MockData.GenerateDataMethod2(dataModelMock);

            CustomerListViewModel clvm = new CustomerListViewModel(dataModelMock);
            Assert.AreEqual(clvm.Customers[0].Id, 1);
            Assert.AreEqual(clvm.Customers[0].ToString(), "Customer Mock");

            DiamondListViewModel dlvm = new DiamondListViewModel(dataModelMock);
            Assert.AreEqual(dlvm.Diamonds[0].Price, 1M);
            Assert.AreEqual(dlvm.Diamonds[0].ToString(), "Diamond Mock");

            EventListViewModel elvm = new EventListViewModel(dataModelMock);
            Assert.AreEqual(elvm.Events[0].Date, "12/12/2022");
            Assert.AreEqual(elvm.Events[0].ToString(), "Event Mock");
        }
    }
}
