using System;
using System.Collections.Generic;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class ShippingFeeDetail
    {
        public Guid Id { get; set; }
        public Guid ShippingFeeId { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Additional { get; set; }
        public string UnitPrice { get; set; }
        public decimal Price { get; set; }
        public int? Status { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime LastSavedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ShippingFee ShippingFee { get; set; }
    }
}
