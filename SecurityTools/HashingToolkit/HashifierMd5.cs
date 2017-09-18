using System.Security.Cryptography;
using System.Text;

namespace HashingToolkit
{
    public class HashifierMd5 : BaseHashifier, IHashifier
    {
        public string GetHash(string element, string salt = "")
        {
            if (!string.IsNullOrWhiteSpace(salt))
            {
                element += salt;
            }

            var hasher = MD5.Create();
            var bytes = Encoding.ASCII.GetBytes(element);
            var hashedValues = hasher.ComputeHash(bytes);
            return ByteArrayToString(hashedValues);
        }
    }
}
