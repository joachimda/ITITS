using System;
using System.Security.Cryptography;
using System.Text;

namespace HashingToolkit
{
    public class HashifierSha384 : BaseHashifier, IHashifier
    {
        public string GetHash(string element, bool useSalt)
        {
            if (useSalt)
            {
                element += new Random().Next(1000, int.MaxValue).ToString();
            }

            var hasher = SHA384.Create();
            var bytes = Encoding.ASCII.GetBytes(element);
            var hashedValues = hasher.ComputeHash(bytes);
            return ByteArrayToString(hashedValues);
        }
    }
}
