using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace IteratorNew.Core.Entities
{
    public class Customer
    {
        public Customer(string fullName, DateTime birthDate, string email)
        {
            Id = Guid.NewGuid();
            FullName = fullName;
            BirthDate = birthDate;
            Email = email;
        }

        public Guid Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public CustomerStatus Status { get; set; }
        public string Email { get; set; }

        public bool IsAllowedToBuy()
        {
            return Status != CustomerStatus.Blocked;
        }
    }

    public enum CustomerStatus
    {
        Active = 1,
        Blocked = 2,
        Restricted = 3,
        Cancelled = 4
    }
}