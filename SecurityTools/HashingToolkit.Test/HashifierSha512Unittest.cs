using Xunit;

namespace HashingToolkit.Test
{
    public class HashifierSha512Unittest
    {
        private readonly HashingAlgorithmeSha512 _uut = new HashingAlgorithmeSha512();
        
        [Fact]
        public void GetHash_GivenValue_ReturnsHash()
        {
            const string expected = "daa037b6cd1675f36a3685e95245c" +
                                    "9d8a72a56d05e4b978b47e0453e80" +
                                    "0ac5bd8ab6cce3ce73e109f48c919" +
                                    "df1cfe68cf9bf29aeb3b917ec3f94" +
                                    "0fb082c234ea";

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
