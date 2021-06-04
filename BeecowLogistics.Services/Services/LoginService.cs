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
        /*private readonly SignInManager<Users> _signInManager;
        private readonly UserManager<Users> _userManager;*/

        public LoginService(
            /*UserManager<Users> userManager,
            SignInManager<Users> signInManager,*/
            IConfiguration config,
            IRepository repository,
            IMapperService mapperService) : base(repository, mapperService)
        {
            //_userManager = userManager;
            //_signInManager = signInManager;
            _config = config;
        }

        public async Task<string> AuthencateAsync(LoginRequestModel request)
        {
            var user = await Context.Users.FirstOrDefaultAsync(u => u.Phone == request.UserName || u.Email == request.UserName);

            if (user == null) return null;

            /*if (user != null && !await _userManager.CheckPasswordAsync(user, request.Password))
            {
                return null;
            }

            var username = user.Phone != null ? user.Phone : user.Email;
            var result = await _signInManager.PasswordSignInAsync(username, request.Password, request.RememberMe, true);
            if (result == null) return null;*/

            if (user.PasswordHash != request.Password)
            {
                return null;
            }

            var claims = new[]
            {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.Fullname),
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
            return MapperService.ConvertTo<Users, LoginModel>(login);
        }


        public async Task<IdentityResult> AddLoginAsync(RegisterRequestModel request)
        {
            /*var appUser = MapperService.ConvertTo<RegisterRequestModel, AppUser>(request);
            var hasher = new PasswordHasher<AppUser>();

            appUser.PasswordHash = hasher.HashPassword(null, request.ConfirmPassword);

            var result = await _userManager.CreateAsync(appUser);*/

            return null;

        }

    }
}
