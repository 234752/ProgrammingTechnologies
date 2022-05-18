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
        private CustomerListView _InnerView;
        public MainViewModel()
        {
            _InnerView = new CustomerListView();
        }
        public CustomerListView InnerView { get { return _InnerView; } set { _InnerView = value; } }
    }
}
