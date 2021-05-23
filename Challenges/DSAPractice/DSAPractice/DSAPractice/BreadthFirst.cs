using System;
using System.Collections.Generic;
using System.Text;

namespace DSAPractice
{
    public class BreadthFirst
    {
        /// <summary>
        /// Counts the number of nodes in a tree iteratively,
        /// using a breadth first traversal
        /// </summary>
        /// <param name="tree">The tree that is being traversed</param>
        /// <returns>The total count of nodes in the tree</returns>
        public static int CountTreeNodesBreath(Tree<string> tree)
        {
            int counter = 0;

            Queue<Node<String>> que = new Queue<Node<String>>();

            que.Enqueue(tree.Root);

            while (que.Count != 0)
            {
                Node<String> front = que.Dequeue();

                counter++;

                if (front.LeftChild != null)
                {
                    que.Enqueue(front.LeftChild);
                }

                if (front.RightChild != null)
                {
                    que.Enqueue(front.RightChild);
                }
            }

            return counter;
        }

        /// <summary>
        /// Counts the number of leaves in a tree iteratively,
        /// using a breadth first traversal
        /// </summary>
        /// <param name="root">The root node of the tree that is being traversed</param>
        /// <returns>The total count of leaves in the tree</returns>
        public static int CountTreeLeavesBreadth(Node<string> root)
        {
            int counter = 0;
            
            Queue<Node<string>> que = new Queue<Node<string>>();

            que.Enqueue(root);

            while(que.Count != 0)
            {
                Node<string> front = que.Dequeue();

                if(front.LeftChild == null && front.RightChild == null)
                {
                    counter++;
                }

                if(front.LeftChild != null)
                {
                    que.Enqueue(front.LeftChild);
                }

                if(front.RightChild != null)
                {
                    que.Enqueue(front.RightChild);
                }
            }

            return counter;
        }

        public static int CountRightBranchesBreadth(Node<string> root)
        {
            int counter = 0;

            Queue<Node<string>> que = new Queue<Node<string>>();

            que.Enqueue(root);

            while(que.Count != 0)
            {
                Node<string> front = que.Dequeue();

                if(front.LeftChild != null)
                {
                    que.Enqueue(front.LeftChild);
                }

                if(front.RightChild != null)
                {
                    counter++;
                    que.Enqueue(front.RightChild);
                }
            }

            return counter;
        }

        /// <summary>
        /// Takes in a Binary Tree and returns the sum 
        /// of all of its nodes' depths.
        /// A node's depth is the distance between a node in a Binary Tree
        /// and the tree's root
        /// </summary>
        /// <param name="root">The root node of a specific Binary Tree</param>
        /// <returns>The sum of all the tree nodes' depth.</returns>
        public static int NodeDepths(Node<string> root)
        {
            Queue<Node<string>> que = new Queue<Node<string>>();
            root.DepthLevel = 0;
            int sumOfDepths = 0;
            if (root == null)
            {
                return 0;
            }

            que.Enqueue(root);

            while (que.Count != 0)
            {
                Node<string> front = que.Dequeue();

                sumOfDepths += front.DepthLevel;

                if (front.LeftChild != null)
                {
                    front.LeftChild.DepthLevel = front.DepthLevel + 1;
                    que.Enqueue(front.LeftChild);
                }

                if (front.RightChild != null)
                {
                    front.RightChild.DepthLevel = front.DepthLevel + 1;
                    que.Enqueue(front.RightChild);
                }
            }

            return sumOfDepths;
        }
    }
}
