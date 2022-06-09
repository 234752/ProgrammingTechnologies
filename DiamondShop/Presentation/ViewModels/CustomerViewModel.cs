using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;
using Presentation.ViewModels.MVVMLight;

namespace Presentation.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        
        private DataModel model = new DataModel();
        private int _Id;
        private string _FirstName;
        private string _LastName;
        public CustomerViewModel(int id, string first, string last)
        {
            _Id = id;
            _FirstName = first;
            _LastName = last;
        }
        public CustomerViewModel() { }
        public int Id { get { return _Id; } set { _Id = value; RaisePropertyChanged(nameof(Id)); } }
        public string FirstName { get { return _FirstName; } set { _FirstName = value; RaisePropertyChanged(nameof(FirstName)); } }
        public string LastName { get { return _LastName; } set { _LastName = value; RaisePropertyChanged(nameof(LastName)); } }

    }
}
