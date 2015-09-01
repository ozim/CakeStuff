namespace HashMap
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BucketHolder
    {
        private List<string> internalList = new List<string>();

        public void Insert(string item) {
            internalList.Add(item);
        }

        public void Remove(string item)
        {
            internalList.Remove(item);
        }

        public bool CheckIfContains(string item) {
            return internalList.Any(x => x == item);
        }
    }
}
