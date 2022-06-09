using Data.Model;
using System.Data.Entity;

namespace Data;

internal class DataContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Diamond> Diamonds { get; set; }
    public DbSet<Event> Events { get; set; }
}
