using Data.Model;
using Data.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data
{
    public class DataRepository 
    {
        private readonly LINQtoSQLDataContext context;
        public DataRepository(LINQtoSQLDataContext data)
        {
            context = data;
        }


        public IDiamond Transform(Diamonds diamond)
        {
            return new Diamond(diamond.id, diamond.price, diamond.quality);
        }
        public ICustomer Transform(Customers customer)
        {
            return new Customer(customer.id, customer.first_name, customer.last_name);
        }
       
        public IEvent Transform(Events ev)
        {
            return new Event(ev.id,ev.date,ev.isdelivered,ev.catalogid,ev.customerid);
        }

        // CRUD implementation
        #region Diamond

        public IDiamond GetDiamond(int diamondId)
        {
            var diamondDatabase = (from diamond in context.Diamonds where diamond.id == diamondId select diamond).FirstOrDefault();
            return diamondDatabase != null ? Transform(diamondDatabase) : null;
        }
        public bool AddDiamond(int diamondId, decimal price, string quality)
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
        public bool UpdateDiamond(int diamondId, decimal price, string quality)
        {
            var diam = context.Diamonds.SingleOrDefault(d => d.id == diamondId);
            if (diam == null) return false;
            diam.id = diamondId;
            diam.price = price;
            diam.quality = quality;
            context.SubmitChanges();
            return true;

        }
        public bool DeleteDiamond(int diamondId)
        {
            var diamond = context.Diamonds.SingleOrDefault(d => d.id == diamondId);
            if (diamond == null) return false;
            context.Diamonds.DeleteOnSubmit(diamond);
            context.SubmitChanges();
            return true;
        }

        #endregion

        #region Customer

       public ICustomer GetCustomer(int Id)
        {
            var customerDatabase = (from customer in context.Customers where customer.id == Id select customer).FirstOrDefault();
            return customerDatabase != null ? Transform(customerDatabase) : null;
        }
        public bool AddCustomer(int Id, string Name)
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
        public bool UpdateCustomer(int Id, string Name)
        {
            var customer = context.Customers.SingleOrDefault(cust => cust.id == Id);
            if (customer == null) return false;
            customer.id = Id;
            customer.first_name = Name;
            context.SubmitChanges();
            return true;
        }
        public bool DeleteCustomer(int Id)
        {
            var customer = context.Customers.SingleOrDefault(cust => cust.id == Id);
            if (customer == null) return false;
            context.Customers.DeleteOnSubmit(customer);
            context.SubmitChanges();
            return true;
        }

        #endregion

        #region Event

         public IEvent GetEvent(int eventId)
         {
            var evDatabase = (from events in context.Events where events.id == eventId select events).FirstOrDefault();
            return evDatabase != null ? Transform(evDatabase) : null;
          }
        public bool AddEvent(int eventId, string Date, string IsDelivered, int catalogId, int customId)
        {
            if (GetEvent(eventId) == null) return false;
            var newReader = new Events
            {
                id= eventId,
                date= Date,
                isdelivered= IsDelivered,
                catalogid= catalogId,
                customerid=customId
            };
            return true;
        }
        public bool UpdateEvent(int eventId, string Date, string Isdelivered, int catalogId, int customId)
        {
            var ev = context.Events.SingleOrDefault(evt => evt.id == eventId);
            if (ev == null) return false;
            ev.id = eventId;
            ev.date = Date;
            ev.isdelivered = Isdelivered;
            ev.customerid = customId;
            ev.catalogid = catalogId;
            context.SubmitChanges();
            return true;
        }

        public bool DeleteEvent(int eventId)
        {
            var events = context.Events.SingleOrDefault(ev => ev.id == eventId);
            if (events == null) return false;
            context.Events.DeleteOnSubmit(events);
            context.SubmitChanges();
            return true;
        }
        /*public bool AddEvent(int eventId, string Date, bool Isdelivered, int catalogId, int customId)
        {
            if (GetEvent(eventId) != null) return false;
            var newReader = new Events
            {
                id = eventId;
            date = Date;
            isdelivered = Isdelivered;
            customerid = customId;
            catalogid = catalogId;
        }
        context.Events.InsertOnSubmit(newReader);
            context.SubmitChanges();
            return true;
         } */
        #endregion

    }
}
