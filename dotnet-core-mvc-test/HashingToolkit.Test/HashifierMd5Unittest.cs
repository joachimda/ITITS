using Xunit;

namespace HashingToolkit.Test
{
    public class HashifierMd5Unittest
    {
        public HashifierMd5Unittest()
        {
            
        }

        [Theory]
        [InlineData("bjorni", "174a0279aebed83ef82204b1c1d7767d")]
        public void GetHash_GivenString_ReturnsCorrect(string value, string hash)
        {

        }
    }
}
