using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace e_commerce_client.functions
{
    class hash
    {
        public static string Hash_func(string password)
        {
            //hash the password SHA256
            string hashed_password = "";
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < bytes.Length; i++)
                {
                    hashed_password += bytes[i].ToString("x2");
                }
            }
            return hashed_password;
        }
    }
}
