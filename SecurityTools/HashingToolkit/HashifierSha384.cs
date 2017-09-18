using System.Security.Cryptography;
using System.Text;

namespace HashingToolkit
{
    public class HashifierSha384 : BaseHashifier, IHashifier
    {
        public string GetHash(string element, bool useSalt)
        {
            var hasher = SHA384.Create();
            var bytes = Encoding.ASCII.GetBytes(element);
            var hashedValues = hasher.ComputeHash(bytes);
            return ByteArrayToString(hashedValues);
        }
    }
}
