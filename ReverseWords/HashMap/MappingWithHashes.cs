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
            
        }

        public bool Contains(string item) {

            return false;
        }

        private int CalculateIndex(string item) {
            
            char[] itemByCharacter = item.ToCharArray();

            return 0;
        }
    }
}
