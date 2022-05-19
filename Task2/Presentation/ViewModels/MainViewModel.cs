using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Views;
using Presentation.ViewModels.MVVMLight;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private CustomerListView _InnerView;
        private ICommand _ChangeInnerView;
        public MainViewModel()
        {
            _ChangeInnerView = new RelayCommand(() => ChangeView());
        }
        public CustomerListView InnerView { get { return _InnerView; } set { _InnerView = value; RaisePropertyChanged(nameof(InnerView)); } }
        public ICommand ChangeInnerView { get { return _ChangeInnerView; } }
        public void ChangeView()
        {
            InnerView = new CustomerListView();
        }
    }
}
