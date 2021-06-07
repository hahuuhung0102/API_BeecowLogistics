using System;
using System.Collections.Generic;

#nullable disable

namespace BeecowLogistics.Services.Entities
{
    public partial class StationType
    {
        public StationType()
        {
            Stations = new HashSet<Station>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool? IsActive { get; set; }
        public string LastSavedUser { get; set; }
        public DateTime LastSavedTime { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        public virtual ICollection<Station> Stations { get; set; }
    }
}
