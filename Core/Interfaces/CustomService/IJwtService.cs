using Core.Entities.RefreshTokenEntity;
using Core.Entities.UserEntity;
using System.Collections.Generic;
using System.Security.Claims;

namespace Core.Interfaces.CustomService
{
    public interface IJwtService
    {
        IEnumerable<Claim> SetClaims(User user);
        string CreateToken(IEnumerable<Claim> claims);
        RefreshToken GenerateRefreshToken();
        public IEnumerable<Claim> GetClaimsFromExpiredToken(string token);
    }
}
