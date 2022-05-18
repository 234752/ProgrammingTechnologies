using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;

namespace Presentation.ViewModel
{
    internal class CustomerListViewModel
    {
        private DataModel model = new DataModel();
        private List<String> _Customers = new List<string>() { "customer1", "customer2" };

        public CustomerListViewModel()
        {
           
        }
        public List<String> Customers
        {
            get
            {
                return _Customers;
            }
            set
            {
                _Customers = value;
            }
        }
    }
}
