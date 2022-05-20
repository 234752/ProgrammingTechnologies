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
        internal Event(string date)
        {
            Date = date;
            //Entry = entry;
        }
    }
}