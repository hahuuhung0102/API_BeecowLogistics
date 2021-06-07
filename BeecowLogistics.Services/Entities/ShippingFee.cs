using System;
using System.Collections.Generic;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class ShippingFee
    {
        public ShippingFee()
        {
            Routes = new HashSet<Route>();
            ShippingFeeDetails = new HashSet<ShippingFeeDetail>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int? Status { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime LastSavedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Route> Routes { get; set; }
        public virtual ICollection<ShippingFeeDetail> ShippingFeeDetails { get; set; }
    }
}
