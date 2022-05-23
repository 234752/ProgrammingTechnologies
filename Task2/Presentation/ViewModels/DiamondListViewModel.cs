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
using Service.API;
using Service.Model;

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
        private ICommand _SaveDiamondsCommand;
        private DiamondService _Service;

        public DiamondListViewModel()
        {
            _Diamonds = new ObservableCollection<DiamondViewModel>();
            _Service = new DiamondService();
            foreach (IDiamondModel diamond in model.Diamonds)
            {
                _Diamonds.Add(new DiamondViewModel(_NextDiamondId, diamond.Name, diamond.Quality, diamond.Price));
                _NextDiamondId++;
            }
            _RemoveDiamondCommand = new RelayCommand(() => RemoveDiamond());
            _AddDiamondCommand = new RelayCommand(() => AddDiamond());
            _SaveDiamondsCommand = new RelayCommand(() => SaveDiamonds());
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
            _SaveDiamondsCommand = new RelayCommand(() => SaveDiamonds());
        }
        public ObservableCollection<DiamondViewModel> Diamonds
        { get { return _Diamonds; } set { _Diamonds = value; RaisePropertyChanged(nameof(Diamonds)); } }
        public DiamondViewModel CurrentDiamond
        { get { return _CurrentDiamond; } set { _CurrentDiamond = value; RaisePropertyChanged(nameof(CurrentDiamond)); } }
        public ICommand RemoveDiamondCommand { get { return _RemoveDiamondCommand; } }
        public ICommand AddDiamondCommand { get { return _AddDiamondCommand; } }
        public ICommand SaveDiamondsCommand { get { return _SaveDiamondsCommand; } }

        public void RemoveDiamond()
        {
            Diamonds.Remove(CurrentDiamond);
        }
        public void AddDiamond()
        {
            Diamonds.Add(new DiamondViewModel() { Id = _NextDiamondId, Name = "", Price = 0M, Quality = ""});
            CurrentDiamond = Diamonds.Last();
            _NextDiamondId++;
        }
        public void SaveDiamonds()
        {
            //placeholder
        }
        private void FetchDiamondsFromDatabase()
        {
            _NextDiamondId = 0;
            for (int i = 0; _Service.GetProduct(i) != null; i++)
            {
                _Diamonds.Add(new DiamondViewModel(_NextDiamondId, _Service.GetProduct(i).Name, _Service.GetProduct(i).Quality, _Service.GetProduct(i).Price ));
                _NextDiamondId++;
            }
        }
        private void SaveDiamondsToDatabase()
        {
            foreach (DiamondViewModel d in Diamonds)
            {
                _Service.UpdateProduct(d.Id, d.Price, d.Quality);
            }
        }
    }
}
