using System;
using System.Collections.Generic;
using System.Text;

namespace DSAPractice
{
    public class DepthFirst
    {
        /// <summary>
        /// Counts the number of nodes in a tree recursively,
        /// using a depth first pre-order traversal
        /// </summary>
        /// <param name="tree">The tree that is being traversed</param>
        /// <returns>The total count of nodes in the tree</returns>
        public static int CountTreeNodesDepth(Tree<int> tree)
        {
            return CountTreeNodesDepth(tree.Root);
        }

        /// <summary>
        /// Helper method for CountTreeNodesDepth
        /// </summary>
        /// <param name="current">The root node of the tree that is being traversed</param>
        /// <returns>The total count of nodes in the tree</returns>
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

        /// <summary>
        /// Counts the number of leaves in a tree recursively,
        /// using a depth first pre-order traversal
        /// </summary>
        /// <param name="root">The root node of the tree that is being traversed</param>
        /// <returns>The total count of leaves in the tree</returns>
        public static int CountTreeLeaves(Node<int> root)
        {
            return CountTreeLeavesHelper(root);
        }

        private static int CountTreeLeavesHelper(Node<int> current)
        {
            if (current == null)
            {
                return 0;
            }

            if (current.LeftChild == null && current.RightChild == null)
            {
                return 1;
            }

            int result = CountTreeLeavesHelper(current.LeftChild) +
                             CountTreeLeavesHelper(current.RightChild);

            return result;
        }


    }
}
