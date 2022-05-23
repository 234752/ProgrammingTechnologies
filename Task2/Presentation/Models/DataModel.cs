using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models.ModelsAPI;

namespace Presentation.Models
{
    public class DataModel : IDataModel
    {
        public IList<ICustomerModel> Customers
        {
            get
            {
                List<ICustomerModel> Customers = new List<ICustomerModel>()
                {
                };
                return Customers;
            }
        }

        public IList<IDiamondModel> Diamonds
        {
            get
            {
                List<IDiamondModel> Diamonds = new List<IDiamondModel>()
                {
                };
                return Diamonds;
            }
        }

        public IList<IEventModel> Events
        {
            get
            {
                List<IEventModel> Events = new List<IEventModel>()
                {
                };
                return Events;
            }
        }
    }
}
