using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models
{
    internal class DataModel
    {
        public IEnumerable<CustomerModel> Customers
        {
            get
            {
                List<CustomerModel> Customers = new List<CustomerModel>()
                {
                    new CustomerModel() { Id = 1, FirstName = "Bob", LastName = "Bob's last name" },
                    new CustomerModel() { Id = 2, FirstName = "Bob2", LastName = "Bob2's last name" },
                    new CustomerModel() { Id = 3, FirstName = "Bob3", LastName = "Bob3's last name" }
                };
                return Customers;
            }
        }
    }
}
