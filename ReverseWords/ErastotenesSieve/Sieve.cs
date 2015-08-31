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
            List<int> primes = new List<int>();
            primes.Add(0);
            primes.Add(1);
            int current = 2;
            do
            {
                primes.Add(current);
                list = list.Where(x => x == 0 || x == current || x % current != 0).ToList();
                current = list.SkipWhile(x => x < current).Skip(1).Take(1).SingleOrDefault();
            } while (current != 0);
            
            return primes;
        }

        public int GetMaxPrime(int numberOfItems) {
            return Run(numberOfItems).ToList().Last();
        }
    }
}
