using Core.Entities.UserEntity;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IJwtService
    {
        Task<IEnumerable<Claim>> SetClaims(User user);
        string CreateToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        public IEnumerable<Claim> GetClaimsFromExpiredToken(string token);
    }
}
