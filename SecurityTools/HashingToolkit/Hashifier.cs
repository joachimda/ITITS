namespace HashingToolkit
{
    public class Hashifier : IHashifier
    {
        public string Hashify(string algorithme, string plaintext, string salt)
        {
            IHashingAlgorithme hasher;

            switch (algorithme)
            {
                case "MD5": hasher = new HashingAlgorithmeMd5(); break;
                case "SHA1": hasher = new HashingAlgorithmeSha1(); ; break;
                case "SHA256": hasher = new HashingAlgorithmeSha256(); break;
                case "SHA384": hasher = new HashingAlgorithmeSha384(); break;
                case "SHA512": hasher = new HashingAlgorithmeSha512(); break;
                default: hasher = new HashingAlgorithmeSha256(); break;
            }

            return hasher.GetHash(plaintext, salt);
        }
    }
}
