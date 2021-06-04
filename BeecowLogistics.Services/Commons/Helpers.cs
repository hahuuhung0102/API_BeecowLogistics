using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Commons
{
    public class Helpers
    {
        /*public static bool VerifyPassword(string password, string storedHash)
        {
            var rfc2898DerivedBytes = new Rfc2898DeriveBytes(password, 10000);
            var x = Convert.ToBase64String(rfc2898DerivedBytes.GetBytes(256));

            return x == storedHash;
        }

        public static string GeneratePasswordHash(string password)
        {
            var data = Encoding.ASCII.GetBytes(password);
            var sha1 = new SHA1CryptoServiceProvider();
            var hashPassword = sha1.ComputeHash(data);

            Convert.ToBase64String()
            return hashPassword;
        }*/
    }
}
