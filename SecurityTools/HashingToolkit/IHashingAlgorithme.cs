namespace HashingToolkit
{
    public interface IHashingAlgorithme
    {
        string GetHash(string element, string salt);
    }
}
