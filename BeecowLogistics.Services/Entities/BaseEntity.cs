using System;
using System.ComponentModel.DataAnnotations;

namespace BeecowLogistics.Services.Entities
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool Status { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime LastSavedTime { get; set; } = DateTime.Now;
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
