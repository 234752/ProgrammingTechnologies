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
            CustomerListViewModel csvm = new CustomerListViewModel(dataModelMock);

            Assert.AreEqual(csvm.Customers[0].FirstName, "First Name");
            Assert.AreEqual(csvm.Customers[0].ToString(), "Customer Mock");

        }
    }
}
