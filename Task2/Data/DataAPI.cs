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
        
        IDiamond Transform(Diamonds diamond);
        ICustomer Transform(Customers customer);
        IEvent Transform(Events ev); //tu ma z czymś problem nie wiem o co mu chodzi :((
        // a to wszystko dalej psuje...


        // CRUD DECLARATION
        #region Diamond

        IDiamond GetDiamond(int diamondId); 
        bool AddDiamond(int diamondId, decimal price, string quality);
        bool UpdateDiamond(int diamondId, decimal price, string quality);
        bool DeleteDiamond(int diamondId);

        #endregion
      
        #region Customer

        ICustomer GetCustomer(int Id);
        bool AddCustomer(int Id, string Name,string surname);
        bool UpdateCustomer(int Id, string Name, string surname);
        bool DeleteCustomer(int Id);

        #endregion

        #region Event

        IEvent GetEvent(int eventId);
        bool AddEvent(int eventId, string Date,string Isdelivered, int catalogId,int customId );
        bool UpdateEvent(int eventId, string Date, string Isdelivered, int catalogId, int customId);
        bool DeleteEvent(int eventId);

        #endregion

    }
}
