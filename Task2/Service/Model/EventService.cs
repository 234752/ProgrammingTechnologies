using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.API;
using Data.Model;
using Service;
using Service.API;


namespace Service.Model
{
    internal class EventService
    {
        private readonly DataRepository _dataRepository;

        public EventService(DataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        private static IEventData Transform(IEvent @event)
        {
            return @event == null ? null : new EventData(@event.EventId);
        }

        public IEventData GetEvent(int eventId)
        {
            return Transform(_dataRepository.GetEvent(eventId));
        }

        public bool AddEvent(int eventId)
        {
            return _dataRepository.AddEvent(eventId);
        }

        public bool AddEvent(int eventId, string Date, bool Isdelivered, int catalogId, int customId)
        {
            return _dataRepository.AddEvent(eventId, Date, Isdelivered, catalogId, customId);
        }

        public bool UpdateEvent(int eventId, string Date, bool Isdelivered, int catalogId, int customId)
        {
            return _dataRepository.UpdateEvent(eventId,Date,Isdelivered,catalogId, customId);
        }

        public bool DeleteEvent(int eventId)
        {
            return _dataRepository.DeleteEvent(eventId);
        }
    }
}
