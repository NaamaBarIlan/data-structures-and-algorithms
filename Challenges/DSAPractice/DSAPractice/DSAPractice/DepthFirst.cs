using System;
using System.Collections.Generic;
using System.Text;

namespace DSAPractice
{
    public class DepthFirst
    {

        public static int CountTreeNodesDepth(Tree<int> tree)
        {
            return CountTreeNodesDepth(tree.Root);
        }

        private static int CountTreeNodesDepth(Node<int> current)
        {
            if (current == null)
            {
                return 0;
            }

            int result = 1 + CountTreeNodesDepth(current.LeftChild) +
                             CountTreeNodesDepth(current.RightChild);

            return result;

        }
 
    }
}
