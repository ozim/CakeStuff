namespace ErastotenesSieve
{
    using NUnit.Framework;

    [TestFixture]
    class SieveTests
    {
        [Test]
        public void TestSieve() {
            int numberOfItems = 100;
            int expectedResult = 97;

            Sieve sieve = new Sieve();

            int result = sieve.Run(100);

            Assert.AreEqual(expectedResult, result);
        }

    }
}
