﻿namespace Data
{
    internal class EventDiamondSold : Event
    {
        private Customer _customer; 

        internal EventDiamondSold(string date, StorageEntry entry, Customer customer)
        {
            Date = date;
            Entry = entry;
            _customer = customer;
        }
    }
}
