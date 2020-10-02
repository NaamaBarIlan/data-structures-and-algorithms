using System;
using System.Collections.Generic;
using Trees;

namespace BinaryTreePaths
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree Paths!");

            // Arrange a Binary Tree
            Tree<char> tree = new Tree<char>();

            Node<char> root = new Node<char>('a');
            Node<char> b = new Node<char>('b');
            Node<char> c = new Node<char>('c');
            Node<char> d = new Node<char>('d');
            Node<char> e = new Node<char>('e');
            Node<char> f = new Node<char>('f');
            Node<char> g = new Node<char>('g');

            tree.Root = root;

            root.LeftChild = b;
            root.RightChild = c;

            b.LeftChild = d;
            b.RightChild = e;

            c.LeftChild = f;
            c.RightChild = g;

            // Act

            List<string> paths = AllBinaryTreePaths(tree);

            // Assert

            foreach (var path in paths)
            {
                Console.WriteLine(path);
            }

        }

        public static List<string> AllBinaryTreePaths(Tree<char> tree)
        {
            List<string> paths = new List<string>();

            Node<char> root = tree.Root;

            if (root == null)
            {
                return paths;
            }

            AllBinaryTreePaths(root, "", paths);
            return paths;
        }

        private static void AllBinaryTreePaths(Node<char> root, string path, List<string> paths)
        {
            path += root.Value;

            if (root.LeftChild == null && root.RightChild == null)
            {
                paths.Add(path);
            }

            if (root.LeftChild != null)
            {
                AllBinaryTreePaths(root.LeftChild, path + "->", paths);
            }

            if (root.RightChild != null)
            {
                AllBinaryTreePaths(root.RightChild, path + "->", paths);
            }
        }
    }
}
