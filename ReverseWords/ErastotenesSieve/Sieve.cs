namespace ErastotenesSieve
{
    using System.Collections.Generic;
    using System.Linq;

    public class Sieve
    {
        internal int Run(int numberOfiItems)
        {
            List<int> list = Enumerable.Range(0,numberOfiItems).ToList();

            list = list.Where(x => x!=2 && x%2!=0).ToList();

            return list.Last();
        }
    }
}
