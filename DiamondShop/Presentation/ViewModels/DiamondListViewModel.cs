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
using Data.API;

namespace Presentation.ViewModels
{
    public class DiamondListViewModel : BaseViewModel
    {
        private IDataModel model = new DataModel();
        private ObservableCollection<DiamondViewModel> _Diamonds = new ObservableCollection<DiamondViewModel>();
        private DiamondViewModel _CurrentDiamond;
        private ICommand _RemoveDiamondCommand;
        private ICommand _AddDiamondCommand;
        private ICommand _SaveDiamondsCommand;
        private AbstractDataAPI dataLayer;

        public DiamondListViewModel()
        {
            _Diamonds = new ObservableCollection<DiamondViewModel>();
            dataLayer = AbstractDataAPI.createLayer();

            Task.Run(() => FetchDiamondsFromDatabase());

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
            Diamonds.Add(new DiamondViewModel() { Id = 0, Name = "", Price = 0M, Quality = ""});
            CurrentDiamond = Diamonds.Last();
        }
        public void SaveDiamonds()
        {
            Task.Run(() => SaveDiamondsToDatabase());
        }
        private void FetchDiamondsFromDatabase()
        {
            App.Current.Dispatcher.Invoke((Action)delegate
            {
                _Diamonds.Clear();
            });
            List<IDiamond> fetchedDiamonds = dataLayer.GetDiamonds();
            foreach (IDiamond d in fetchedDiamonds)
            {
                App.Current.Dispatcher.Invoke((Action)delegate
                {
                    _Diamonds.Add(new DiamondViewModel(d.DiamondId, d.Name, d.Quality, d.Price));
                });
            }
        }
        private void SaveDiamondsToDatabase()
        {
            dataLayer.DropTableDiamonds();
            foreach (DiamondViewModel d in Diamonds)
            {
                dataLayer.AddDiamond(d.Id, d.Name, d.Price, d.Quality);
            }
        }
    }
}
