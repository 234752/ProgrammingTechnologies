using Data;
using System.Linq;

namespace TestData;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        DataContext db = new DataContext();
        db.Customers.Add(new Data.Model.Customer(1, "bob", "bob's surname"));
        Assert.AreEqual(1, db.Customers.Count());
        var name = db.Customers.Where(x => x.CustomerId == 1).Select(x => x.Name).ToArray();
        Assert.AreEqual("bob", name[0]);
        db.SaveChanges();
    }
}