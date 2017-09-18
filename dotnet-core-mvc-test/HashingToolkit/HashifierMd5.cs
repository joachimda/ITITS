using System;
using System.Security.Cryptography;

namespace HashingToolkit
{
    public class HashifierMd5
    {
        public string GetHash(string element)
        {
            var hasher = MD5.Create();
            var bytes = System.Text.Encoding.ASCII.GetBytes(element);
            byte[] hashedValues = hasher.ComputeHash(bytes);
            return hashedValues.ToString();
        }
    }
}
