namespace MatchingParenFinder
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class MatchingParenFinderTests
    {
        [TestCase("Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing.", 10, Result = 79)]
        public int CheckOutcome(string code, int startPosition)
        {
            MatchingParenFinder finder = new MatchingParenFinder();
            return finder.FindMatchingParenPosition(code, startPosition);
        }

        [Test]
        public void StartPositionNegative()
        {
            string code = "some";
            MatchingParenFinder finder = new MatchingParenFinder();
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => finder.FindMatchingParenPosition(code, -5));
        }
        
        [Test]
        public void StartPositionAboveCodeLength()
        {
            string code = "some";
            MatchingParenFinder finder = new MatchingParenFinder();
            Assert.Throws(typeof(ArgumentOutOfRangeException), () => finder.FindMatchingParenPosition(code, 1000));
        }

    }
}
