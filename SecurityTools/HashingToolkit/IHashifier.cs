namespace HashingToolkit
{
    public interface IHashifier
    {
        string GetHash(string element, string salt);
    }
}
