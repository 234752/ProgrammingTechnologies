using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public interface ICustomerData
    {
        int CustomerId { get; }
        string Name { get; }
        string Surname { get; }
    }
}
