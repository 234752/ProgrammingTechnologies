using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;
using Data.Model;

namespace Data
{
    public interface IDataAPI
    {
        IDiamond Transform(Diamond diamond);
        ICustomer Transform(Customer customer);
       // IEvent Transform(Event event); nw w czym on ma problem??

        // CRUD DECLARATION
        #region Diamond

        IDiamond GetDiamond(int diamondId); 
        bool AddDiamond(int diamondId, decimal price, string quality);
        bool UpdateDiamond(int diamondId, decimal price, string quality);
        bool DeleteDiamond(int diamondId);

        #endregion
      
        #region Customer

        ICustomer GetCustomer(int Id);
        bool AddCustomer(int Id, string Name);
        bool UpdateCustomer(int Id, string Name);
        bool DeleteCustomer(int Id);

        #endregion

        #region Event

        IEvent GetEvent(int eventId);
        bool AddEvent(int eventId);
        bool AddEvent(int eventId, string Date, int catalogId);
        bool UpdateEvent(int eventId, string Date, int catalogId);
        bool DeleteEvent(int eventId);

        #endregion

    }
}
