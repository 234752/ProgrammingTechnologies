using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.API;
using Data.Model;

namespace Data
{
    public abstract class DataAPI
    {
       // public abstract void Connect();
       

       // public static DataAPI CreateData()
        //{
           // DataContext data = new DataContext();
            //  return new DataRepository(data);
        //}



       // public abstract Event CreateEvent();
        //public abstract Event GetEvent(int Id);

       // public abstract Event GetEvent();

       // public abstract void DeleteEvent();


        public abstract void Diamond(string quality, decimal price);

        public abstract Diamond GetDiamond(int id);

       // public abstract void UpdateProduct();

        //public abstract void DeleteProduct(int id);

        public abstract ICustomer CreateCustomer(string name, int Id);
        public abstract ICustomer GetCustomer(int Id);
        public abstract ICustomer GetCustomer(string name);

        public abstract void UpdateCustomer(int Id, string name);

        public abstract void DeleteCustomer(int Id);
    }
}
