using System;
using Core.Entities.TripEntity;
using Core.Entities.UserEntity;

namespace Core.Entities.ReportEntity
{
    public class Report
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset ReportingDate { get; set; }
        public int TripId { get; set; }
        public Trip Trip { get; set; }
        public string ReportedUserId { get; set; }
        public User ReportedUser { get; set; }
        public string ReporterUserId { get; set; }
        public User ReporterUser { get; set; }
    }
}
