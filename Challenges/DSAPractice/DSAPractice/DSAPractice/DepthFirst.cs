using System;
using System.Collections.Generic;
using System.Text;

namespace DSAPractice
{
    public class DepthFirst
    {
        public static int CountTreeNodesDepth(Node<int> root)
        {
            int counter = 0;
            CountTreeNodesDepth(counter, root);
            return counter;
        }

        private static void CountTreeNodesDepth(int counter, Node<int> root)
        {
            counter++;

            if (root.LeftChild != null)
            {
                CountTreeNodesDepth(counter, root.LeftChild);
            }

            if (root.RightChild != null)
            {
                CountTreeNodesDepth(counter, root.RightChild);
            }

        }


    }
}
