using Xunit;

namespace HashingToolkit.Test
{
    public class HashifierSha256Unittest
    {
        private readonly HashifierSha256 _uut = new HashifierSha256();
        
        [Fact]
        public void GetHash_GivenValue_ReturnsHash()
        {
            const string expected = "f84fda43760b7599e7b2aa386d05e9350ebfba83d159b5fd6e3c0782db26c2af";
            var result = _uut.GetHash("bjorni");
            Assert.Equal(expected.ToUpper(), result);
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
