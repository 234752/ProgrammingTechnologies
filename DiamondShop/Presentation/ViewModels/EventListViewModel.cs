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
    public class EventListViewModel : BaseViewModel
    {
        private IDataModel model = new DataModel();
        private ObservableCollection<EventViewModel> _Events = new ObservableCollection<EventViewModel>();
        private EventViewModel _CurrentEvent;
        private ICommand _RemoveEventCommand;
        private ICommand _AddEventCommand;
        private ICommand _SaveEventsCommand;
        private AbstractDataAPI dataLayer;

        public EventListViewModel()
        {
            _Events = new ObservableCollection<EventViewModel>();
            dataLayer = AbstractDataAPI.createLayer();

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
            Events.Add(new EventViewModel() { Id = 0, CatalogId = 0, Date = "", IsDelivery = true});
            CurrentEvent = Events.Last();
        }
        public void SaveEvents()
        {
            Task.Run(() => SaveEventsToDatabase());
        }
        private void FetchEventsFromDatabase()
        {
            App.Current.Dispatcher.Invoke((Action)delegate
            {
                _Events.Clear();
            });
            List<IEvent> fetchedEvents = dataLayer.GetEvents();
            foreach (IEvent e in fetchedEvents)
            {
                App.Current.Dispatcher.Invoke((Action)delegate
                {
                    _Events.Add(new EventViewModel(e.EventId, e.Date, Boolean.Parse(e.IsDelivery), e.DiamondId));
                });
            }
        }
        private void SaveEventsToDatabase()
        {
            dataLayer.DropTableEvents();
            foreach (EventViewModel e in Events)
            {
                dataLayer.AddEvent(e.Id, e.Date, e.IsDelivery.ToString(), e.CatalogId, e.CatalogId);
            }
        }
    }
}
