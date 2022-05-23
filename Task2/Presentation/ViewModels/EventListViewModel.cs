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
using Service.Model;

namespace Presentation.ViewModels
{
    public class EventListViewModel : BaseViewModel
    {
        private IDataModel model = new DataModel();
        private ObservableCollection<EventViewModel> _Events = new ObservableCollection<EventViewModel>();
        private EventViewModel _CurrentEvent;
        private ICommand _RemoveEventCommand;
        private ICommand _AddEventCommand;
        private int _NextEventId = 0;
        private ICommand _SaveEventsCommand;
        private EventService _Service;

        public EventListViewModel()
        {
            _Events = new ObservableCollection<EventViewModel>();
            _Service = new EventService();

            Task.Run(() => FetchEventsFromDatabase());

            _RemoveEventCommand = new RelayCommand(() => RemoveEvent());
            _AddEventCommand = new RelayCommand(() => AddEvent());
            _SaveEventsCommand = new RelayCommand(() => SaveEvents());
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
            _AddEventCommand = new RelayCommand(() => AddEvent());
            _SaveEventsCommand = new RelayCommand(() => SaveEvents());

        }
        public ObservableCollection<EventViewModel> Events
        { get { return _Events; } set { _Events = value; RaisePropertyChanged(nameof(Events)); } }
        public EventViewModel CurrentEvent
        { get { return _CurrentEvent; } set { _CurrentEvent = value; RaisePropertyChanged(nameof(CurrentEvent)); } }
        public ICommand RemoveEventCommand { get { return _RemoveEventCommand; } }
        public ICommand AddEventCommand { get { return _AddEventCommand; } }
        public ICommand SaveEventsCommand { get { return _SaveEventsCommand; } }
        public void RemoveEvent()
        {
            Events.Remove(CurrentEvent);
        }
        public void AddEvent()
        {
            Events.Add(new EventViewModel() { Id = _NextEventId, CatalogId = 0, Date = "", IsDelivery = true});
            CurrentEvent = Events.Last();
            _NextEventId++;
        }
        public void SaveEvents()
        {
            Task.Run(() => SaveEventsToDatabase());
        }
        private void FetchEventsFromDatabase()
        {
            _NextEventId = 0;
            for (int i = 0; _Service.GetEvent(i) != null; i++)
            {
                _Events.Add(new EventViewModel(_NextEventId, _Service.GetEvent(i).Date, Boolean.Parse(_Service.GetEvent(i).IsDelivery), _Service.GetEvent(i).CatalogId));
                _NextEventId++;
            }
        }
        private void SaveEventsToDatabase()
        {
            foreach (EventViewModel e in Events)
            {
                _Service.UpdateEvent(e.Id, e.Date, e.IsDelivery.ToString(), e.CatalogId, e.CatalogId);
            }
        }
    }
}
