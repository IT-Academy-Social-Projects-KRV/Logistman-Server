namespace Core.DTO
{
    public class CreateCarDTO
    {
        public string Model { get; set; }
        public string RegistrationNumber { get; set; }
        public string TechnicalPassport { get; set; }
        public float LoadCapacity { get; set; }
        public string Color { get; set; }
        public string Vin { get; set; }
        public string CategoryName { get; set; }
    }
}
