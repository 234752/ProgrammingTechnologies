using Data.Model;
using Data.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class DataRepository //: IDataAPI
    { 
       /* private readonly DataContext context;
        public DataRepository(DataContext data)
        {
           context = data;
        }

    
       public IDiamond Transform(Diamond diamond)
        {
            return new Diamond(diamond.id, diamond.price, diamond.quality );
        }
       public ICustomer Transform(Customer customer)
        {
            return new Customer(customer.id, customer.name);
        }
        public IEvent Transform(Event event);
        {
            return new Event(event.date,event.id,event.isdelivered,event.catalogid);
        } 

        // CRUD implementation
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
        bool DeleteEvent(int eventId); */
    }
}
