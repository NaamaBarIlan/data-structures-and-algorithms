﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Trees
{
    public class Tree<T>
    {
        public Node<T> Root { get; set; }

        public Tree()
        {

        }

        public Tree(T value)
        {
            Node<T> root = new Node<T>(value);
            Root = root;
        }

        /// <summary>
        /// Conducts a preorder traversal or a binary tree,
        /// through indirect recursion with the overload method.
        /// </summary>
        /// <param name="root">The top Node in the tree</param>
        /// <returns>A list of the all the values in the binary tree</returns>
        public List<T> PreOrder(Node<T> root)
        {
            List<T> traversal = new List<T>();
            PreOrder(traversal, root);
            return traversal;
        }

        /// <summary>
        /// This overloaded method is used in the indirect recursion in the PreOrder method.
        /// It traverses the tree from root to left to right, 
        /// captures each of the values in a list and returns that list.
        /// </summary>
        /// <param name="traversal">The list object that will inserted with values</param>
        /// <param name="root">The top Node in the tree</param>
        private void PreOrder(List<T> traversal, Node<T> root)
        {
            traversal.Add(root.Value);

            if (root.LeftChild != null)
            {
                PreOrder(traversal, root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PreOrder(traversal, root.RightChild);
            }
        }

        /// <summary>
        /// Conducts a in-order traversal or a binary tree,
        /// through indirect recursion with the overload method.
        /// </summary>
        /// <param name="root">The top Node in the tree</param>
        /// <returns>A list of the all the values in the binary tree</returns>
        public List<T> InOrder(Node<T> root)
        {
            List<T> traversal = new List<T>();
            InOrder(traversal, root);
            return traversal;
        }

        /// <summary>
        /// This overloaded method is used in the indirect recursion in the InOrder method.
        /// It traverses the tree from left to root to right, 
        /// captures each of the values in a list and returns that list.
        /// </summary>
        /// <param name="traversal">The list object that will inserted with values</param>
        /// <param name="root">The top Node in the tree</param>
        private void InOrder(List<T> traversal, Node<T> root)
        {

            if (root.LeftChild != null)
            {
                InOrder(traversal, root.LeftChild);
            }
            
            traversal.Add(root.Value);

            if (root.RightChild != null)
            {
                InOrder(traversal, root.RightChild);
            }
        }

        /// <summary>
        /// Conducts a postorder traversal or a binary tree,
        /// through indirect recursion with the overload method.
        /// </summary>
        /// <param name="root">The top Node in the tree</param>
        /// <returns>A list of the all the values in the binary tree</returns>
        public List<T> PostOrder(Node<T> root)
        {
            List<T> traversal = new List<T>();
            PostOrder(traversal, root);
            return traversal;
        }

        /// <summary>
        /// This overloaded method is used in the indirect recursion in the PostOrder method.
        /// It traverses the tree from left to right to root, 
        /// captures each of the values in a list and returns that list.
        /// </summary>
        /// <param name="traversal">The list object that will inserted with values</param>
        /// <param name="root">The top Node in the tree</param>
        private void PostOrder(List<T> traversal, Node<T> root)
        {

            if (root.LeftChild != null)
            {
                PostOrder(traversal, root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PostOrder(traversal, root.RightChild);
            }

            traversal.Add(root.Value);
        }

        /// <summary>
        /// Traverse a Binary Tree of data type int to find the maximum value
        /// </summary>
        /// <param name="tree">The Binary Tree being traversed</param>
        /// <returns>The maximum value of all the tree node int values</returns>
        public int FindMaximumValue(Tree<int> tree)
        {
            int temp = 0;

            return PreOrderMaxValue(temp, tree.Root);
        }

        private int PreOrderMaxValue(int temp, Node<int> root)
        {
            if (root.Value > temp)
            {
                temp = root.Value;
            }

            if (root.LeftChild != null)
            {
                temp = PreOrderMaxValue(temp, root.LeftChild);
            }

            if (root.RightChild != null)
            {
                temp = PreOrderMaxValue(temp, root.RightChild);
            }

            return temp;

        }

        /// <summary>
        /// Counting the number of nodes in a tree,
        /// using Depth First traversal
        /// </summary>
        /// <param name="root">The top Node in the tree</param>
        /// <returns>The number of nodes in the tree</returns>
        public int CountTreeNodesDepth(Node<int> root)
        {
            int counter = 0;
            CountTreeNodesDepth(counter, root);
            return counter;
        }

        private void CountTreeNodesDepth(int counter, Node<int> root)
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

        /// <summary>
        /// Count the number of leaves in a tree
        /// </summary>
        /// <param name="root">The top Node in the tree</param>
        /// <returns></returns>
        public int CountTreeLeavesDepth(Node<int> root)
        {
            int counter = 0;
            CountTreeLeavesDepth(counter, root);
            return counter;
        }

        private void CountTreeLeavesDepth(int counter, Node<int> root)
        {
            if (root.RightChild == null && root.LeftChild == null)
            {
                counter++;
            }

            if (root.RightChild != null)
            {
                CountTreeLeavesDepth(counter, root.RightChild);
            }

            if (root.LeftChild != null)
            {
                CountTreeLeavesDepth(counter, root.LeftChild);
            }
        }


        public static int CountTreeNodesBreath(Tree<string> tree)
        {
            int counter = 0;

            Queue<Node<String>> que = new Queue<Node<String>>();

            que.Enqueue(tree.Root);

            while (que.Peek() != null)
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
    }
}
