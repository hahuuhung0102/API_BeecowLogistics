using AutoMapper;
using BeecowLogistics.Services.Commons;
using BeecowLogistics.Services.DTOs.Login;
using BeecowLogistics.Services.Entities;
using BeecowLogistics.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Services
{
    public class LoginService : BaseService, ILoginService
    {
        private readonly IConfiguration _config;

        public LoginService(
            IConfiguration config,
            IRepository repository,
            IMapperService mapperService) : base(repository, mapperService)
        {
            _config = config;
        }

        public async Task<string> AuthencateAsync(LoginRequestModel request)
        {
            var user = await Context.Users.FirstOrDefaultAsync(u => u.Phone == request.UserName || u.Email == request.UserName);
            if (user == null) return null;

            var hasher = new PasswordHasher<User>();
            var verified = hasher.VerifyHashedPassword(null, user.PasswordHash, request.Password);

            if (verified == PasswordVerificationResult.Failed)
            {
                return null;
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.FullName),
                new Claim(ClaimTypes.MobilePhone, user.Phone),
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"], claims,
                expires: DateTime.Now.AddHours(SystemContants.TokenExpireTime),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<LoginModel> GetLoginAsync(string username)
        {
            var login = await Context.Users.FirstOrDefaultAsync(u => u.Phone == username || u.Email == username);
            return MapperService.ConvertTo<User, LoginModel>(login);
        }

        public async Task<bool> AddLoginAsync(RegisterRequestModel request)
        {
            try
            {
                if (request.Password != request.ConfirmPassword)
                {
                    return false;
                }

                var isExist = await Context.Users.FirstOrDefaultAsync(u => u.Phone == request.Phone || u.Email == request.Email);
                if (isExist != null)
                {
                    return false;
                }

                var hasher = new PasswordHasher<User>();
                Context.Users.Add(new User
                {
                    Code = Helpers.UserCodeGenerator("UID"),
                    FullName = request.FullName,
                    Phone = request.Phone,
                    PasswordHash = hasher.HashPassword(null, request.ConfirmPassword),
                    CreatedTime = DateTime.Now,
                    LastSavedTime = DateTime.Now,
                }); ;

                await Context.SaveChangesAsync();

                return true;

            } catch (Exception ex)
            {
                return false;
            }
            
        }

    }
}
