using Data.API;
    using System;

namespace Data.Model

{


    public class Event //: IEvent
    {
        public int EventId;
        public string Date;
        public bool IsDelivery;
        public int CatalogId;
        public int CustomerId;
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