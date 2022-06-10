using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;

namespace Data.API;

public abstract class AbstractDataAPI
{
    public static AbstractDataAPI createLayer()
    {
        return new DataLayer(new DataContext());
    }
    public abstract void ClearDatabase();
    public abstract void AddCustomer(int id, string name, string surname);
    public abstract IEnumerable<ICustomer> GetCustomers();

    internal class DataLayer : AbstractDataAPI
    {
        private DataContext context;
        internal DataLayer(DataContext c)
        {
            context = c;
        }
        public override void ClearDatabase()
        {
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE Events");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE Diamonds");
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE Customers");
        }
        public override void AddCustomer(int id, string name, string surname)
        {
            context.Customers.Add(new Customer(id, name, surname));
            context.SaveChanges();
        }

        public override IEnumerable<ICustomer> GetCustomers()
        {
            IEnumerable<ICustomer> customers = context.Customers.AsEnumerable();
            return customers;
        }
    }
}

