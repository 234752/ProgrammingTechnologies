using Data.Model;
using Data.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class DataRepository : IDataAPI
    { 
       private readonly LINQtoSQLDataContext context;
        public DataRepository(LINQtoSQLDataContext data)
        {
           context = data;
        }

    
       public IDiamond Transform(Diamonds diamond)
        {
            return new Diamond(diamond.price, diamond.quality, diamond.id);
        }
       public ICustomer Transform(Customers customer)
        {
            return new Customer(customer.id, customer.first_name);
        }
       /* public IEvent Transform(Events event);
        {
            return new Event(event.date,event.id,event.isdelivered,event.catalogid,event.customerid);
        }  */

        // CRUD implementation
        #region Diamond

        IDiamond GetDiamond(int diamondId)
        {
            var diamondDatabase = (from diamond in context.Diamonds where diamond.id == diamondId select diamond).FirstOrDefault();
            return diamondDatabase != null ? Transform(diamondDatabase) : null;
        }
        bool AddDiamond(int diamondId, decimal price, string quality)
        {
            if (GetDiamond(diamondId) != null) return false;
            var newReader = new Diamonds
            {
                id = diamondId,
                price = price,
                quality = quality
            };
            context.Diamonds.InsertOnSubmit(newReader);
            context.SubmitChanges();
            return true;
        }
        bool UpdateDiamond(int diamondId, decimal price, string quality)
        {
            var diamond = context.Diamonds.SingleOrDefault(diamond => diamond.id == diamondId);
            if (diamond == null) return false;
            diamond.id = diamondId;
            diamond.price = price;
            diamond.quality = quality;
            context.SubmitChanges();
            return true;

        }
        bool DeleteDiamond(int diamondId)
        {
            var diamond = context.Diamonds.SingleOrDefault(diamond => diamond.id == diamondId);
            if (diamond == null) return false;
            context.Diamonds.DeleteOnSubmit(diamond);
            context.SubmitChanges();
            return true;
        }

        #endregion

        #region Customer

        ICustomer GetCustomer(int Id)
        {
            var customerDatabase = (from customer in context.Customers where customer.id == Id select customer).FirstOrDefault();
            return customerDatabase != null ? Transform(customerDatabase) : null;
        }
        bool AddCustomer(int Id, string Name)
        {
            if (GetCustomer(Id) != null) return false;
            var newReader = new Customers
            {
                id = Id,
                first_name = Name
              
            };
            context.Customers.InsertOnSubmit(newReader);
            context.SubmitChanges();
            return true;
        }
        bool UpdateCustomer(int Id, string Name)
        {
            var customer = context.Customers.SingleOrDefault(customer => customer.id == Id);
            if (customer == null) return false;
            customer.id = Id;
            customer.first_name = Name;
            context.SubmitChanges();
            return true;
        }
        bool DeleteCustomer(int Id)
        {
            var customer = context.Customers.SingleOrDefault(customer => customer.id == Id);
            if (customer == null) return false;
            context.Customers.DeleteOnSubmit(customer);
            context.SubmitChanges();
            return true;
        }

        #endregion

       /* #region Event


        public IEvent GetEvent(int eventId)
        {
            var eventDatabase = (from events in context.Events where events.id == eventId select events).FirstOrDefault();
            return eventDatabase != null ? Transform(eventDatabase) : null;
        }

        public bool AddEvent(int eventId)
        {
            if (GetEvent(eventId) != null) return false;
            var newReader = new Events
            {
                id = eventId
            };
            context.Events.InsertOnSubmit(newReader);
            context.SubmitChanges();
            return true;
        }

        public bool AddEvent(int eventId, string Date, bool Isdelivered, int catalogId, int customId)
        {
            if (GetEvent(eventId) != null) return false;
            var newReader = new Events
            {
            id = eventId;
            date = Date;
            isdelivered = Isdelivered;
            customerid = customId;
            catalogid = catalogId;
             }; 

            context.Events.InsertOnSubmit(newReader);
            context.SubmitChanges();
            return true;
        }

        public bool UpdateEvent(int eventId, string Date,bool Isdelivered int catalogId,int customId )
        {
            var events = context.Events.SingleOrDefault(events => events.id == eventId);
            if (events == null) return false;
            events.id = eventId;
            events.date = Date;
            events.isdelivered = Isdelivered;
            events.customerid = customId;
            events.catalogid = catalogId;
            context.SubmitChanges();
            return true;
        }

        public bool DeleteEvent(int eventId)
        {
            var events = context.Events.SingleOrDefault(events => events.id == eventId);
            if (events == null) return false;
            context.Events.DeleteOnSubmit(events);
            context.SubmitChanges();
            return true;
        }

        #endregion */
    }
}
