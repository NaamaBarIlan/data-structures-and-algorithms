using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class ATreeIntersection
    {
        /// <summary>
        /// Takes two int binary trees, declares an int hashset and an int list, 
        /// recursively traverses treeOne, and adds the values to the hashset, 
        /// then recursively traverses treeTwo and tries to add each value to the hashset,
        /// any value that already exists in the hashset is added to the list, 
        /// then the list of intersecting values is returned. 
        /// </summary>
        /// <param name="treeOne">The first binary tree to compare</param>
        /// <param name="treeTwo">The second binary tree to compare</param>
        /// <returns>A list of all the values that exist in both trees</returns>
        public static List<int> TwoTreesIntersection(Tree<int> treeOne, Tree<int> treeTwo)
        {

            HashSet<int> hashset = new HashSet<int>();
            List<int> output = new List<int>();
            TreeTraversal(treeOne.Root, hashset);
            TreeTraversalTwo(treeTwo.Root, hashset, output);
            return output;
        }

        /// <summary>
        /// A pre-order depth-first recursive traversal of a binary tree,
        /// which stores each node's value as a key in the Hashset
        /// </summary>
        /// <param name="root">The root of the tree that is being traversed</param>
        /// <param name="hashset">The hashset in which the values will be stored</param>
        private static void TreeTraversal(Node<int> root, HashSet<int> hashset)
        {
            // ROOT
            hashset.Add(root.Value);
            
            // LEFT
            if (root.LeftChild != null)
            {
                TreeTraversal(root.LeftChild, hashset);
            }

            // RIGHT
            if (root.RightChild != null)
            {
                TreeTraversal(root.RightChild, hashset);
            }
        }


        /// <summary>
        /// A pre-order depth-first recursive traversal of a binary tree,
        /// which check if each nodes value already exists in the hashset, 
        /// if so, the value is added to the output list
        /// </summary>
        /// <param name="root">The root of the tree that is being traversed</param>
        /// <param name="hashset">The hashset of values that are being compared</param>
        /// <param name="output">The int list to which intersecting values are added</param>
        private static void TreeTraversalTwo(Node<int> root, HashSet<int> hashset, List<int> output)
        {
            // ROOT
            if (!hashset.Add(root.Value))
            {
                output.Add(root.Value);
            }

            // LEFT
            if (root.LeftChild != null)
            {
                TreeTraversalTwo(root.LeftChild, hashset, output);
            }

            // RIGHT
            if (root.RightChild != null)
            {
                TreeTraversalTwo(root.RightChild, hashset, output);
            }
        }

    }
}
