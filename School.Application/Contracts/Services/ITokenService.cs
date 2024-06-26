﻿using School.Domain.Entities;
using System.Security.Claims;

namespace School.Application.Contracts.Services
{
    public interface ITokenService
    {
        Task<string> GetToken(ApplicationUser user);
        Task<IEnumerable<Claim>> GetClaims(ApplicationUser user);

    }
}
