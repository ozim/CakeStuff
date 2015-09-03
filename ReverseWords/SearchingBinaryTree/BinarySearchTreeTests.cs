namespace SearchingBinaryTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using NUnit.Framework;

    [TestFixture]
    class BinarySearchTreeTests
    {
        //Timeout for infinite loop detection
        [Test,Timeout(500)]
        public void AddingNodes() {
            
            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(new Node { Value = 10 });
            tree.Add(new Node { Value = 5 });
            tree.Add(new Node { Value = 15 });
            tree.Add(new Node { Value = 4 });
            tree.Add(new Node { Value = 13 });

            Assert.AreEqual(10, tree.Root.Value);
            Assert.AreEqual(5, tree.Root.Right.Value);
            Assert.AreEqual(15, tree.Root.Left.Value);
            Assert.AreEqual(4, tree.Root.Right.Right.Value);
            Assert.AreEqual(13, tree.Root.Left.Right.Value);
        }

        [Test]
        public void FindSecondLargest()
        {

            BinarySearchTree tree = new BinarySearchTree();
            tree.Add(new Node { Value = 10 });
            tree.Add(new Node { Value = 5 });
            tree.Add(new Node { Value = 15 });
            tree.Add(new Node { Value = 4 });
            tree.Add(new Node { Value = 13 });

            int result = tree.FindSecondLargest();

            Assert.AreEqual(13, result);
        }

        [Test]
        public void ThrowsExceptionWhenRootNotSet()
        {
            BinarySearchTree tree = new BinarySearchTree();
            Assert.Throws(typeof(InvalidOperationException), () => tree.FindSecondLargest());
        }
    }
}
