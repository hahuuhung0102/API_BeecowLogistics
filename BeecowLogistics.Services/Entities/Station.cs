﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class Station
    {
        public Station()
        {
            OrderStationForRents = new HashSet<Order>();
            OrderStations = new HashSet<Order>();
            Vehicles = new HashSet<Vehicle>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string Address { get; set; }
        public Guid? StationTypeId { get; set; }
        public bool? IsForRent { get; set; }
        public int? Status { get; set; }
        public bool? IsActive { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime LastSavedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual StationType StationType { get; set; }
        public virtual ICollection<Order> OrderStationForRents { get; set; }
        public virtual ICollection<Order> OrderStations { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
