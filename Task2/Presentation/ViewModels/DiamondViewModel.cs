using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;
using Presentation.ViewModels.MVVMLight;

namespace Presentation.ViewModels
{
    internal class DiamondViewModel : BaseViewModel
    {
        private int _Id;
        private string _Name;
        private string _Quality;
        private decimal _Price;
        public DiamondViewModel(int id, string name, string quality, decimal price)
        {
            _Id = id;
            _Name = name;
            _Quality = quality;
            _Price = price;
        }

        public int Id { get { return _Id; } set { _Id = value; } }
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Quality { get { return _Quality; } set { _Quality = value; } }
        public decimal Price { get { return _Price; } set { _Price = value; } }
        
    }
}
