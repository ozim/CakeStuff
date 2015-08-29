namespace LargestElementInStack
{
    using System.Collections.Generic;
    using System.Linq;

    public class LargestElementInStack
    {
        private List<int> items = new List<int>();
        private List<int> largeItems = new List<int>();

        public void Push(int item) {
            items.Add(item);
            if(!largeItems.Any() || item > largeItems.Last()) {
                largeItems.Add(item);
            }
        }

        public int Pop() {
            int last = items.Last();
            
            if (largeItems.Last() == last) {
                largeItems.Remove(largeItems.Last());
            }
            
            items.Remove(last);
            return last;
        }

        public int Peek() {
            return items.Last();
        }

        public int GetMax() {
            return largeItems.Last();
        }
    }
}
