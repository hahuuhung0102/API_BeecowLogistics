using BeecowLogistics.Services.DTOs.Users;
using BeecowLogistics.Services.Entities;
using BeecowLogistics.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Services
{
    public class UserService : IUserService
    {
        private readonly BeecowLogisticsDbContext _dbContext;

        public UserService(BeecowLogisticsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserResponse> Login (LoginUserModel loginRequest)
        {
            var user = _dbContext.Users.FirstOrDefault(x => (x.Email == loginRequest.Username
                                || x.Phone == loginRequest.Username));

            if (user == null)
            {
                return null;
            }
            //var passwordHash = HashingHelper.HashUsingPbkdf2(loginRequest.Password, customer.PasswordSalt);

            //var token = await Task.Run(() => TokenHelper.GenerateToken(user));

            return new UserResponse
            {
                UserId = user.Id,
                Username = user.Fullname,
                Email = user.Email,
                Phone = user.Phone,
                Token = "123",
            };
        }
    }
}
