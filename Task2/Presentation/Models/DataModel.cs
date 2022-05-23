﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Models.ModelsAPI;

namespace Presentation.Models
{
    public class DataModel : IDataModel
    {
        public IList<ICustomerModel> Customers
        {
            get
            {
                List<ICustomerModel> Customers = new List<ICustomerModel>()
                {
                    //new CustomerModel() { Id = 1, FirstName = "Bob", LastName = "Bob's last name" },
                    //new CustomerModel() { Id = 2, FirstName = "Bob2", LastName = "Bob2's last name" },
                    //new CustomerModel() { Id = 3, FirstName = "Bob3", LastName = "Bob3's last name" }
                };
                return Customers;
            }
        }

        public IList<IDiamondModel> Diamonds
        {
            get
            {
                List<IDiamondModel> Diamonds = new List<IDiamondModel>()
                {
                    //new DiamondModel() { Id = 1, Name = "d1", Quality = "q1", Price = 12.12M },
                    //new DiamondModel() { Id = 2, Name = "d2", Quality = "q2", Price = 22.12M },
                    //new DiamondModel() { Id = 3, Name = "d3", Quality = "q3", Price = 32.12M }
                };
                return Diamonds;
            }
        }

        public IList<IEventModel> Events
        {
            get
            {
                List<IEventModel> Events = new List<IEventModel>()
                {
                    //new EventModel() { Id = 1, Date = "11/11/2011", IsDelivery = true, CatalogId = 1 },
                    //new EventModel() { Id = 2, Date = "22/22/2022", IsDelivery = false, CatalogId = 2 },
                    //new EventModel() { Id = 3, Date = "33/33/2033", IsDelivery = true, CatalogId = 3 }
                };
                return Events;
            }
        }
    }
}
