using Xunit;

namespace HashingToolkit.Test
{
    public class HashifierSha384Unittest
    {
        private readonly HashingAlgorithmeSha384 _uut = new HashingAlgorithmeSha384();
        
        [Fact]
        public void GetHash_GivenValue_ReturnsHash()
        {
            const string expected = "1b30435859647e764cdb1804c49b59fbff80938fa7fb175bda571f34c7c90f7fc5c1490feaf53deafa7a3cf3b3c82460";
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
