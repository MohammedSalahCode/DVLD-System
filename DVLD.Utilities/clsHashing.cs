using System;
using System.Security.Cryptography;
using System.Text;

namespace DVLD.Utilities
{
    public static class clsHashing
    {
        /// <summary> Returns SHA256 hash of input. </summary>
        public static string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        /// <summary> Compares input to a stored hash. </summary>
        public static bool VerifyHash(string input, string storedHash)
        {
            string hashOfInput = ComputeHash(input);
            return string.Equals(hashOfInput, storedHash, StringComparison.OrdinalIgnoreCase);
        }
    }
}
