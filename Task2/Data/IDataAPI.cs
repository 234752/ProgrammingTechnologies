using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;
using Data.Model;

namespace Data
{
    public abstract class IDataAPI
    {

        public static IDataAPI CreateLayer(string sqlString)
        {
            return new DataRepository(sqlString);
        }
        public static IDataAPI CreateLayer()
        {
            return new DataRepository();
        }
        public abstract IDiamond Transform(Diamonds diamond);
        public abstract ICustomer Transform(Customers customer);
        public abstract IEvent Transform(Events ev); //tu ma z czymś problem nie wiem o co mu chodzi :((
        // a to wszystko dalej psuje...


        // CRUD DECLARATION
        #region Diamond

        public abstract IDiamond GetDiamond(int diamondId);
        public abstract bool AddDiamond(int diamondId, decimal price, string quality, string name);
        public abstract bool UpdateDiamond(int diamondId, decimal price, string quality, string name);
        public abstract bool DeleteDiamond(int diamondId);

        #endregion

        #region Customer

        public abstract ICustomer GetCustomer(int Id);
        public abstract bool AddCustomer(int Id, string Name, string surname);
        public abstract bool UpdateCustomer(int Id, string Name, string surname);
        public abstract bool DeleteCustomer(int Id);

        #endregion

        #region Event

        public abstract IEvent GetEvent(int eventId);
        public abstract bool AddEvent(int eventId, string Date, string Isdelivered, int catalogId, int customId);
        public abstract bool UpdateEvent(int eventId, string Date, string Isdelivered, int catalogId, int customId);
        public abstract bool DeleteEvent(int eventId);

        #endregion

        public class DataRepository : IDataAPI
        {
            private LINQtoSQLDataContext context;
           

            public DataRepository(string sqlString)
            {
                context = new LINQtoSQLDataContext(sqlString);
            }
          
            public DataRepository()
            {
                context = new LINQtoSQLDataContext("Data Source=LAPTOP-6CIA6OPN;Initial Catalog=DiamondShop;Integrated Security=True"); 
            }
            

            public override IDiamond Transform(Diamonds diamond)
            {
                return new Diamond(diamond.id, diamond.price, diamond.quality, diamond.name);
            }
            public override ICustomer Transform(Customers customer)
            {
                return new Customer(customer.id, customer.first_name, customer.last_name);
            }

            public override IEvent Transform(Events ev)
            {
                return new Event(ev.id, ev.date, ev.isdelivered, ev.catalogid, ev.customerid);
            }

            // CRUD implementation
            #region Diamond

            public override IDiamond GetDiamond(int diamondId)
            {
                var diamondDatabase = (from diamond in context.Diamonds where diamond.id == diamondId select diamond).FirstOrDefault();
                return diamondDatabase != null ? Transform(diamondDatabase) : null;
            }
            public override bool AddDiamond(int diamondId, decimal price, string quality, string name)
            {
                if (GetDiamond(diamondId) != null) return false;
                var newReader = new Diamonds
                {
                    id = diamondId,
                    price = price,
                    quality = quality,
                    name=name
                };
                context.Diamonds.InsertOnSubmit(newReader);
                context.SubmitChanges();
                return true;
            }
            public override bool UpdateDiamond(int diamondId, decimal price, string quality, string name)
            {
                var diam = context.Diamonds.SingleOrDefault(d => d.id == diamondId);
                if (diam == null) return false;
                diam.id = diamondId;
                diam.price = price;
                diam.quality = quality;
                diam.name = name;
                context.SubmitChanges();
                return true;

            }
            public override bool DeleteDiamond(int diamondId)
            {
                var diamond = context.Diamonds.SingleOrDefault(d => d.id == diamondId);
                if (diamond == null) return false;
                context.Diamonds.DeleteOnSubmit(diamond);
                context.SubmitChanges();
                return true;
            }

            #endregion

            #region Customer

            public override ICustomer GetCustomer(int Id)
            {
                var customerDatabase = (from customer in context.Customers where customer.id == Id select customer).FirstOrDefault();
                return customerDatabase != null ? Transform(customerDatabase) : null;
            }
            public override bool AddCustomer(int Id, string Name, string Surname)
            {
                if (GetCustomer(Id) != null) return false;
                var newReader = new Customers
                {
                    id = Id,
                    first_name = Name,
                    last_name = Surname

                };
                context.Customers.InsertOnSubmit(newReader);
                context.SubmitChanges();
                return true;
            }
            public override bool UpdateCustomer(int Id, string Name, string Surname)
            {
                var customer = context.Customers.SingleOrDefault(cust => cust.id == Id);
                if (customer == null) return false;
                customer.id = Id;
                customer.first_name = Name;
                customer.last_name = Surname;
                context.SubmitChanges();
                return true;
            }
            public override bool DeleteCustomer(int Id)
            {
                var customer = context.Customers.SingleOrDefault(cust => cust.id == Id);
                if (customer == null) return false;
                context.Customers.DeleteOnSubmit(customer);
                context.SubmitChanges();
                return true;
            }

            #endregion

            #region Event

            public override IEvent GetEvent(int eventId)
            {
                var evDatabase = (from events in context.Events where events.id == eventId select events).FirstOrDefault();
                return evDatabase != null ? Transform(evDatabase) : null;
            }
            public override bool AddEvent(int eventId, string Date, string IsDelivered, int catalogId, int customId)
            {
                if (GetEvent(eventId) == null) return false;
                var newReader = new Events
                {
                    id = eventId,
                    date = Date,
                    isdelivered = IsDelivered,
                    catalogid = catalogId,
                    customerid = customId
                };
                return true;
            }
            public override bool UpdateEvent(int eventId, string Date, string Isdelivered, int catalogId, int customId)
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

            public override bool DeleteEvent(int eventId)
            {
                var events = context.Events.SingleOrDefault(ev => ev.id == eventId);
                if (events == null) return false;
                context.Events.DeleteOnSubmit(events);
                context.SubmitChanges();
                return true;
            }

            #endregion

        }
    }

    }
