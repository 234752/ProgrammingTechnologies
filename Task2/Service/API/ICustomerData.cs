using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public abstract class ICustomerData
    {
        public int CustomerId { get; }
        public string Name { get; }
    }
}
