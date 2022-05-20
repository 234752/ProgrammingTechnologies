using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.API
{
     public interface IEvent
    {
        string Date { get; set; }
        int Id { get; set; }
        string Date { get; set; }
        bool IsDelivery { get; set; }
        int CatalogId { get; set; }
    }
}
