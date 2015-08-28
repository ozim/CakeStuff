namespace MatchingParenFinder
{
    using NUnit.Framework;

    [TestFixture]
    public class MatchingParenFinderTests
    {
        [TestCase("Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing.", 10, Result = 79)]
        public int CheckOutcome(string code, int startPosition)
        {
            MatchingParenFinder finder = new MatchingParenFinder();
            return finder.FindMatchingParenPosition(code, startPosition);
        }
    }
}
