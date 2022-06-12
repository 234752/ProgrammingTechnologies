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
using Data.API;

namespace Presentation.ViewModels;

public class CustomerListViewModel : BaseViewModel
{
    private IDataModel model = new DataModel();
    private ObservableCollection<CustomerViewModel> _Customers = new ObservableCollection<CustomerViewModel>();
    private CustomerViewModel _CurrentCustomer;
    private ICommand _RemoveCustomerCommand;
    private ICommand _AddCustomerCommand;
    private ICommand _SaveCustomersCommand;
    private AbstractDataAPI dataLayer;

    public CustomerListViewModel()
    {
        _Customers = new ObservableCollection<CustomerViewModel>();
        dataLayer = AbstractDataAPI.createLayer();

        Task.Run(() => FetchCustomersFromDatabase());

        _RemoveCustomerCommand = new RelayCommand(() => RemoveCustomer());
        _AddCustomerCommand = new RelayCommand(() => AddCustomer());
        _SaveCustomersCommand = new RelayCommand(() => SaveCustomers());
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
        _SaveCustomersCommand = new RelayCommand(() => SaveCustomers());
    }
    public ObservableCollection<CustomerViewModel> Customers
    { get { return _Customers; } set { _Customers = value; RaisePropertyChanged(nameof(Customers)); } }
    public CustomerViewModel CurrentCustomer
    { get { return _CurrentCustomer; } set { _CurrentCustomer = value; RaisePropertyChanged(nameof(CurrentCustomer)); } }
    public ICommand RemoveCustomerCommand { get { return _RemoveCustomerCommand; } }
    public ICommand AddCustomerCommand { get { return _AddCustomerCommand; } }
    public ICommand SaveCustomersCommand { get { return _SaveCustomersCommand; } }

    public void RemoveCustomer()
    {
        Customers.Remove(CurrentCustomer);
    }
    public void AddCustomer()
    {
        Customers.Add(new CustomerViewModel() { Id = 0, FirstName = "", LastName = "" });
        CurrentCustomer = Customers.Last();
    }
    public async void SaveCustomers()
    {        
        await Task.Run(() => SaveCustomersToDatabase());
        Task.Run(() => FetchCustomersFromDatabase());
    }
    private void FetchCustomersFromDatabase()
    {
        App.Current.Dispatcher.Invoke((Action)delegate
        {
            _Customers.Clear();
        });
        List<ICustomer> fetchedCustomers = dataLayer.GetCustomers();
        foreach (ICustomer c in fetchedCustomers)
        {
            App.Current.Dispatcher.Invoke((Action)delegate
            { 
                _Customers.Add(new CustomerViewModel(c.CustomerId, c.Name, c.Surname));
            });          
        }
    }
    private void SaveCustomersToDatabase()
    {
        dataLayer.ClearDatabase();
        foreach (CustomerViewModel c in Customers)
        {          
            dataLayer.AddCustomer(c.Id, c.FirstName, c.LastName);
        }
    }
}

