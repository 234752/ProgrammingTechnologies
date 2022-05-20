using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models.ModelsAPI
{

    public interface ICustomerModel
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string ToString();
    }

    public interface IDiamondModel
    {
        int Id { get; set; }
        string Name { get; set; }
        string Quality { get; set; }
        decimal Price { get; set; }

        string ToString();
    }

    public interface IEventModel
    {
        int Id { get; set; }
        string Date { get; set; }
        bool IsDelivery { get; set; }
        int CatalogId { get; set; }
        string ToString();
    }

    public interface IDataModel
    {
        public IEnumerable<ICustomerModel> Customers { get; }
        public IEnumerable<IDiamondModel> Diamonds { get; }
        public IEnumerable<IEventModel> Events { get; }
    }
}
