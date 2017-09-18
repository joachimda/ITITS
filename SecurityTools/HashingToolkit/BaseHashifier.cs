using System.Text;

namespace HashingToolkit
{
    public class BaseHashifier
    {
        public string ByteArrayToString(byte[] array)
        {
            var stringBuilder = new StringBuilder();

            foreach (var value in array)
            {
                stringBuilder.Append(value.ToString("X2"));
            }

            return stringBuilder.ToString();
        }
    }
}