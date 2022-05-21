﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.API;
using Service.API;

namespace Service.Model
{
    internal class CustomerService : ICustomerService
    {
        private readonly DataRepository _dataRepository;

        public CustomerService(DataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        private static ICustomerData Transform(ICustomer customer)
        {
            return customer == null ? null : new CustomerData(customer.CustomerId);
        }

        public ICustomerData GetCustomer(int custId)
        {
            return Transform(_dataRepository.GetCustomer(custId));
        }

        public bool AddCustomer(int Id, string Name)
        {
            return _dataRepository.AddCustomer(Id, Name);
        }

        public bool UpdateCustomer(int Id, string Name)
        {
            return _dataRepository.UpdateCustomer(Id, Name);
        }

        public bool DeleteCustomer(int custId)
        {
            return _dataRepository.DeleteCustomer(custId);
        }
    }
}
