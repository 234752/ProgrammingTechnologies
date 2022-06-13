using Data.API;

namespace TestData;

[TestClass]
public class DatabaseTest
{
    [TestMethod]
    public void TestMethod1()
    {
        AbstractDataAPI testedDataLayer = AbstractDataAPI.createLayer();
        testedDataLayer.DropTableCustomers();
        testedDataLayer.AddCustomer(10, "bob", "bob2");
        testedDataLayer.AddCustomer(10, "bob", "bob2");
        Assert.AreEqual(2, testedDataLayer.GetCustomers().Count());
        IEnumerable<ICustomer> fetchedCustomers = testedDataLayer.GetCustomers();
        Assert.AreEqual("bob", fetchedCustomers.ElementAt(0).Name);
    }
}