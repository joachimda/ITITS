using System.Security.Cryptography;
using System.Text;

namespace HashingToolkit
{
    public class HashifierMd5
    {
        public string GetHash(string element)
        {
            var hasher = MD5.Create();
            var bytes = Encoding.ASCII.GetBytes(element);
            var hashedValues = hasher.ComputeHash(bytes);
            var stringBuilder = new StringBuilder();

            for (var i = 0; i < hashedValues.Length; i++)
            {
                var value = hashedValues[i];
                stringBuilder.Append(value.ToString("X2"));
            }

            return stringBuilder.ToString();
        }
    }
}
