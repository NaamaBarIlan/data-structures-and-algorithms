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
            return CountTreeNodesDepthHelper(tree.Root);
        }

        /// <summary>
        /// Helper method for CountTreeNodesDepth
        /// </summary>
        /// <param name="current">The root node of the tree that is being traversed</param>
        /// <returns>The total count of nodes in the tree</returns>
        private static int CountTreeNodesDepthHelper(Node<int> current)
        {
            if (current == null)
            {
                return 0;
            }

            int result = 1 + CountTreeNodesDepthHelper(current.LeftChild) +
                             CountTreeNodesDepthHelper(current.RightChild);

            return result;

        }

        /// <summary>
        /// Counts the number of leaves in a tree recursively,
        /// using a depth first pre-order traversal
        /// </summary>
        /// <param name="root">The root node of the tree that is being traversed</param>
        /// <returns>The total count of leaves in the tree</returns>
        public static int CountTreeLeavesDepth(Node<int> root)
        {
            return CountTreeLeavesDepthHelper(root);
        }

        /// <summary>
        /// Helper method for CountTreeLeavesDepth
        /// </summary>
        /// <param name="current">The root node of the tree that is being traversed</param>
        /// <returns>The total count of leaves in the tree</returns>
        private static int CountTreeLeavesDepthHelper(Node<int> current)
        {
            if (current == null)
            {
                return 0;
            }

            if (current.LeftChild == null && current.RightChild == null)
            {
                return 1;
            }

            int result = CountTreeLeavesDepthHelper(current.LeftChild) +
                             CountTreeLeavesDepthHelper(current.RightChild);

            return result;
        }


    }
}
