using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;

namespace Presentation.ViewModel
{
    public class CustomerListViewModel
    {
        private DataModel model = new DataModel();
        private ObservableCollection<CustomerModel> _Customers = new ObservableCollection<CustomerModel>();
        private CustomerViewModel _CurrentCustomer;

        public CustomerListViewModel()
        {
            _Customers = new ObservableCollection<CustomerModel>(model.Customers);
            _CurrentCustomer = new CustomerViewModel(model.Customers.ElementAt(2).Id, model.Customers.ElementAt(2).FirstName, model.Customers.ElementAt(2).LastName);
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
        public CustomerViewModel CurrentCustomer
        {
            get
            {
                return _CurrentCustomer;
            }
            set
            {
                _CurrentCustomer = value;
            }
        }
    }
}
