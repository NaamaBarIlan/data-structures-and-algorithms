using System;
using Trees;

namespace OrderBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReOrder a BST!");
        }

        public Node<int> IncreasingBST(Node<int> root)
        {
            // declare a temp node
            Node<int> temp = new Node<int>(0);
			Node<int> current = root;

			// depth first post-order traversal of the left side of the tree <from large to small value)

			// Check if the root has no children:
			if (current.LeftChild == null && current.RightChild == null)
            {
				return null;
			}

			// While the node has children, isn't a leaf.
			while (current.LeftChild != null && current.RightChild != null)
			{
				
			}

			// at each node re-assign the node to be the root and the root to be root.RC
			// depth first pre-order traversal of the right side of the tree
			// if a LC exists, assign it to temp, and insert it ahead of the sub tree root

		}
    }
}
