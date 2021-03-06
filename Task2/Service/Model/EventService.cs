using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.API;
using Service.API;


namespace Service.Model
{
    public class EventService : IEventService
    {
        private readonly AbstractDataAPI _dataRepository;

        public EventService(AbstractDataAPI dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public EventService()
        {
            _dataRepository = AbstractDataAPI.CreateLayer();
        }

        private static IEventData Transform(IEvent @event)
        {
            return @event == null ? null : new EventData(@event.EventId,@event.Date,@event.IsDelivery,@event.CatalogId, @event.CustomerId);
        }

        public IEventData GetEvent(int eventId)
        {
            return Transform(_dataRepository.GetEvent(eventId));
        }

    

        public bool AddEvent(int eventId, string Date, string Isdelivered, int catalogId, int customId)
        {
            return _dataRepository.AddEvent(eventId, Date, Isdelivered, catalogId, customId);
        }

        public bool UpdateEvent(int eventId, string Date, string Isdelivered, int catalogId, int customId)
        {
            return _dataRepository.UpdateEvent(eventId,Date,Isdelivered,catalogId, customId);
        }

        public bool DeleteEvent(int eventId)
        {
            return _dataRepository.DeleteEvent(eventId);
        }
    }
}
