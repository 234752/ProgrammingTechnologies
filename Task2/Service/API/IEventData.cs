using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public interface IEventData
    {
         string Date { get; }
         int EventId { get; }
         string IsDelivery { get; }
        int CatalogId { get; }

         int CustomerId { get;  }
    }
}
