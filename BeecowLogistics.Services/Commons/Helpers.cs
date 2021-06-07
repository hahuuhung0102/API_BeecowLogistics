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
        public static string UserCodeGenerator(string type)
        {
            var bytes = new byte[4];
            var rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            uint random = BitConverter.ToUInt32(bytes, 0) % 100000000;
            return $"{type}{String.Format("{0:D8}", random)}";
        }
        
    }
}
