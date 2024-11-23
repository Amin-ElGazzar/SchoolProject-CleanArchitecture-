using School.Application.Features.Authentication.Commends.Models.Response;
using School.Domain.Entities;
using System.Security.Claims;

namespace School.Application.Contracts.Services
{
    public interface ITokenService
    {
        Task<TokenModleResponse> GetToken(ApplicationUser user);
        Task<IEnumerable<Claim>> GetClaims(ApplicationUser user);
        string GenerateRefreshToken();

        RefreshTokens GetRefreshTokens();

    }
}
