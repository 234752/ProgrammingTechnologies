using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;
using Presentation.ViewModels.MVVMLight;
using Presentation.Models.ModelsAPI;
using System.Windows.Input;

namespace Presentation.ViewModels
{
    public class DiamondListViewModel : BaseViewModel
    {
        private IDataModel model = new DataModel();
        private ObservableCollection<DiamondViewModel> _Diamonds = new ObservableCollection<DiamondViewModel>();
        private DiamondViewModel _CurrentDiamond;
        private ICommand _RemoveDiamondCommand;

        public DiamondListViewModel()
        {
            _Diamonds = new ObservableCollection<DiamondViewModel>();
            foreach (IDiamondModel diamond in model.Diamonds)
            {
                _Diamonds.Add(new DiamondViewModel(diamond.Id, diamond.Name, diamond.Quality, diamond.Price));
            }
            _RemoveDiamondCommand = new RelayCommand(() => RemoveDiamond());
        }
        public DiamondListViewModel(IDataModel dataModel)
        {
            if (dataModel != null) model = dataModel;
            _Diamonds = new ObservableCollection<DiamondViewModel>();
            foreach (IDiamondModel diamond in model.Diamonds)
            {
                _Diamonds.Add(new DiamondViewModel(diamond.Id, diamond.Name, diamond.Quality, diamond.Price));
            }
            _RemoveDiamondCommand = new RelayCommand(() => RemoveDiamond());
        }
        public ObservableCollection<DiamondViewModel> Diamonds
        { get { return _Diamonds; } set { _Diamonds = value; RaisePropertyChanged(nameof(Diamonds)); } }
        public DiamondViewModel CurrentDiamond
        { get { return _CurrentDiamond; } set { _CurrentDiamond = value; RaisePropertyChanged(nameof(CurrentDiamond)); } }
        public ICommand RemoveDiamondCommand { get { return _RemoveDiamondCommand; } }

        public void RemoveDiamond()
        {
            Diamonds.Remove(CurrentDiamond);
        }
    }
}
