using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.ViewModel
{
    internal class MainViewModel
    {
        private CustomerViewModel _InnerView;
        public MainViewModel()
        {
            _InnerView = new CustomerViewModel();
        }
        public CustomerViewModel InnerView { get { return _InnerView; } set { _InnerView = value; } }
    }
}
