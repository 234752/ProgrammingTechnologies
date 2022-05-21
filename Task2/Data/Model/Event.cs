using Data.API;
    using System;

namespace Data.Model

{


    public class Event //: IEvent
    {
        public int Id;
        public string Date;
        public bool IsDelivery;
        public int CatalogId;
        public int CustomerId;
        internal Event(int id,string date, bool isdelivered, int catalogid, int customerid)
        {
            Id = id;
            Date = date;
            IsDelivery = isdelivered;
            CatalogId = catalogid;
            CustomerId = customerid;
        }
    }
}