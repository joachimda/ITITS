using Xunit;

namespace HashingToolkit.Test
{
    public class HashifierSha1Unittest
    {
        private readonly HashifierSha1 _uut = new HashifierSha1();
        
        [Fact]
        public void GetHash_GivenValue_ReturnsHash()
        {
            const string expected = "E2A6D9392CC3EEFC751D29E3593D96648E6B9C28";
            var result = _uut.GetHash("bjorni", false);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetHash_UsingSalt_DoesNotReturnVersionWithoutSalt()
        {
            const string value = "bjorni";
            var noSalt = _uut.GetHash(value, false);
            var result = _uut.GetHash(value, true);

            Assert.NotEqual(noSalt, result);
        }
    }
}
