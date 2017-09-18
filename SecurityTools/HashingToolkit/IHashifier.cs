namespace HashingToolkit
{
    public interface IHashifier
    {
        string GetHash(string element, bool useSalt);
    }
}
