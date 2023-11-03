using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IteratorNew.Core.Entities;
using IteratorNew.Proxies;

namespace IteratorNew.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetBlockedCustomers()
        {
            return new List<Customer>
            {
                new Customer("Ivo", DateTime.Now.AddYears(-20), "ivo1@mail.com.br"),
                new Customer("Cacau", DateTime.Now.AddYears(-30), "ivo2@mail.com.br"),
                new Customer("Maria Eduarda", DateTime.Now.AddYears(-10), "ivo3@mail.com.br"),
                new Customer("Lucas", DateTime.Now.AddYears(-5), "ivo4@mail.com.br")
            };
        }

        public Customer GetCustomerById(Guid id)
        {
            return new Customer("Maria Gonçalves", DateTime.Now.AddYears(-50), "mariag@mail.com");
        }
    }
}