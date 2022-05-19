using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;
using Presentation.ViewModels.MVVMLight;

namespace Presentation.ViewModels
{
    public class DiamondListViewModel : BaseViewModel
    {
        private DataModel model = new DataModel();
        private ObservableCollection<DiamondViewModel> _Diamonds = new ObservableCollection<DiamondViewModel>();
        private DiamondViewModel _CurrentDiamond;

        public DiamondListViewModel()
        {
            _Diamonds = new ObservableCollection<DiamondViewModel>();
            foreach (DiamondModel diamond in model.Diamonds)
            {
                _Diamonds.Add(new DiamondViewModel(diamond.Id, diamond.Name, diamond.Quality, diamond.Price));
            }
        }
        public ObservableCollection<DiamondViewModel> Diamonds
        {
            get
            {
                return _Diamonds;
            }
            set
            {
                _Diamonds = value;
            }
        }
        public DiamondViewModel CurrentDiamond
        {
            get
            {
                return _CurrentDiamond;
            }
            set
            {
                _CurrentDiamond = value;
                RaisePropertyChanged(nameof(CurrentDiamond));
            }
        }
    }
}
