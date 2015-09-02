namespace SearchingBinaryTree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class BinarySearchTree
    {
        Node Root { get; set; }

        public void Add(Node node) {
            if(Root!=null) {
                if(Root.Value > node.Value) {
                    Root.Right = node;
                } else {
                    Root.Left = node;
                }
            } else {
                Root = node;
            }
        }
    }
}
