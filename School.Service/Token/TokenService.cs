﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using School.Application.Common.Enum;
using School.Application.Common.Models;
using School.Application.Contracts.Services;
using School.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace School.Service.Token
{
    public class TokenService : ITokenService
    {
        private readonly Jwt _jwt;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public TokenService(IOptions<Jwt> options, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _jwt = options.Value;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IEnumerable<Claim>> GetClaims(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var userRole = await _userManager.GetRolesAsync(user);
            var role = new List<Claim>();
            var permission = new List<Claim>();

            foreach (var item in userRole)
            {
                var roleName = await _roleManager.FindByNameAsync(item);
                var rolePermission = await _roleManager.GetClaimsAsync(roleName);
                role.Add(new Claim(ClaimsEnum.Role.ToString(), item));
                foreach (var item1 in rolePermission)
                {
                    permission.Add(item1);
                }
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.NameIdentifier,user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(ClaimsEnum.UserId.ToString(),user.Id),
            }
            .Union(role)
            .Union(permission)
            .Union(userClaims);

            return claims;
        }

        public async Task<string> GetToken(ApplicationUser user)
        {
            var claims = await GetClaims(user);
            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));
            SigningCredentials signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken securityToken = new JwtSecurityToken(
                audience: _jwt.Audience,
                issuer: _jwt.Issuer,
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.UtcNow.AddMinutes(_jwt.DurationInMinutes));

            var token = new JwtSecurityTokenHandler().WriteToken(securityToken);
            return token;

        }
    }
}
