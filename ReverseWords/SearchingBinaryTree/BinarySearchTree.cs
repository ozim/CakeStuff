namespace SearchingBinaryTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BinarySearchTree
    {
        public Node Root { get; private set; }

        public void Add(Node node) {
            if(Root!=null) {
                Node current = Root;

                while(current != null) {
                    if (current.Value > node.Value)
                    {
                        if (current.Right != null) {
                            current = current.Right;
                            continue;
                         }
                        Root.Right = node;
                        current = null;
                    }
                    else
                    {
                        if (current.Left != null) {
                            current = current.Left;
                            continue;
                        }
                        Root.Left = node;
                        current = null;
                    }
                }
            } else {
                Root = node;
            }
        }
    }
}
