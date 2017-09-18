using Xunit;

namespace HashingToolkit.Test
{
    public class HashifierMd5Unittest
    {
        private readonly HashingAlgorithmeMd5 _uut = new HashingAlgorithmeMd5();
        
        [Fact]
        public void GetHash_GivenValue_ReturnsHash()
        {
            const string expected = "174A0279AEBED83EF82204B1C1D7767D";
            var result = _uut.GetHash("bjorni");
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetHash_UsingSalt_DoesNotReturnVersionWithoutSalt()
        {
            const string value = "bjorni";  
            var noSalt = _uut.GetHash(value);
            var result = _uut.GetHash(value, "hello salty");

            Assert.NotEqual(noSalt, result);
        }
    }
}
