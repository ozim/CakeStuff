namespace SearchingBinaryTree
{
    using System;

    class BinarySearchTree
    {
        public Node Root { get; private set; }

        public void Add(Node node) {
        if(node == null) {
                throw new ArgumentNullException("node");
        }
            if(Root!=null) {
                Node current = Root;

                while(current != null) {
                    if (current.Value > node.Value)
                    {
                        if (current.Right != null) {
                            current = current.Right;
                            continue;
                         }
                        current.Right = node;
                        current = null;
                    }
                    else
                    {
                        if (current.Left != null) {
                            current = current.Left;
                            continue;
                        }
                        current.Left = node;
                        current = null;
                    }
                }
            } else {
                Root = node;
            }
        }
        
        public int FindSecondLargest() {
            if (Root == null) throw new InvalidOperationException("Root not set");
            Node current = Root;

            while(current.Left != null) {
                current = current.Left;
            }
            if(current.Right != null) {
                return current.Right.Value;
            }
            return current.Value;
        }
    }
}
