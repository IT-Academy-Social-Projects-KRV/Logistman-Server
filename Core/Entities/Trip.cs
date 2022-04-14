using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Trip
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool Ended { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public  virtual ICollection<Report> Reports { get; set; }
        public virtual ICollection<UserTrip> UserTrips { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }

    }
}