using System.Security.Cryptography;
using System.Text;

namespace Domain.Helpers
{
    public static class HashHelper
    {
        public static string Sha256(string value)
        {
            StringBuilder Sb = new();

            using (var hash = SHA256.Create())
            {
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
    }
}
