using System;
using System.Collections.Generic;
using System.Text;
using Trees;

namespace Traversals
{
    class TreeTraversals
    {
		// Counting the number of nodes in a tree

		// Depth First

		public List<string> PreOrder(Node<string> root)
        {
			List<string> list = new List<string>();
			PreOrder(list, root);
			return list;
        }

		private void PreOrder(List<string> list, Node<string> root)
        {
			list.Add(root.Value);
			
			if(root.LeftChild != null)
            {
				PreOrder(list, root.LeftChild);
            }

			if(root.LeftChild != null)
            {
				PreOrder(list, root.RightChild);
            }
        }

        // Breath First
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

        //Counting the number of leaves in a tree

        // Depth First

        // Breath First

        //Counting the number of right branches in a tree

        // Depth First

        // Breath First

        //Count the number of duplicated nodes in a tree

        // Depth First

        // Breath First
    }

}
