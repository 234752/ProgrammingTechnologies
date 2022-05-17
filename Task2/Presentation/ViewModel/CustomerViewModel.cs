using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;

namespace Presentation.ViewModel
{
    internal class CustomerViewModel
    {
        
        private DataModel model = new DataModel();
        private int _Id;
        private string _FirstName;
        private string _LastName;
        public CustomerViewModel()
        {
            _Id = model.Customers.ElementAt(0).Id;
            _FirstName = model.Customers.ElementAt(0).FirstName;
            _LastName = model.Customers.ElementAt(0).LastName;
        }

        public int Id 
        { 
            get 
            { 
                return _Id; 
            }
            set
            {
                _Id = value;
            }
        }
        public string FirstName
        { 
            get 
            { 
                return _FirstName; 
            } 
            set 
            { 
                _FirstName = value; 
            } 
        }
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }

    }
}
