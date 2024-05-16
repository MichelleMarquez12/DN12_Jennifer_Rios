﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WebApi.Cors.Example.Auth;
using WebApi.Cors.Example.Models;
using WebApi.Cors.Example.Shared.Config;

namespace WebApi.Cors.Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly IJwtIssuerOptions _jwtOptions;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IOptions<JwtTokenValidationSettings> _jwtConfig;

        public AuthController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            IJwtIssuerOptions jwtOptions,
            RoleManager<IdentityRole> roleManager,
            IOptions<JwtTokenValidationSettings> jwtConfig)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtOptions = jwtOptions;   
            _roleManager = roleManager;
            _jwtConfig = jwtConfig;
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (model == null)
            {
                return BadRequest("Invalid client recuest");
            }

            var user = await _userManager.FindByEmailAsync(model.Username);

            if (user == null)
            {
                return Unauthorized();
            }

            var resuslt = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (user == null || !(await _signInManager.PasswordSignInAsync(user, model.Password, false, false)).Succeeded)
                return Unauthorized();

            var tokenString = await CreateJwtTokenAsync(user);

            var result = new ContentResult() { Content = tokenString, ContentType = "Aplication" };

            return result;
        }

        private async Task<string> CreateJwtTokenAsync(IdentityUser user)
        {
            var claims = new List<Claim>(new[]
            {
                new Claim(JwtRegisteredClaimNames.Iss, _jwtOptions.Issuer),

                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),

                new Claim(JwtRegisteredClaimNames.Email, user.Email),

                new Claim(JwtRegisteredClaimNames.Jti, await _jwtOptions.JtiGenerator()),

                new Claim(JwtRegisteredClaimNames.Iat, _jwtOptions.IssuedAt.ToUnixEpochDate().ToString(), ClaimValueTypes.Integer64)
            });

            claims.AddRange(await _userManager.GetClaimsAsync(user));

            var roleNames = await _userManager.GetRolesAsync(user);

            foreach (var roleName in roleNames)
            {
                var role = await _roleManager.FindByNameAsync(roleName);

                if (role != null)
                {
                    var roleClaim = new Claim(ClaimTypes.Role, role.Name, ClaimValueTypes.String);
                    claims.Add(roleClaim);

                    var roleClaims = await _roleManager.GetClaimsAsync(role);
                    claims.AddRange(roleClaims);
                }
            }

            var jwt = new JwtSecurityToken(
                issuer: _jwtOptions.Issuer,
                audience: _jwtOptions.Audience,
                claims: claims,
                notBefore: _jwtOptions.NotBefore,
                expires: _jwtOptions.Expires,
                signingCredentials: _jwtOptions.SingningCredentials);

            var result = new JwtSecurityTokenHandler().WriteToken(jwt);

            return result;
        }
    }
}
