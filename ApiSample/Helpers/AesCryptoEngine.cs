using System.Text;
using System.Security.Cryptography;

namespace ApiSample.Helpers
{
    [Obsolete("Replaced by the SHA512.Create()")]
    public static class AesCryptoEngine
    {
        private static byte[]? Key { get; set; }
        private static byte[]? Iv { get; set;}
        private static string? Value { get; set; }

        public static string? Encrypt(string value, string key)
        {
            if (!CryptoValidation(value, key))
                return null;

            byte[] valueEncrypted;

            using (AesCryptoServiceProvider aesCryptoServiceProvider = new())
            {
                try
                {
                    ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateEncryptor(Key ?? Array.Empty<byte>(), Iv);
                    aesCryptoServiceProvider.Padding = PaddingMode.None;

                    using MemoryStream memoryStream = new();
                    using CryptoStream cryptoStream = new(memoryStream, cryptoTransform, CryptoStreamMode.Write);
                    using (StreamWriter streamWriter = new(cryptoStream))
                    {
                        streamWriter.Write(Value);
                    }

                    valueEncrypted = memoryStream.ToArray();

                }
                catch (Exception)
                {
                    return null;
                }
            }

            return Convert.ToBase64String(valueEncrypted);
        }

        public static string? Decrypt(string value, string key)
        {
            if (!CryptoValidation(value, key))
                return null;

            byte[] valueDecrypted;
            string result;

            using (AesCryptoServiceProvider aesCryptoServiceProvider = new())
            {
                try
                {
                    ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateEncryptor(Key ?? Array.Empty<byte>(), Iv);
                    aesCryptoServiceProvider.Padding = PaddingMode.None;
                    valueDecrypted = Convert.FromBase64String(Value ?? string.Empty);

                    using MemoryStream memoryStream = new();
                    using CryptoStream cryptoStream = new(memoryStream, cryptoTransform, CryptoStreamMode.Read);
                    using StreamReader streamReader = new(cryptoStream);
                    
                    result = streamReader.ReadToEnd();

                }
                catch (Exception)
                {
                    return null;
                }
            }

            return result;
        }

        private static bool CryptoValidation(string value, string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return false;

            if (string.IsNullOrWhiteSpace(value))
                return false;

            Iv = Encoding.ASCII.GetBytes(key);
            Key = Encoding.ASCII.GetBytes(key);
            Value = value;

            return true;
        }
    }
}
