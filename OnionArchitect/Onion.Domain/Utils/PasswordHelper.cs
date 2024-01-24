using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;

namespace Onion.Domain.PasswordHelper
{
	public static class PasswordHelper
	{
        private const int keySize = 64;
        private const int iterations = 350000;
        static KeyDerivationPrf keyDerivationPrf = KeyDerivationPrf.HMACSHA256;
        private static byte[] createSalt()
        {
            var str = new Random().Next(100000000, 999999999).ToString();
            return Encoding.UTF8.GetBytes(str);
        }

        private static byte[] ConvertSaltToByte(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }

        private static string ConvertSaltToString(byte[] byt)
        {
            return Encoding.UTF8.GetString(byt);
        }

        public static void HashPassword(ref User user)
        {
            var salt = createSalt();
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: user.PasswordHash!,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: iterations,
            numBytesRequested: keySize));
            user.PasswordHash = hashed;
            user.SaltValue = ConvertSaltToString(salt);
        }

        public static bool VerifyPassword(string password, string hash, string salt)
        {
            var _salt = ConvertSaltToByte(salt);
            var hashToCompare = KeyDerivation.Pbkdf2(password, _salt, keyDerivationPrf, iterations, keySize);
            return CryptographicOperations.FixedTimeEquals(hashToCompare, Convert.FromHexString(hash));
        }
    }
}

