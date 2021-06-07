using System;
using System.Collections.Generic;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class VehicleRoute
    {
        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public Guid RouteId { get; set; }
        public int? Status { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime LastSavedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Route Route { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
