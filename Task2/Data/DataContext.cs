using System.Collections.Generic;

namespace Data.Model
{
    internal class DataContext
    {
        internal List<Customer> Customers;
        internal List<Event> Events;    
        internal List<Diamond> Catalog;  

        internal DataContext()
        {
            Customers = new List<Customer>();
            Events = new List<Event>();
            Catalog = new List<Diamond>();
        }
    }
}
