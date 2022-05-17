using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models
{
    internal class EventModel
    {
        internal int Id { get; set; }
        internal string Date { get; set; }
        internal bool IsDelivery { get; set; }
        internal bool CatalogId { get; set; }
        public override string ToString()
        {
            return Id + " " + Date + " " + CatalogId + " " + IsDelivery;
        }
    }
}
