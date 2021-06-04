using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.DTOs.Login
{
    public class LoginModel
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
    }
}
