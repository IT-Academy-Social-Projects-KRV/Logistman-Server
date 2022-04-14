namespace Core.Entities
{
    public class Point
    {
        public int Id { get; set; }
        public float Latitude { get; set; }
        public float Longtitude { get; set; }
        public string Address { get; set; }
        public string Region { get; set; }
        public string Settlement { get; set; }
        public int Order { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
        public int ParticipantRoleId { get; set; }
        public ParticipantRole ParticipantRole { get; set; }

    }
}