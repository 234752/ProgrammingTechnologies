using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;
using Presentation.ViewModels.MVVMLight;
using Presentation.Models.ModelsAPI;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class CustomerListViewModel : BaseViewModel
    {
        private IDataModel model = new DataModel();
        private ObservableCollection<CustomerViewModel> _Customers = new ObservableCollection<CustomerViewModel>();
        private CustomerViewModel _CurrentCustomer;
        private ICommand _RemoveCustomerCommand;
        private ICommand _AddCustomerCommand;
        private int _NextCustomerId = 0;

        public CustomerListViewModel()
        {
            _Customers = new ObservableCollection<CustomerViewModel>();
            foreach(ICustomerModel customer in model.Customers)
            {
                _Customers.Add(new CustomerViewModel(_NextCustomerId, customer.FirstName, customer.LastName));
                _NextCustomerId++;
            }
            _RemoveCustomerCommand = new RelayCommand(() => RemoveCustomer());
            _AddCustomerCommand = new RelayCommand(() => AddCustomer());
        }
        public CustomerListViewModel(IDataModel dataModel)
        {
            if (dataModel != null) model = dataModel;
            _Customers = new ObservableCollection<CustomerViewModel>();
            foreach (ICustomerModel customer in model.Customers)
            {
                _Customers.Add(new CustomerViewModel(customer.Id, customer.FirstName, customer.LastName));
            }
            _RemoveCustomerCommand = new RelayCommand(() => RemoveCustomer());
            _AddCustomerCommand = new RelayCommand(() => AddCustomer());
        }
        public ObservableCollection<CustomerViewModel> Customers
        { get { return _Customers; } set { _Customers = value; RaisePropertyChanged(nameof(Customers)); } }
        public CustomerViewModel CurrentCustomer
        { get { return _CurrentCustomer; } set { _CurrentCustomer = value; RaisePropertyChanged(nameof(CurrentCustomer)); } }
        public ICommand RemoveCustomerCommand { get { return _RemoveCustomerCommand; } }
        public ICommand AddCustomerCommand { get { return _AddCustomerCommand; } }

        public void RemoveCustomer()
        {
            Customers.Remove(CurrentCustomer);
        }
        public void AddCustomer()
        {
            Customers.Add(new CustomerViewModel() { Id = _NextCustomerId, FirstName = "", LastName = "" });
            CurrentCustomer = Customers.Last();
            _NextCustomerId++;
        }
    }
}
