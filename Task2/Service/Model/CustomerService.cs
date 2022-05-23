using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.API;
using Service.API;

namespace Service.Model
{
    public class CustomerService //: ICustomerService
    {
        private readonly IDataAPI _dataRepository;

        public CustomerService(IDataAPI dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public CustomerService()
        {
            _dataRepository = IDataAPI.CreateLayer();
        }

        private static ICustomerData Transform(ICustomer customer)
        {
            return customer == null ? null : new CustomerData(customer.CustomerId);
        }

        public ICustomerData GetCustomer(int custId)
        {
            return Transform(_dataRepository.GetCustomer(custId));
        }

        public bool AddCustomer(int Id, string Name, string Surname)
        {
            return _dataRepository.AddCustomer(Id, Name,Surname);
        }

        public bool UpdateCustomer(int Id, string Name, string Surname)
        {
            return _dataRepository.UpdateCustomer(Id, Name, Surname);
        }

        public bool DeleteCustomer(int custId)
        {
            return _dataRepository.DeleteCustomer(custId);
        }
    }
}
