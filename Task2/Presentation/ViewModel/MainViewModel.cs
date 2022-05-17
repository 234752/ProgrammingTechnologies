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
        public MainViewModel()
        {
            _InnerView = new CustomerView();
        }
        public CustomerView InnerView { get { return _InnerView; } set { _InnerView = value; } }
    }
}
