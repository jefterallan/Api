using System.Security.Cryptography;
using System.Text;

namespace ApiSample.Helpers
{
    public static class SharedExtentions
    {
        public static string EncryptSHA512(string data, string? key = null)
        {
            var message = Encoding.UTF8.GetBytes(data);

            using var alg = SHA512.Create();

            var hashValue = alg.ComputeHash(message);

            return hashValue.Aggregate(key ?? string.Empty, (current, x) => current + $"{x:x2}");
        }
    }
}
