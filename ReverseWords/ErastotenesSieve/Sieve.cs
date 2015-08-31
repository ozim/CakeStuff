namespace ErastotenesSieve
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sieve
    {
        internal List<int> Run(int numberOfItems)
        {
            List<int> list = Enumerable.Range(0,numberOfItems).ToList();
            int current = 2;
            do
            {
                list = list.Where(x => x == 0 || x == current || x%current != 0).ToList();
                current = list.SkipWhile(x => x < current).Skip(1).Take(1).SingleOrDefault();
            } while (current < Math.Sqrt(numberOfItems));
            
            return list;
        }

        public int GetMaxPrime(int numberOfItems) {
            return Run(numberOfItems).ToList().Last();
        }
    }
}
