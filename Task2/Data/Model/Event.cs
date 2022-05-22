using Data.API;
    using System;

namespace Data.Model

{


    public class Event : IEvent
    {
        public int EventId { get; set; }
        public string Date { get; set; }
        public bool IsDelivery { get; set; }
        public int CatalogId { get; set; }
        public int CustomerId { get; set; }
        public Event(int id,string date, bool isdelivered, int catalogid, int customerid)
        {
            EventId = id;
            Date = date;
            IsDelivery = isdelivered;
            CatalogId = catalogid;
            CustomerId = customerid;
        }
    }
}