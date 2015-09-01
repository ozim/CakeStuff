namespace HashMap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MappingWithHashes
    {

        private BucketHolder[] internalContainer = new BucketHolder[100];

        internal void Add(string item)
        {
            int calculatedIndex = CalculateIndex(item);
            internalContainer[calculatedIndex].Insert(item);
        }

        public bool Contains(string item) {
            int calculatedIndex = CalculateIndex(item);
            return internalContainer[calculatedIndex].CheckIfContains(item);
        }

        private int CalculateIndex(string item) {
            char[] itemByCharacter = item.ToCharArray();
            return 0;
        }
    }
}
