using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API;

public abstract class AbstractDataAPI
{
    public static AbstractDataAPI createLayer()
    {
        return new DataLayer(new DataContext());
    }

    public abstract void AddCustomer(ICustomer c);
    public abstract IEnumerable<ICustomer> GetCustomers();

    internal class DataLayer : AbstractDataAPI
    {
        private DataContext context;
        internal DataLayer(DataContext c)
        {
            context = c;
        }
        public override void AddCustomer(ICustomer c)
        {
            context.Customers.Add(new Model.Customer(c.CustomerId, c.Name, c.Surname));
        }

        public override IEnumerable<ICustomer> GetCustomers()
        {
            IEnumerable<ICustomer> customers = context.Customers.AsEnumerable();
            return customers;
        }
    }
}

