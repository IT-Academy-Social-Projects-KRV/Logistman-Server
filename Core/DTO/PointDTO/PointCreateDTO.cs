namespace Core.DTO.PointDTO
{
    public class PointCreateDTO
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Address { get; set; }
        public string Settlement { get; set; }
        public string Region { get; set; }
        public int Order { get; set; }
    }
}
