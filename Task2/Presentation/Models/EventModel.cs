using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public bool IsDelivery { get; set; }
        public int CatalogId { get; set; }
        public override string ToString()
        {
            return Id + " " + Date + " " + CatalogId + " " + IsDelivery;
        }
    }
}
