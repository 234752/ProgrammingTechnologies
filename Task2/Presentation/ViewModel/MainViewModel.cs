using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Views;

namespace Presentation.ViewModel
{
    internal class MainViewModel
    {
        private CustomerView _InnerView;
        private CustomerListView _InnerView2;
        public MainViewModel()
        {
            _InnerView = new CustomerView();
            _InnerView2 = new CustomerListView();
        }
        public CustomerView InnerView { get { return _InnerView; } set { _InnerView = value; } }
        public CustomerListView InnerView2 { get { return _InnerView2; } set { _InnerView2 = value; } }
    }
}
