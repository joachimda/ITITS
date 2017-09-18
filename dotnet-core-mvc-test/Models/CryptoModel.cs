using System;
using System.Collections.Generic;

namespace dotnet_core_mvc_test.Models
{
    public static class CryptoModel
    {
       public static List<string> HashingAlgorithms = new List<string> {"MD5", "SHA1", "SHA256"};
       public static List<string> EncryptionAlgorithms = new List<string> {"AES", ""};
    }
}