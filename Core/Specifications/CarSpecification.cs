using Ardalis.Specification;
using Core.DTO;
using Core.Entities.CarEntity;

namespace Core.Specifications
{
    public static class CarSpecification
    {
        internal class GetWithMainCredentials : Specification<Car>
        {
            public GetWithMainCredentials(string registrationNumber, string vin, string technicalPassport)
            {
                Query.Where(c =>
                            (c.RegistrationNumber.Equals(registrationNumber) ||
                            c.Vin.Equals(vin) ||
                            c.TechnicalPassport.Equals(technicalPassport)) &&
                            c.UserId != null);
            }
        }

        internal class GetWithVin : Specification<Car>, ISingleResultSpecification<Car>
        {
            public GetWithVin(string vin)
            {
                Query.Where(c => c.Vin.Equals(vin));
            }
        }

        internal class GetByUserId : Specification<Car>
        {
            public GetByUserId(string userId, PaginationFilterDTO paginationFilter)
            {
                Query
                    .Where(c => c.UserId == userId)
                    .Include(c => c.Category)
                    .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                    .Take(paginationFilter.PageSize);
            }
        }

        internal class GetByIds : Specification<Car>, ISingleResultSpecification<Car>
        {
            public GetByIds(int carId, string userId)
            {
                Query.Where(c => c.UserId.Equals(userId) && c.Id == carId);
            }
        }

        internal class GetVerifiedByUserId : Specification<Car>
        {
            public GetVerifiedByUserId(string userId)
            {
                Query.Where(c => c.UserId == userId && c.IsVerified);
            }
        }

        internal class GetWithTripsByUserId : Specification<Car>
        {
            public GetWithTripsByUserId(string userId)
            {
                Query
                    .Where(c => c.UserId == userId)
                    .Include(c => c.Trips);
            }
        }
    }
}
