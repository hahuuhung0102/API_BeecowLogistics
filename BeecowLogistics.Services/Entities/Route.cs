using System;
using System.Collections.Generic;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class Route
    {
        public Route()
        {
            Orders = new HashSet<Order>();
            VehicleRoutes = new HashSet<VehicleRoute>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string RouteName { get; set; }
        public string Routing { get; set; }
        public string ChildRoutes { get; set; }
        public Guid? ShippingFeeId { get; set; }
        public DateTime? TimeStart { get; set; }
        public DateTime? TimeEnd { get; set; }
        public int? Status { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime LastSavedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ShippingFee ShippingFee { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<VehicleRoute> VehicleRoutes { get; set; }
    }
}
