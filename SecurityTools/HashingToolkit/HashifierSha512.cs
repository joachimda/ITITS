using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace HashingToolkit
{
    public class HashifierSha512 : BaseHashifier, IHashifier
    {
        public string GetHash(string element, bool useSalt)
        {
            if (useSalt)
            {
                element += new Random().Next(1000, int.MaxValue).ToString();
            }

            var hasher = SHA512.Create();
            var bytes = Encoding.ASCII.GetBytes(element);
            var hashedValues = hasher.ComputeHash(bytes);
            return ByteArrayToString(hashedValues);
        }
    }
}
