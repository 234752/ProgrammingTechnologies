using Data.Model;
using System.Data.Entity;

namespace Data.Context;

internal class DataContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Diamond> Diamonds { get; set; }
    public DbSet<Event> Events { get; set; }

    internal DataContext()
    {
        this.Database.Connection.ConnectionString = @"Data Source=(localdb)\ProjectModels;Initial Catalog=DiamondShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
    }
}
