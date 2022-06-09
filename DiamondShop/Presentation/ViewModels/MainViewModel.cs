using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Views;
using Presentation.ViewModels.MVVMLight;
using System.Windows.Input;
using System.Windows.Controls;

namespace Presentation.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private UserControl _InnerView;
        private ICommand _ChangeViewToCustomersCommand;
        private ICommand _ChangeViewToDiamondsCommand;
        private ICommand _ChangeViewToEventsCommand;
        public MainViewModel()
        {
            _ChangeViewToCustomersCommand = new RelayCommand(() => ChangeViewToCustomers());
            _ChangeViewToDiamondsCommand = new RelayCommand(() => ChangeViewToDiamonds());
            _ChangeViewToEventsCommand = new RelayCommand(() => ChangeViewToEvents());
        }
        public UserControl InnerView { get { return _InnerView; } set { _InnerView = value; RaisePropertyChanged(nameof(InnerView)); } }
        public ICommand ChangeViewToCustomersCommand { get { return _ChangeViewToCustomersCommand; } }
        public ICommand ChangeViewToDiamondsCommand { get { return _ChangeViewToDiamondsCommand; } }
        public ICommand ChangeViewToEventsCommand { get { return _ChangeViewToEventsCommand; } }
        public void ChangeViewToCustomers()
        {
            InnerView = new CustomerListView();
            RaisePropertyChanged(nameof(InnerView));
        }
        public void ChangeViewToDiamonds()
        {
            InnerView = new DiamondListView();
            RaisePropertyChanged(nameof(InnerView));
        }
        public void ChangeViewToEvents()
        {
            InnerView = new EventListView();
            RaisePropertyChanged(nameof(InnerView));
        }
    }
}
