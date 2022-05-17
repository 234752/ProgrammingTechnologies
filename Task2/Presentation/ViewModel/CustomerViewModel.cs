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
        private int _Id = 7;
        public CustomerViewModel()
        {
            Id = model.Customers.ElementAt(1).Id;
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
    }
}
