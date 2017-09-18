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
            var result = _uut.GetHash("bjorni");
            Assert.Equal(expected, result);
        }
    }
}
