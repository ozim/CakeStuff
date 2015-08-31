namespace ErastotenesSieve
{
    using NUnit.Framework;
    using System.Collections.Generic;
    using System.Linq;

    [TestFixture]
    class SieveTests
    {
        [Test]
        public void TestSieveBiggestInFirstHunderd() {
            int numberOfItems = 100;
            int expectedResult = 97;

            Sieve sieve = new Sieve();

            int result = sieve.GetMaxPrime(100);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ZeroOneAndTwoNotRemoved()
        {
            int numberOfItems = 100;

            Sieve sieve = new Sieve();

            List<int> result = sieve.Run(100);

            Assert.True(result.Any(x => x == 2));
            Assert.True(result.Any(x => x == 1));
            Assert.True(result.Any(x => x == 0));
        }

    }
}
