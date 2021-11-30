using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace CapaLogica.Models
{
    public class UserModel
    {
        public string Encrypt(string pwrd)
        {
            SHA512 hashSvc = SHA512.Create();
            byte[] hash = hashSvc.ComputeHash(Encoding.UTF8.GetBytes(pwrd));
            return Convert.ToBase64String(hash).ToUpper();
        }
    }
}
