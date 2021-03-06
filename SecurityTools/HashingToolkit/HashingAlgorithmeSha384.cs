﻿using System.Security.Cryptography;
using System.Text;

namespace HashingToolkit
{
    public class HashingAlgorithmeSha384 : BaseHashingAlgorithme, IHashingAlgorithme
    {
        public string GetHash(string element, string salt = "")
        {
            if (!string.IsNullOrWhiteSpace(salt))
            {
                element += salt;
            }

            var hasher = SHA384.Create();
            var bytes = Encoding.ASCII.GetBytes(element);
            var hashedValues = hasher.ComputeHash(bytes);
            return ByteArrayToString(hashedValues);
        }
    }
}
