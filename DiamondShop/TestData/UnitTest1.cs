using Data.API;
using System.Linq;

namespace TestData;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        
        AbstractDataAPI testedDataLayer = AbstractDataAPI.createLayer();
        testedDataLayer.AddCustomer(1, "bob", "bob2");
        Assert.AreEqual(1, testedDataLayer.GetCustomers().Count());
        IEnumerable<ICustomer> fetchedCustomers = testedDataLayer.GetCustomers();
        Assert.AreEqual("bob", fetchedCustomers.ElementAt(0).Name);

    }
}