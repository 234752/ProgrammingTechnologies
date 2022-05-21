using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.API;

namespace Service.Model
{
    public class CustomerData :ICustomerData
    {
        public int CustomerId { get; }
        public string Name { get; set; }

        public CustomerData(int id, string name)
        {
            CustomerId = id;
            Name = name;
        }
    }
}
