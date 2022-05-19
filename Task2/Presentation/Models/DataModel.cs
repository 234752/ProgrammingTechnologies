using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class DataModel
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

        public IEnumerable<DiamondModel> Diamonds
        {
            get
            {
                List<DiamondModel> Diamonds = new List<DiamondModel>()
                {
                    new DiamondModel() { Id = 1, Name = "d1", Quality = "q1", Price = 12.12M },
                    new DiamondModel() { Id = 2, Name = "d2", Quality = "q2", Price = 22.12M },
                    new DiamondModel() { Id = 3, Name = "d3", Quality = "q3", Price = 32.12M }
                };
                return Diamonds;
            }
        }
    }
}
