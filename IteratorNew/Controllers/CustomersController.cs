using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IteratorNew.Core.Entities;
using IteratorNew.Infrastructure;
using IteratorNew.Proxies;
using IteratorNew.Models;

namespace IteratorNew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        [Route("report-notify-blocked-customers")]
        public IActionResult NotifyBlockedCustomerEmail([FromServices] ICustomerRepository repository)
        {
            var blockedCustomers = repository.GetBlockedCustomers();
            var query = new CustomersToNotifyQueryModel(blockedCustomers, "ITech");
            foreach (var customer in query)
            {
                Console.WriteLine($"Customer: {customer.Key}, Email: {customer.Value}");
            }
            Console.WriteLine($"Utilizando acesso direto: {query["Ivo"]}");
            return Ok();
        }
    }
}