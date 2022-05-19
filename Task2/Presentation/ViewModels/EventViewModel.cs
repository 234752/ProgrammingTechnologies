using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ViewModels
{
    public class EventViewModel
    {
        public int _Id;
        public string _Date;
        public bool _IsDelivery;
        public int _CatalogId;

        public EventViewModel(int id, string date, bool isDelivery, int catalogId)
        {
            _Id = id;
            _Date = date;
            _IsDelivery = isDelivery;
            _CatalogId = catalogId;
        }
        public EventViewModel() { }
        public int Id { get { return _Id; } set { _Id = value; } }
        public string Date { get { return _Date; } set { _Date = value; } }
        public bool IsDelivery { get { return _IsDelivery; } set { _IsDelivery = value;} }
        public int CatalogId { get { return _CatalogId; } set { _CatalogId = value;} }
    }
}
