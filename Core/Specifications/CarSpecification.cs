using Ardalis.Specification;
using Core.Entities.CarEntity;

namespace Core.Specifications
{
    public static class CarSpecification
    {
        internal class GetWithMainCredentials: Specification<Car>
        {
            public GetWithMainCredentials(string registrationNumber, string vin, string technicalPassport)
            {
                Query.Where(c =>
                            c.RegistrationNumber.Equals(registrationNumber) ||
                            c.Vin.Equals(vin) ||
                            c.TechnicalPassport.Equals(technicalPassport));
            }
        }
    }
}
