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
    }
}
