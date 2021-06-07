using System;
using System.Collections.Generic;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class ChildRoute
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public int? Length { get; set; }
        public int? Status { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime? LastSavedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime? CreatedTime { get; set; }
    }
}
