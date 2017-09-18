using System.Security.Cryptography;
using System.Text;

namespace HashingToolkit
{
    public class HashifierSha256 : BaseHashifier, IHashifier
    {
        public string GetHash(string element)
        {
            var hasher = SHA256.Create();
            var bytes = Encoding.ASCII.GetBytes(element);
            var hashedValues = hasher.ComputeHash(bytes);
            return ByteArrayToString(hashedValues);
        }
    }
}
