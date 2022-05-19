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
        private ICommand _ChangeInnerViewToCustomers;
        private ICommand _ChangeInnerViewToDiamonds;
        private ICommand _ChangeInnerViewToEvents;
        public MainViewModel()
        {
            _ChangeInnerViewToCustomers = new RelayCommand(() => ChangeViewToCustomers());
            _ChangeInnerViewToDiamonds = new RelayCommand(() => ChangeViewToDiamonds());
            _ChangeInnerViewToEvents = new RelayCommand(() => ChangeViewToEvents());
        }
        public UserControl InnerView { get { return _InnerView; } set { _InnerView = value; RaisePropertyChanged(nameof(InnerView)); } }
        public ICommand ChangeInnerViewToCustomers { get { return _ChangeInnerViewToCustomers; } }
        public ICommand ChangeInnerViewToDiamonds { get { return _ChangeInnerViewToDiamonds; } }
        public ICommand ChangeInnerViewToEvents { get { return _ChangeInnerViewToEvents; } }
        public void ChangeViewToCustomers()
        {
            InnerView = new CustomerListView();
        }
        public void ChangeViewToDiamonds()
        {
            InnerView = new DiamondListView();
        }
        public void ChangeViewToEvents()
        {
            //InnerView = new EventListView();
        }
    }
}
