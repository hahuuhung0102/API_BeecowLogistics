using System;

namespace BeecowLogistics.Services.Entities
{
    public class Users : BaseEntity
    {
        public string Code { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public bool PhoneConfirmed { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public DateTime? DoB { get; set; }
        public int UserTypeId { get; set; }
    }
}
