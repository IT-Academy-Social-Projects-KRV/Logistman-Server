using Ardalis.Specification;
using Core.Entities.CarEntity;

namespace Core.Specifications
{
    public class GetCarWithMainCredentials : Specification<Car>
    {
        public GetCarWithMainCredentials(string registrationNumber, string vin, string technicalPassport)
        {
            Query.Where(c => 
            c.RegistrationNumber.Equals(registrationNumber) || 
            c.Vin.Equals(vin) || 
            c.TechnicalPassport.Equals(technicalPassport));
        }
    }
}
