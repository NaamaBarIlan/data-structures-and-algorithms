using System;
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
        /// <param name="root">A unique value that is the root of the binary tree</param>
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
        /// <param name="root">A unique root value</param>
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
        /// Conducts a inorder traversal or a binary tree,
        /// through indirect recursion with the overload method.
        /// </summary>
        /// <param name="root">A unique value that is the root of the binary tree</param>
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
        /// <param name="root">A unique root value</param>
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
        /// <param name="root">A unique value that is the root of the binary tree</param>
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
        /// <param name="root">A unique root value</param>
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

        //public int FindMaximumValue(Tree<T> tree)
        //{
        //    //create a temp value
        //    int temp = 0;
           
        //    //traverse the tree


        //    // compare each value to the temp value
        //    // if greater, assign the new value to temp

        //    return temp;
        //}

        public int FindMaximumValue(Tree<int> tree)
        {
            int temp = 0;
            PreOrderMaxValue(temp, tree.Root);
            return temp;
        }

        private void PreOrderMaxValue(int temp, Node<int> root)
        {
            if (root.Value > temp)
            {
                temp = root.Value;
            }

            if (root.LeftChild != null)
            {
                PreOrderMaxValue(temp, root.LeftChild);
            }

            if (root.RightChild != null)
            {
                PreOrderMaxValue(temp, root.RightChild);
            }
        }

    }
}
