using System.Collections.Generic;

namespace Data
{
    internal class DataContext
    {
        internal List<Customer> Customers;
        internal List<StorageEntry> StorageState; //maybe its useless?
        internal List<Event> Events;    
        internal List<Diamond> Catalog;  

        internal DataContext()
        {
            Customers = new List<Customer>();
            StorageState = new List<StorageEntry>();
            Events = new List<Event>();
            Catalog = new List<Diamond>();
        }
    }
}
