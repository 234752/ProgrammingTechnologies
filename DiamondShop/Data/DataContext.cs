using Data.Model;
using System.Data.Entity;

namespace Data;

public class DataContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    internal DbSet<Diamond> Diamonds { get; set; }
    internal DbSet<Event> Events { get; set; }

    public DataContext()
    {
        this.Database.Connection.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=DiamondShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
