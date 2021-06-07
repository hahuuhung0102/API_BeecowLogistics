using System;
using System.Collections.Generic;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            VehicleRoutes = new HashSet<VehicleRoute>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string WorkingDays { get; set; }
        public Guid? StationId { get; set; }
        public int? Status { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime LastSavedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Station Station { get; set; }
        public virtual ICollection<VehicleRoute> VehicleRoutes { get; set; }
    }
}
