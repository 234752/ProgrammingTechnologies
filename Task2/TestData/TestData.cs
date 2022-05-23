using Data;
using Data.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using Data.API;

namespace TestData
{
    [TestClass]
    public class RepositoryTest
    {
        [TestMethod]
        public void test1()
        {
            IDataAPI dataLayer = IDataAPI.CreateLayer("DiamondShop");
        }
        

    }
}
