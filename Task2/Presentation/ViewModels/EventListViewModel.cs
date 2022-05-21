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
    public class EventListViewModel : BaseViewModel
    {
        private IDataModel model = new DataModel();
        private ObservableCollection<EventViewModel> _Events = new ObservableCollection<EventViewModel>();
        private EventViewModel _CurrentEvent;
        private ICommand _RemoveEventCommand;

        public EventListViewModel()
        {
            _Events = new ObservableCollection<EventViewModel>();
            foreach (IEventModel ev in model.Events)
            {
                _Events.Add(new EventViewModel(ev.Id, ev.Date, ev.IsDelivery, ev.CatalogId));
            }
            _RemoveEventCommand = new RelayCommand(() => RemoveEvent());
        }
        public EventListViewModel(IDataModel dataModel)
        {
            if (dataModel != null) model = dataModel;
            _Events = new ObservableCollection<EventViewModel>();
            foreach (IEventModel ev in model.Events)
            {
                _Events.Add(new EventViewModel(ev.Id, ev.Date, ev.IsDelivery, ev.CatalogId));
            }
            _RemoveEventCommand = new RelayCommand(() => RemoveEvent());
        }
        public ObservableCollection<EventViewModel> Events
        { get { return _Events; } set { _Events = value; RaisePropertyChanged(nameof(Events)); } }
        public EventViewModel CurrentEvent
        { get { return _CurrentEvent; } set { _CurrentEvent = value; RaisePropertyChanged(nameof(CurrentEvent)); } }
        public ICommand RemoveEventCommand { get { return _RemoveEventCommand; } }
        public void RemoveEvent()
        {
            Events.Remove(CurrentEvent);
        }
    }
}
