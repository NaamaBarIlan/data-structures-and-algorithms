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

        /// <summary>
        /// Returns the height of a binary tree as an integer
        /// The height of a binary tree is the number of edges 
        /// between the tree's root and its furthest leaf
        /// </summary>
        /// <param name="root">A reference to the root of a binary tree</param>
        /// <returns>A single integer denoting the height of the binary tree</returns>
        public static int GetTreeHeight(Node<int> current)
        {
            //base case:
            if (current == null)
            {
                return -1;
            }

            // recursive case:
            int leftSide = GetTreeHeight(current.LeftChild);
            int rightSide = GetTreeHeight(current.RightChild);

            if(leftSide > rightSide)
            {
                return leftSide + 1;
            }
            else
            {
                return rightSide + 1;
            }
        }

        //==============================================================

        /// <summary>
        /// Returns the length of the smallest branch in a binary tree
        /// without using any global variables. 
        /// </summary>
        /// <param name="root">A reference to the root of a binary tree</param>
        /// <returns>The length, the number of nodes, of the smallest in the binary tree</returns>
        public static int SmallestBranch(Node<int> root)
        {
            return SmallestBranchHelper(root);
        }

        private static int SmallestBranchHelper(Node<int> current)
        {
            //Edge case: if the root is null, return 0
            if (current == null)
            {
                return 0;
            }

            // Base case: if the node is a leaf node return 1
            if(current.LeftChild == null && current.RightChild == null)
            {
                return 1;
            }
            
            // Recursive case:

            // If the node's left side is null return f(right)
            if(current.LeftChild == null)
            {
                return 1 + SmallestBranchHelper(current.RightChild);
            }

            // If the node's right side is null return f(left)
            if(current.RightChild == null)
            {
                return 1 + SmallestBranchHelper(current.LeftChild);
            }

            // Return the smallest of left and right
            return 1 + Math.Min(SmallestBranchHelper(current.LeftChild),
                                SmallestBranchHelper(current.RightChild));
        }

        //===============================================================

        /// <summary>
        /// Finds if on Binary Tree (tree1) is contained in another Binary Tree (tree2).
        /// </summary>
        /// <param name="tree1Root">The root of the tree that may be contained in tree2</param>
        /// <param name="tree2Root">The root of the tree that may be containing tree1</param>
        /// <returns>True or false</returns>
        public static bool IsTree1ContainedInTree2(Node<int> tree1Root, Node<int> tree2Root)
        {
            return FindRootMatch(tree1Root, tree2Root);
        }

        private static bool FindRootMatch(Node<int> tree1Root, Node<int> tree2Current)
        {
            // base case:
            if (tree2Current == null)
            {
                return false;
            }

            // check if the current node matches the root
            // if true, compare the trees 
            if (tree2Current.Value == tree1Root.Value)
            {
                return CompareTwoTrees(tree1Root, tree2Current);
            }

            return FindRootMatch(tree1Root, tree2Current.LeftChild) ||
            FindRootMatch(tree1Root, tree2Current.RightChild);
        }

        private static bool CompareTwoTrees(Node<int> current1, Node<int> current2)
        {
            //base case:
            if (current1 == null && current2 == null)
            {
                return true;
            }

            if (current1 != null || current2 != null)
            {
                return false;
            }

            if (current1.Value == current2.Value)
            {
                bool leftMatch = CompareTwoTrees(current1.LeftChild, current2.LeftChild);
                bool rightMatch = CompareTwoTrees(current1.RightChild, current2.RightChild);

                return leftMatch && rightMatch;
            }
            else
            {
                return false;
            }
            
        }


        

    }
}
