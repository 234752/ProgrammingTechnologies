using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Model;
using Data.Context;

namespace Data.API;

public abstract class AbstractDataAPI
{
    public static AbstractDataAPI createLayer()
    {
        return new DataLayer();
    }
    public abstract void ClearDatabase();
    public abstract void AddCustomer(int id, string name, string surname);
    public abstract List<ICustomer> GetCustomers();

    internal class DataLayer : AbstractDataAPI
    {
        public override void ClearDatabase()
        {
            using(DataContext context = new DataContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Events");
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Diamonds");
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Customers");
            }            
        }
        public override void AddCustomer(int id, string name, string surname)
        {
            using (DataContext context = new DataContext())
            {
                context.Customers.Add(new Customer(id, name, surname));
                context.SaveChanges();
            }            
        }

        public override List<ICustomer> GetCustomers()
        {
            using (DataContext context = new DataContext())
            {
                List<ICustomer> customers = context.Customers.ToList<ICustomer>();
                return customers;
            }                      
        }
    }
}

