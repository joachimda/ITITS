namespace HashingToolkit
{
    public interface IHashifier
    {
        string Hashify(string algorithme, string plaintext, string salt);
    }
}
