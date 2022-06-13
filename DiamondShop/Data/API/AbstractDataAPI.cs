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
    public abstract void DropTableCustomers();
    public abstract void DropTableDiamonds();
    public abstract void DropTableEvents();
    public abstract void AddCustomer(int id, string name, string surname);
    public abstract void AddDiamond(int id, string name, decimal price, string quality);
    public abstract List<ICustomer> GetCustomers();
    public abstract List<IDiamond> GetDiamonds();

    internal class DataLayer : AbstractDataAPI
    {
        public override void DropTableCustomers()
        {
            using(DataContext context = new DataContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Customers");               
            }            
        }
        public override void DropTableDiamonds()
        {
            using (DataContext context = new DataContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Diamonds");
            }
        }
        public override void DropTableEvents()
        {
            using (DataContext context = new DataContext())
            {
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE Events");
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
        public override void AddDiamond(int id, string name, decimal price, string quality)
        {
            using (DataContext context = new DataContext())
            {
                context.Diamonds.Add(new Diamond(id, price, quality, name));
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
        public override List<IDiamond> GetDiamonds()
        {
            using (DataContext context = new DataContext())
            {
                List<IDiamond> diamonds = context.Diamonds.ToList<IDiamond>();
                return diamonds;
            }
        }
    }
}

