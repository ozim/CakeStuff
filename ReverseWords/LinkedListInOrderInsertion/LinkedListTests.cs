namespace LinkedListInOrderInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;

    [TestFixture]
    class LinkedListTests
    {
        [Test]
        public void InsertedElementCanBeRetrieved() {
            LinkedList list = new LinkedList();

            int testValue = 1;
            list.Add(testValue);

            int lastAddedItem = list.Last();

            Assert.AreEqual(testValue, lastAddedItem);
        }

        [Test,Timeout(500)]
        public void InsertedLowerElementIsNotLast() {
            LinkedList list = new LinkedList();

            int testValue = 5;
            int smallerTestValue = 3;

            list.Add(testValue);
            list.Add(smallerTestValue);

            int lastAddedItem = list.Last();

            Assert.AreEqual(testValue, lastAddedItem);
        }

        [Test]
        public void InsertedMultipleItemsAreSorted()
        {
            LinkedList list = new LinkedList();

            int[] values = { 5, 3, 4, 0 };
            
            foreach (int val in values)
            {
                list.Add(val);
            }

            Array.Sort(values);
            
            int counter = 0;

            foreach(var item in list.Next()) {
                Assert.AreEqual(values[counter], item.Value);
                counter++;
            }
        }
    }
}
