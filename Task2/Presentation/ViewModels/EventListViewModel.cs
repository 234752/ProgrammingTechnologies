using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models;
using Presentation.ViewModels.MVVMLight;
using Presentation.Models.ModelsAPI;

namespace Presentation.ViewModels
{
    public class EventListViewModel : BaseViewModel
    {
        private DataModel model = new DataModel();
        private ObservableCollection<EventViewModel> _Events = new ObservableCollection<EventViewModel>();
        private EventViewModel _CurrentEvent;

        public EventListViewModel()
        {
            _Events = new ObservableCollection<EventViewModel>();
            foreach (IEventModel ev in model.Events)
            {
                _Events.Add(new EventViewModel(ev.Id, ev.Date, ev.IsDelivery, ev.CatalogId));
            }
        }
        public ObservableCollection<EventViewModel> Events
        {
            get
            {
                return _Events;
            }
            set
            {
                _Events = value;
                RaisePropertyChanged(nameof(Events));
            }
        }
        public EventViewModel CurrentEvent
        {
            get
            {
                return _CurrentEvent;
            }
            set
            {
                _CurrentEvent = value;
                RaisePropertyChanged(nameof(CurrentEvent));
            }
        }
    }
}
