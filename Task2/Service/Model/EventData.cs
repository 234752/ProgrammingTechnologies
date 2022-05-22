using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Service.Model
{
    internal class EventData :IEventData
    {
       public string Date { get; set; }
        public int EventId { get; set; }
        public string IsDelivery { get; set; }
       public  int CatalogId { get; set; }

       public int CustomerId { get; set; }

        public EventData(int id, string date, string isdelivered, int catalogid, int customerid)
        {
            EventId = id;
            Date = date;
            IsDelivery = isdelivered;
            CatalogId = catalogid;
            CustomerId = customerid;
        }
     
    }
}
