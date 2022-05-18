using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;

namespace Presentation.ViewModel
{
    internal class CustomerListViewModel
    {
        private DataModel model = new DataModel();
        private ObservableCollection<CustomerModel> _Customers = new ObservableCollection<CustomerModel>();

        public CustomerListViewModel()
        {
            _Customers = new ObservableCollection<CustomerModel>(model.Customers);
        }
        public ObservableCollection<CustomerModel> Customers
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
