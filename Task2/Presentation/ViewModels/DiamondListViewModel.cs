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
        private ICommand _AddDiamondCommand;
        private int _NextDiamondId = 0;

        public DiamondListViewModel()
        {
            _Diamonds = new ObservableCollection<DiamondViewModel>();
            foreach (IDiamondModel diamond in model.Diamonds)
            {
                _Diamonds.Add(new DiamondViewModel(_NextDiamondId, diamond.Name, diamond.Quality, diamond.Price));
                _NextDiamondId++;
            }
            _RemoveDiamondCommand = new RelayCommand(() => RemoveDiamond());
            _AddDiamondCommand = new RelayCommand(() => AddDiamond());
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
            _AddDiamondCommand = new RelayCommand(() => AddDiamond());
        }
        public ObservableCollection<DiamondViewModel> Diamonds
        { get { return _Diamonds; } set { _Diamonds = value; RaisePropertyChanged(nameof(Diamonds)); } }
        public DiamondViewModel CurrentDiamond
        { get { return _CurrentDiamond; } set { _CurrentDiamond = value; RaisePropertyChanged(nameof(CurrentDiamond)); } }
        public ICommand RemoveDiamondCommand { get { return _RemoveDiamondCommand; } }
        public ICommand AddDiamondCommand { get { return _AddDiamondCommand; } }

        public void RemoveDiamond()
        {
            Diamonds.Remove(CurrentDiamond);
        }
        public void AddDiamond()
        {
            Diamonds.Add(new DiamondViewModel() { Id = _NextDiamondId, Name = "", Price = 0M, Quality = ""});
            _NextDiamondId++;
        }
    }
}
