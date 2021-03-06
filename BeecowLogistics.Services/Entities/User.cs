using System;
using System.Collections.Generic;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public bool PhoneConfirmed { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public DateTime DoB { get; set; }
        public int? Status { get; set; }
        public bool IsActive { get; set; }
        public Guid? UserTypeId { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime LastSavedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual UserType UserType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
