using System.Security.Cryptography;
using System.Text;

namespace HashingToolkit
{
    public class HashingAlgorithmeSha512 : BaseHashingAlgorithme, IHashingAlgorithme
    {
        public string GetHash(string element, string salt = "")
        {
            if (!string.IsNullOrWhiteSpace(salt))
            {
                element += salt;
            }

            var hasher = SHA512.Create();
            var bytes = Encoding.ASCII.GetBytes(element);
            var hashedValues = hasher.ComputeHash(bytes);
            return ByteArrayToString(hashedValues);
        }
    }
}
