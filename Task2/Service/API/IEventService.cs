using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public interface IEventService
    {
        IEventData GetEvent(int eventId);
        bool AddEvent(int eventId, string Date, string Isdelivered, int catalogId, int customId);
        bool UpdateEvent(int eventId, string Date, string Isdelivered, int catalogId, int customId);
        bool DeleteEvent(int eventId);
    }
}
