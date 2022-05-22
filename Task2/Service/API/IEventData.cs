using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public abstract class IEventData
    {
        public string Date { get; }
        public int EventId { get; }
        public string IsDelivery { get; }
        public int CatalogId { get; }

        public int CustomerId { get;  }
    }
}
