using Refactoring.GeneratePrimes;
using Xunit;

namespace Refactoring.Tests.GeneratePrimes
{
    public class PrimesGeneratorTests
    {
        [Fact]
        public void Test_primes()
        {
            int[] nullArray = PrimesGenerator.GeneratePrimes(0);

            Assert.Equal(0, nullArray.Length);


            int[] minArray = PrimesGenerator.GeneratePrimes(2);
            Assert.Equal(1, minArray.Length);
            Assert.Equal(2, minArray[0]);

            int[] threeArray = PrimesGenerator.GeneratePrimes(3);
            Assert.Equal(2, threeArray.Length);
            Assert.Equal(2, threeArray[0]);
            Assert.Equal(3, threeArray[1]);

            int[] centArray = PrimesGenerator.GeneratePrimes(100);
            Assert.Equal(25, centArray.Length);
            Assert.Equal(97, centArray[24]);
        }
    }
}
