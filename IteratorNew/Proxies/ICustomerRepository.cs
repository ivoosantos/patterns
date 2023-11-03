using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IteratorNew.Controllers;
using IteratorNew.Core.Entities;

namespace IteratorNew.Proxies
{
    public interface ICustomerRepository
    {
        List<Customer> GetBlockedCustomers();
        Customer GetCustomerById(Guid id);
    }
}