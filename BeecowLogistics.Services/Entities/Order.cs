using System;
using System.Collections.Generic;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class Order
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public Guid? UserId { get; set; }
        public string SenderName { get; set; }
        public string SenderPhone { get; set; }
        public string SenderAddress { get; set; }
        public string SenderCity { get; set; }
        public string SenderDistrict { get; set; }
        public string SenderWard { get; set; }
        public string SenderStreet { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverPhone { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverCity { get; set; }
        public string ReceiverDistrict { get; set; }
        public string ReceiverWard { get; set; }
        public string ReceiverStreet { get; set; }
        public Guid PackageTypeId { get; set; }
        public Guid? SpecialOptionId { get; set; }
        public double? PackageLength { get; set; }
        public double? PackageWidth { get; set; }
        public double? PackageHeight { get; set; }
        public double? PackageWeight { get; set; }
        public string Descriptions { get; set; }
        public Guid DeliveryId { get; set; }
        public bool IsForRent { get; set; }
        public Guid? StationForRentId { get; set; }
        public Guid RouteId { get; set; }
        public string PayBy { get; set; }
        public Guid PaymentTypeId { get; set; }
        public bool IsCod { get; set; }
        public decimal Codamount { get; set; }
        public decimal Codfee { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal Tax { get; set; }
        public decimal TotalFee { get; set; }
        public Guid StationId { get; set; }
        public string CurrentPosition { get; set; }
        public int Status { get; set; }
        public bool? IsActive { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime LastSavedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual Delivery Delivery { get; set; }
        public virtual PackageType PackageType { get; set; }
        public virtual PaymentType PaymentType { get; set; }
        public virtual Route Route { get; set; }
        public virtual SpecialOption SpecialOption { get; set; }
        public virtual Station Station { get; set; }
        public virtual Station StationForRent { get; set; }
        public virtual User User { get; set; }
    }
}
