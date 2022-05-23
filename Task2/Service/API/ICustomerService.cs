using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.API
{
    public interface ICustomerService
    {
        ICustomerData GetCustomer(int Id);
        bool AddCustomer(int Id, string Name, string Surname);
        bool UpdateCustomer(int Id, string Name, string Surname);
        bool DeleteCustomer(int Id);
    }
}
